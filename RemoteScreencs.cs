using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMinfo_Front
{
    public partial class RemoteScreencs : Form
    {
        public RemoteScreencs()
        {
            InitializeComponent();

            if (Home.open2 == true)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
                pictureBox1.Width = Screen.PrimaryScreen.Bounds.Width;
                pictureBox1.Height = Screen.PrimaryScreen.Bounds.Width;
                
                Home.open2 = false;
                dropcon = false;
                Task.Run(() => listen());
                textBox1.Focus();
                this.ActiveControl = textBox1;
            }

           

        }

        #region TCP Server and Image Treatment

        TcpListener server = null;
        TcpClient client = null;
        bool click = false;
        bool leftclick = false;
        bool rightclick = false;
        bool dclick = false;
        bool dropcon = false;
        bool keyenter = false;
        bool serverunning = false;
        string key = "";

        public void listen()
        {
            Stopwatch st = new Stopwatch();


            int FPScount = 0;
            double prevMilliSec = 0;
            double currentMilliSec = 0;


            try
            {
                Int32 port = 9090;
                IPAddress localAddr = IPAddress.Any;
                server = new TcpListener(localAddr, port);
                server.Start();
                byte[] bytes = new byte[1024000];
                string picresW = pictureBox1.Width.ToString();
                string picresH = pictureBox1.Height.ToString();
                bool connection = false;
                bool firstcon = true;
                bool rdycon = false;
                int concount = 0;
                while (true)
                {

                    if (rdycon == false)
                    {
                        concount++;
                        if (concount >= 5)
                        {
                            MessageBox.Show("Connection Lost");
                            server.Stop();
                            concount = 0;
                            dropcon = true;
                            break;
                        }
                    }
                    else
                    {
                        concount = 0;
                        rdycon = false;
                    }

                    client = server.AcceptTcpClient();
                    client.NoDelay = true;
                    client.ReceiveBufferSize = 16384;
                    client.ReceiveTimeout = 15000;
                    NetworkStream stream = client.GetStream();
                    string mouse = "";
                    connection = true;
                    firstcon = true;
                    serverunning = true;
                    rdycon = true;
                    while (connection == true)
                    {
                        st.Start();

                        

                        try
                        {
                            stream.Read(bytes, 0, bytes.Length);
                        }
                        catch
                        {
                            connection = false;
                        }

                        try
                        {


                            this.BeginInvoke((MethodInvoker)delegate ()
                            {
                                try
                                {
                                    TimeSpan ts = st.Elapsed;
                                    currentMilliSec += ts.TotalMilliseconds - prevMilliSec;
                                    prevMilliSec = ts.TotalMilliseconds;
                                    FPScount += 1;

                                    if (currentMilliSec >= 1000.0f)
                                    {
                                        label1.Text = "FPS: " + FPScount.ToString() + "  " + "MilliSeconds:" + currentMilliSec.ToString() + "\r\n";
                                        FPScount = 0;
                                        currentMilliSec = 0;
                                    }

                                    MemoryStream ms = new MemoryStream(bytes);
                                    Image tel = Image.FromStream(ms);
                                    Bitmap resadjust = new Bitmap(tel, Convert.ToInt32(picresW), Convert.ToInt32(picresH));
                                    pictureBox1.Image = resadjust;
                                }
                                catch
                                {
                                    connection = false;
                                    stream.Close();
                                }

                            });

                            string clicks = "false";
                            string var = "";

                            if (click == true)
                            {
                                click = false;

                                if (leftclick == true)
                                {
                                    clicks = "leftrue";
                                    leftclick = false;
                                }
                                if (rightclick == true)
                                {
                                    clicks = "righttrue";
                                    rightclick = false;
                                }


                            }

                            if (dclick == true)
                            {
                                clicks = "doubletrue";
                                dclick = false;
                            }

                            if (firstcon == true)
                            {
                                firstcon = false;

                                var = picresW + "&" + picresH + "&" + clicks + "&" + key;
                            }
                            else
                            {
                                mouse = Cursor.Position.X.ToString() + "&" + Cursor.Position.Y.ToString() + "&" + clicks + "&" + key;
                                var = mouse;
                            }

                            if (keyenter == true)
                            {
                                key = "enter";
                                MessageBox.Show(key);
                                keyenter = false;
                            }

                            byte[] msg = new byte[16384];
                            msg = Encoding.ASCII.GetBytes(var);
                            stream.Write(msg, 0, msg.Length);
                            key = "";
                        }
                        catch
                        {
                            connection = false;
                        }

                        if (dropcon == true)
                        {
                            break;
                        }
                    }

                    stream.Close();

                    if (dropcon == true)
                    {
                        rdycon = false;
                        dropcon = false;
                        break;
                    }
                    rdycon = false;
                }
                client.Close();
                server.Stop();

            }
            catch
            {
                
                server.Stop();
            }


            this.BeginInvoke((MethodInvoker)delegate ()
            {
                try
                {
                    client.Close();
                    server.Stop();
                    this.Close();
                }
                catch
                { }
            });

        }

        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            dclick = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;

            if (e.Button == MouseButtons.Right)
            {
                rightclick = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                leftclick = true;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode.ToString();
            textBox1.Text = "";

        }

        private void RemoteScreencs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home.pcform2.Dispose();
            Home.pcform2 = null;
            Home.openform2 = false;
            ListenerPC1.responses = "discremote";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListenerPC1.responses = "discremote";
            dropcon = true;
            if (serverunning == false)
            {
                this.Close();
            }
        }
    }
}
