using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography;
using CircularProgressBar;
using System.IO;

namespace WMinfo_Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThreadListenerPC1();
            T1();
            kekImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "cross final.png");
            popImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "test.gif");
            pgreen = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pgreen.png");
            pred = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pRed.png");
            pyellow = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pYellow.png");
        }
        Image kekImage;
        Image popImage;
        Image pgreen;
        Image pred;
        Image pyellow;
        public static bool cmdinit = true;
        public void ThreadListenerPC1()
        {
            ListenerPC1 listener = new ListenerPC1();
            Thread TListenerPC1 = new Thread(new ThreadStart(listener.StartListen));
            TListenerPC1.IsBackground = true;
            TListenerPC1.Start();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sidemenupanel.Width == 185)
            {
                sidemenupanel.Width = 20;
            }
            else
            {
                sidemenupanel.Width = 185;
            }

        }




        private void addbox_Click(object sender, EventArgs e)
        {
            hname1.Text = "\nHost-Name: Desk9isPC" + "\n\nApiKey: " + "#"+apikey();
        }

        #region APIKEY Method's
        protected string apikey()
        {

            string apiKey = "";
            var key = new byte[9];
            bool ver = false;
            do
            {
                ver = false;
                string apistring = "";
                using (var generator = RandomNumberGenerator.Create())
                    generator.GetBytes(key);

                apistring = Convert.ToBase64String(key);
                char[] breaker = apistring.ToCharArray();
                for (int i = 0; i < apistring.Length; i++)
                {
                    if (apistring[i].ToString() == "+" || apistring[i].ToString() == "/" || apistring[i].ToString() == "(" || apistring[i].ToString() == ")" || apistring[i].ToString() == "=" || apistring[i].ToString() == "-" || apistring[i].ToString() == "&" || apistring[i].ToString() == "*" || apistring[i].ToString() == "%" || apistring[i].ToString() == "$" || apistring[i].ToString() == "#" || apistring[i].ToString() == "@" || apistring[i].ToString() == "-" || apistring[i].ToString() == "/" || apistring[i].ToString() == " " || apistring[i].ToString() == ".")
                    {
                        ver = true;
                        break;
                    }
                }


            }
            while (ver == true);
            apiKey = Convert.ToBase64String(key);
            return apiKey;

        }
        #endregion

        private void addbox_MouseEnter(object sender, EventArgs e)
        {
            addbox.Image = popImage;
        }

        private void addbox_MouseLeave(object sender, EventArgs e)
        {
            addbox.Image = kekImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void servico2_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        void T1()
        {
            Thread att = new Thread(new ThreadStart(WorkPC1Async));
            att.IsBackground = true; 
            att.Start();
        }

        public async void WorkPC1Async()
        {
            while (true)
            {
                Thread.Sleep(300);

                await Task.Run(UpdatePC1MethodAsync);
            }
        }

        #region PC1 Method's

        public static string[] PC1 = new string[70];
        public static int PC1Cores;
        public static bool vganotdetected;
        static double maxd=0;
        static double maxup=0;
        public static double up = 0;
        public static double down = 0;
        public static bool PC1ON;
        public int PC1offcounter = 0;
        public static double PC1raminuse = 0;
        public static bool PC1init = true;
        public static int PC1hddcount = 0;
        public static double[] PC1hddmath = new double[7];
        public static double[] PC1hddmath2 = new double[7];


        async Task UpdatePC1MethodAsync()
        {
            

            if (PC1ON == true)
            {

                PC1ON = false;

                try
                {
                    PC1offcounter = 0;

                    this.home1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        home1.pconoff.Text = "ON-LINE";
                        home1.pconoff.ForeColor = Color.Chartreuse;
                    });

                    #region BASIC INFO

                    this.home1.BeginInvoke((MethodInvoker)delegate ()
                    {
                            home1.hname1.Text = PC1[31];
                            string[] namesplit = PC1[31].Split('\n');
                            hname1.Text = namesplit[0] + "\n\n" + namesplit[2];
                    });


                    #endregion

                    #region CPU

                    #region Quad-Cores

                    if (PC1Cores == 4)
                    {
                        #region Brand and Model's

                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.pname.Text = PC1[0] + "\n\nCores: " + PC1Cores.ToString();
                        });

                        #endregion

                        #region Tree View
                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            ProgressBar pb = new ProgressBar();
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[0].Text = PC1[1];//bus
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[1].Text = PC1[2];//clock1
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[2].Text = PC1[3];//clock2
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[3].Text = PC1[4];//clock3
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[4].Text = PC1[5];//clock4

                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[0].Text = "Package " + PC1[6] + "ºC";//Temppack
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[1].Text = PC1[7];//Temp1
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[2].Text = PC1[8];//Temp2
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[3].Text = PC1[9];//Temp3
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[4].Text = PC1[10];//Temp4

                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[0].Text = "Package " + PC1[11] + "%";//Loadpack
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[1].Text = PC1[12];//Load1
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[2].Text = PC1[13];//Load2 
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[3].Text = PC1[14];//Load3 
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[4].Text = PC1[15];//Load4 


                        });
                        #endregion

                        #region Charts

                        int loadpack = 0;
                        int temppack = 0;



                        loadpack = Convert.ToInt32(PC1[11]);
                        temppack = Convert.ToInt32(PC1[6]);



                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            if (loadpack <= 40)
                            {
                                home1.chartcpuload.ProgressColor = Color.Chartreuse;
                                home1.chartcpuload.ForeColor = Color.Chartreuse;
                                home1.chartcpuload.SubscriptColor = Color.Chartreuse;
                            }

                            if (loadpack > 40 && loadpack < 80)
                            {
                                home1.chartcpuload.ProgressColor = Color.DarkOrange;
                                home1.chartcpuload.ForeColor = Color.DarkOrange;
                                home1.chartcpuload.SubscriptColor = Color.DarkOrange;
                            }
                            if (loadpack >= 80)
                            {
                                home1.chartcpuload.ProgressColor = Color.OrangeRed;
                                home1.chartcpuload.ForeColor = Color.OrangeRed;
                                home1.chartcpuload.SubscriptColor = Color.OrangeRed;
                            }

                            home1.chartcpuload.Text = "LOAD" + "\n" + loadpack.ToString() + "%";
                            home1.chartcpuload.Value = loadpack;

                            if (temppack <= 45)
                            {
                                home1.charcputemp.ProgressColor = Color.Chartreuse;
                                home1.charcputemp.ForeColor = Color.Chartreuse;
                                home1.charcputemp.SubscriptColor = Color.Chartreuse;
                                pc1t.ForeColor = Color.Chartreuse;
                            }

                            if (temppack > 45 && temppack <= 75)
                            {
                                home1.charcputemp.ProgressColor = Color.DarkOrange;
                                home1.charcputemp.ForeColor = Color.DarkOrange;
                                home1.charcputemp.SubscriptColor = Color.DarkOrange;
                                pc1t.ForeColor = Color.DarkOrange;
                            }

                            if (temppack > 75)
                            {
                                home1.charcputemp.ProgressColor = Color.OrangeRed;
                                home1.charcputemp.ForeColor = Color.OrangeRed;
                                home1.charcputemp.SubscriptColor = Color.OrangeRed;
                                pc1t.ForeColor = Color.OrangeRed;
                            }

                            pc1t.Text = temppack.ToString() + "ºC";
                            home1.charcputemp.Text = "TEMP" + "\n" + temppack.ToString() + "ºC";
                            home1.charcputemp.Value = temppack;



                        });


                        #endregion

                    }

                    #endregion

                    #region Dual-Cores

                    if (PC1Cores == 2)
                    {
                        #region Brand and Model's

                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.pname.Text = PC1[0] + "\n\nCores: " + PC1Cores.ToString();
                        });

                        #endregion

                        #region Tree View
                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            ProgressBar pb = new ProgressBar();
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[0].Text = PC1[1];//bus
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[1].Text = PC1[2];//clock1
                            home1.CPUTV.Nodes[0].Nodes[0].Nodes[2].Text = PC1[3];//clock2

                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[0].Text = "Package " + PC1[4] + "ºC";//Temppack
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[1].Text = PC1[5];//Temp1
                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[2].Text = PC1[6];//Temp2

                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[0].Text = "Package " + PC1[7] + "%";//Loadpack
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[1].Text = PC1[8];//Load1
                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[2].Text = PC1[9];//Load2 

                        });
                        #endregion

                        #region Charts

                        int loadpack = 0;
                        int temppack = 0;



                        loadpack = Convert.ToInt32(PC1[7]);
                        temppack = Convert.ToInt32(PC1[4]);

                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            if (loadpack <= 40)
                            {
                                home1.chartcpuload.ProgressColor = Color.Chartreuse;
                                home1.chartcpuload.ForeColor = Color.Chartreuse;
                                home1.chartcpuload.SubscriptColor = Color.Chartreuse;
                            }

                            if (loadpack > 40 && loadpack < 80)
                            {
                                home1.chartcpuload.ProgressColor = Color.DarkOrange;
                                home1.chartcpuload.ForeColor = Color.DarkOrange;
                                home1.chartcpuload.SubscriptColor = Color.DarkOrange;
                            }
                            if (loadpack >= 80)
                            {
                                home1.chartcpuload.ProgressColor = Color.OrangeRed;
                                home1.chartcpuload.ForeColor = Color.OrangeRed;
                                home1.chartcpuload.SubscriptColor = Color.OrangeRed;
                            }

                            home1.chartcpuload.Text = "LOAD" + "\n" + loadpack.ToString() + "%";
                            home1.chartcpuload.Value = loadpack;

                            if (temppack <= 45)
                            {
                                home1.charcputemp.ProgressColor = Color.Chartreuse;
                                home1.charcputemp.ForeColor = Color.Chartreuse;
                                home1.charcputemp.SubscriptColor = Color.Chartreuse;
                                pc1t.ForeColor = Color.Chartreuse;
                            }

                            if (temppack > 45 && temppack <= 75)
                            {
                                home1.charcputemp.ProgressColor = Color.DarkOrange;
                                home1.charcputemp.ForeColor = Color.DarkOrange;
                                home1.charcputemp.SubscriptColor = Color.DarkOrange;
                                pc1t.ForeColor = Color.DarkOrange;
                            }

                            if (temppack > 75)
                            {
                                home1.charcputemp.ProgressColor = Color.OrangeRed;
                                home1.charcputemp.ForeColor = Color.OrangeRed;
                                home1.charcputemp.SubscriptColor = Color.OrangeRed;
                                pc1t.ForeColor = Color.OrangeRed;
                            }

                            home1.charcputemp.Text = "TEMP" + "\n" + temppack.ToString() + "ºC";
                            home1.charcputemp.Value = temppack;
                            pc1t.Text = temppack.ToString() + "ºC";


                        });


                        #endregion

                    }

                    #endregion

                    #endregion

                    #region GPU

                    #region Detection
                    if (vganotdetected == true)
                    {
                        this.home1.GPUP.BeginInvoke((MethodInvoker)delegate ()
                        {

                            home1.gpunotdetected.Visible = true;
                            home1.gpunotdetected.BringToFront();

                        });


                    }
                    else
                    {
                        this.home1.GPUP.BeginInvoke((MethodInvoker)delegate ()
                        {

                            home1.gpunotdetected.Visible = false;
                            home1.gpunotdetected.SendToBack();

                        });
                    }
                    #endregion

                    #region Brand and Model's

                    this.home1.GPUP.BeginInvoke((MethodInvoker)delegate ()
                    {
                        home1.gname.Text = PC1[16];
                    });

                    #endregion

                    #region TreeView
                    this.home1.GPUP.BeginInvoke((MethodInvoker)delegate ()
                    {

                        home1.GPUTV.Nodes[0].Nodes[0].Nodes[0].Text = PC1[17];//Core Clock
                        home1.GPUTV.Nodes[0].Nodes[0].Nodes[1].Text = PC1[18];//Shader Clock
                        home1.GPUTV.Nodes[0].Nodes[0].Nodes[2].Text = PC1[19];//Memory Clock

                        home1.GPUTV.Nodes[0].Nodes[1].Nodes[0].Text = "Core Temperature " + PC1[20] + "ºC";//Core Temp

                        home1.GPUTV.Nodes[0].Nodes[2].Nodes[0].Text = "Core Load " + PC1[21] + "%";//Core Load
                        home1.GPUTV.Nodes[0].Nodes[2].Nodes[1].Text = PC1[22];//Memory Load

                        home1.GPUTV.Nodes[0].Nodes[3].Nodes[0].Text = PC1[23];//FanSpeed


                    });
                    #endregion

                    #region GPU Charts

                    int loadpack1 = 0;
                    int temppack1 = 0;



                    loadpack1 = Convert.ToInt32(PC1[21]);
                    temppack1 = Convert.ToInt32(PC1[20]);



                    this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                    {
                        if (loadpack1 <= 40)
                        {
                            home1.chartgpuload.ProgressColor = Color.Chartreuse;
                            home1.chartgpuload.ForeColor = Color.Chartreuse;
                            home1.chartgpuload.SubscriptColor = Color.Chartreuse;
                        }

                        if (loadpack1 > 40 && loadpack1 < 80)
                        {
                            home1.chartgpuload.ProgressColor = Color.DarkOrange;
                            home1.chartgpuload.ForeColor = Color.DarkOrange;
                            home1.chartgpuload.SubscriptColor = Color.DarkOrange;
                        }
                        if (loadpack1 >= 80)
                        {
                            home1.chartgpuload.ProgressColor = Color.OrangeRed;
                            home1.chartgpuload.ForeColor = Color.OrangeRed;
                            home1.chartgpuload.SubscriptColor = Color.OrangeRed;
                        }

                        home1.chartgpuload.Text = "LOAD" + "\n" + loadpack1.ToString() + "%";
                        home1.chartgpuload.Value = loadpack1;

                        if (temppack1 <= 50)
                        {
                            home1.chargputemp.ProgressColor = Color.Chartreuse;
                            home1.chargputemp.ForeColor = Color.Chartreuse;
                            home1.chargputemp.SubscriptColor = Color.Chartreuse;
                        }

                        if (temppack1 > 50 && temppack1 <= 85)
                        {
                            home1.chargputemp.ProgressColor = Color.DarkOrange;
                            home1.chargputemp.ForeColor = Color.DarkOrange;
                            home1.chargputemp.SubscriptColor = Color.DarkOrange;
                        }

                        if (temppack1 > 85)
                        {
                            home1.chargputemp.ProgressColor = Color.OrangeRed;
                            home1.chargputemp.ForeColor = Color.OrangeRed;
                            home1.chargputemp.SubscriptColor = Color.OrangeRed;

                        }

                        home1.chargputemp.Text = "TEMP" + "\n" + temppack1.ToString() + "ºC";
                        home1.chargputemp.Value = temppack1;



                    });

                    #endregion

                    #endregion

                    #region RAM

                    #region TreeView

                    this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                    {
                        home1.RAMTV.Nodes[0].Nodes[0].Text = "Total Ram: " + PC1[27];//total
                        home1.RAMTV.Nodes[0].Nodes[1].Text = "Free Ram: " + PC1[28];//free
                    });

                    #endregion
                    #region MOBO

                    #region Ram Charts


                    this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                    {
                        home1.Ramchart.Text = "RAM\n" + PC1raminuse.ToString() + "%" + "\n" + PC1[29];
                        home1.Ramchart.Value = Convert.ToInt32(PC1raminuse);

                        if (PC1raminuse <= 40)
                        {
                            home1.Ramchart.ProgressColor = Color.Chartreuse;
                            home1.Ramchart.ForeColor = Color.Chartreuse;
                        }

                        if (PC1raminuse > 40 && PC1raminuse < 80)
                        {
                            home1.Ramchart.ProgressColor = Color.DarkOrange;
                            home1.Ramchart.ForeColor = Color.DarkOrange;
                        }
                        if (PC1raminuse >= 80)
                        {
                            home1.Ramchart.ProgressColor = Color.OrangeRed;
                            home1.Ramchart.ForeColor = Color.OrangeRed;
                        }

                    });
                    #endregion

                    #region MOBO TEXT

                    this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                    {
                        home1.moboname.Text = PC1[30];

                    });

                    #endregion

                    #endregion

                    #endregion

                    #region HDD's

                    #region Tree View

                    this.home1.HDDP.BeginInvoke((MethodInvoker)delegate ()
                    {
                       
                        if (PC1init == true)
                        {
                            if (PC1hddcount >= 1)
                            {
                                home1.HDDTV.BeginUpdate();
                                home1.HDDTV.Nodes.Add("HDD1");

                                home1.HDDTV.Nodes[0].Nodes.Add("Local:");
                                home1.HDDTV.Nodes[0].Nodes.Add("Format:");
                                home1.HDDTV.Nodes[0].Nodes.Add("Storage");
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes.Add("Total:");
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes.Add("Free:");
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes.Add("Used:");
                                home1.HDDTV.Nodes[0].Nodes.Add("Temperatures");
                                home1.HDDTV.Nodes[0].Nodes[3].Nodes.Add("Actual:");
                                home1.HDDTV.Nodes[0].Nodes[3].Nodes.Add("Worst(lifetime):");
                                home1.HDDTV.Nodes[0].Nodes.Add("POH");
                                home1.HDDTV.Nodes[0].Nodes.Add("PCC");
                                home1.HDDTV.EndUpdate();

                                if (PC1hddcount >= 2)
                                {
                                    home1.HDDTV.BeginUpdate();
                                    home1.HDDTV.Nodes.Add("HDD2");

                                    home1.HDDTV.Nodes[1].Nodes.Add("Local:");
                                    home1.HDDTV.Nodes[1].Nodes.Add("Format:");
                                    home1.HDDTV.Nodes[1].Nodes.Add("Storage");
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes.Add("Total:");
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes.Add("Free:");
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes.Add("Used:");
                                    home1.HDDTV.Nodes[1].Nodes.Add("Temperatures");
                                    home1.HDDTV.Nodes[1].Nodes[3].Nodes.Add("Actual:");
                                    home1.HDDTV.Nodes[1].Nodes[3].Nodes.Add("Worst(lifetime):");
                                    home1.HDDTV.Nodes[1].Nodes.Add("POH");
                                    home1.HDDTV.Nodes[1].Nodes.Add("PCC");
                                    home1.HDDTV.EndUpdate();

                                }

                                if (PC1hddcount >= 3)
                                {
                                    home1.HDDTV.BeginUpdate();
                                    home1.HDDTV.Nodes.Add("HDD3");

                                    home1.HDDTV.Nodes[2].Nodes.Add("Local:");
                                    home1.HDDTV.Nodes[2].Nodes.Add("Format:");
                                    home1.HDDTV.Nodes[2].Nodes.Add("Storage");
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes.Add("Total:");
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes.Add("Free:");
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes.Add("Used:");
                                    home1.HDDTV.Nodes[2].Nodes.Add("Temperatures");
                                    home1.HDDTV.Nodes[2].Nodes[3].Nodes.Add("Actual:");
                                    home1.HDDTV.Nodes[2].Nodes[3].Nodes.Add("Worst(lifetime):");
                                    home1.HDDTV.Nodes[2].Nodes.Add("POH");
                                    home1.HDDTV.Nodes[2].Nodes.Add("PCC");
                                    home1.HDDTV.EndUpdate();

                                }

                                PC1init = false;
                            }

                            
                        }

                        if (PC1hddcount >= 1)
                        {
                            home1.hddt.Text = "HDD1 " + PC1[32];
                            home1.HDDTV.Nodes[0].Text = PC1[32];
                            home1.HDDTV.Nodes[0].Nodes[0].Text = PC1[33];
                            home1.HDDTV.Nodes[0].Nodes[1].Text = PC1[34];
                            home1.HDDTV.Nodes[0].Nodes[2].Text = "Storage";
                            home1.HDDTV.Nodes[0].Nodes[2].Nodes[0].Text = PC1[35];
                            home1.HDDTV.Nodes[0].Nodes[2].Nodes[1].Text = PC1[36];
                            home1.HDDTV.Nodes[0].Nodes[2].Nodes[2].Text = PC1[37];
                            home1.HDDTV.Nodes[0].Nodes[3].Text = "Temperatures";
                            home1.HDDTV.Nodes[0].Nodes[3].Nodes[0].Text = PC1[39];
                            home1.HDDTV.Nodes[0].Nodes[3].Nodes[1].Text = PC1[38];
                            home1.HDDTV.Nodes[0].Nodes[4].Text = PC1[40];
                            home1.HDDTV.Nodes[0].Nodes[5].Text = PC1[41];

                            if (PC1hddcount >= 2)
                            {
                                home1.hddt.Text = "HDD1 " + PC1[32] + "\n\nHDD2 " + PC1[42];
                                home1.HDDTV.Nodes[1].Text = PC1[42];
                                home1.HDDTV.Nodes[1].Nodes[0].Text = PC1[43];
                                home1.HDDTV.Nodes[1].Nodes[1].Text = PC1[44];
                                home1.HDDTV.Nodes[1].Nodes[2].Text = "Storage";
                                home1.HDDTV.Nodes[1].Nodes[2].Nodes[0].Text = PC1[45];
                                home1.HDDTV.Nodes[1].Nodes[2].Nodes[1].Text = PC1[46];
                                home1.HDDTV.Nodes[1].Nodes[2].Nodes[2].Text = PC1[47];
                                home1.HDDTV.Nodes[1].Nodes[3].Text = "Temperatures";
                                home1.HDDTV.Nodes[1].Nodes[3].Nodes[0].Text = PC1[49];
                                home1.HDDTV.Nodes[1].Nodes[3].Nodes[1].Text = PC1[48];
                                home1.HDDTV.Nodes[1].Nodes[4].Text = PC1[50];
                                home1.HDDTV.Nodes[1].Nodes[5].Text = PC1[51];

                                if (PC1hddcount >= 3)
                                {
                                    home1.hddt.Text = "HDD1 " + PC1[32] + "\n\nHDD2 " + PC1[42] + "\n\nHDD3 " + PC1[52]; ;
                                    home1.HDDTV.Nodes[2].Text = PC1[52];
                                    home1.HDDTV.Nodes[2].Nodes[0].Text = PC1[53];
                                    home1.HDDTV.Nodes[2].Nodes[1].Text = PC1[54];
                                    home1.HDDTV.Nodes[2].Nodes[2].Text = "Storage";
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes[0].Text = PC1[55];
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes[1].Text = PC1[56];
                                    home1.HDDTV.Nodes[2].Nodes[2].Nodes[2].Text = PC1[57];
                                    home1.HDDTV.Nodes[2].Nodes[3].Text = "Temperatures";
                                    home1.HDDTV.Nodes[2].Nodes[3].Nodes[0].Text = PC1[59];
                                    home1.HDDTV.Nodes[2].Nodes[3].Nodes[1].Text = PC1[58];
                                    home1.HDDTV.Nodes[2].Nodes[4].Text = PC1[60];
                                    home1.HDDTV.Nodes[2].Nodes[5].Text = PC1[61];

                                }
                            }
                        }

                    });
                    #endregion

                    #region HDD's Chart


                    this.home1.HDDP.BeginInvoke((MethodInvoker)delegate ()
                    {

                        #region Storage Chart

                        if (PC1hddcount >= 1)
                        {
                            home1.HDD1storagechart.Visible = true;
                            double hdd1storagepercent = 0;

                            
                            hdd1storagepercent = (PC1hddmath[1] / PC1hddmath[0] * 100);
                            
                            if(hdd1storagepercent <= 40)
                            {
                                home1.HDD1storagechart.ProgressColor = Color.Chartreuse;
                                home1.HDD1storagechart.ForeColor = Color.Chartreuse;
                            }

                            if (hdd1storagepercent > 40 && hdd1storagepercent < 80)
                            {
                                home1.HDD1storagechart.ProgressColor = Color.DarkOrange;
                                home1.HDD1storagechart.ForeColor = Color.DarkOrange;
                            }

                            if (hdd1storagepercent >= 80)
                            {
                                home1.HDD1storagechart.ProgressColor = Color.OrangeRed;
                                home1.HDD1storagechart.ForeColor = Color.OrangeRed;
                            }


                            home1.HDD1storagechart.Maximum = Convert.ToInt32(PC1hddmath[0]);
                            home1.HDD1storagechart.Value = Convert.ToInt32(PC1hddmath[1]);
                            home1.HDD1storagechart.Text = Convert.ToInt32(hdd1storagepercent).ToString() + "%";


                            if (PC1hddcount >= 2)
                            {
                                double hdd2storagepercent = 0;

                                home1.HDD2storagechart.Visible = true;

                                hdd2storagepercent = (PC1hddmath[3] / PC1hddmath[2] * 100);

                                if (hdd2storagepercent <= 40)
                                {
                                    home1.HDD2storagechart.ProgressColor = Color.Chartreuse;
                                    home1.HDD2storagechart.ForeColor = Color.Chartreuse;
                                }

                                if (hdd2storagepercent > 40 && hdd2storagepercent < 80)
                                {
                                    home1.HDD2storagechart.ProgressColor = Color.DarkOrange;
                                    home1.HDD2storagechart.ForeColor = Color.DarkOrange;
                                }

                                if (hdd2storagepercent >= 80)
                                {
                                    home1.HDD2storagechart.ProgressColor = Color.OrangeRed;
                                    home1.HDD2storagechart.ForeColor = Color.OrangeRed;
                                }


                                home1.HDD2storagechart.Maximum = Convert.ToInt32(PC1hddmath[2]);
                                home1.HDD2storagechart.Value = Convert.ToInt32(PC1hddmath[3]);
                                home1.HDD2storagechart.Text = Convert.ToInt32(hdd2storagepercent).ToString() + "%";

                                if (PC1hddcount >= 3)
                                {
                                    double hdd3storagepercent = 0;

                                    home1.HDD3storagechart.Visible = true;

                                    hdd3storagepercent = (PC1hddmath[5] / PC1hddmath[4] * 100);

                                    if (hdd3storagepercent <= 40)
                                    {
                                        home1.HDD3storagechart.ProgressColor = Color.Chartreuse;
                                        home1.HDD3storagechart.ForeColor = Color.Chartreuse;
                                    }

                                    if (hdd3storagepercent > 40 && hdd3storagepercent < 80)
                                    {
                                        home1.HDD3storagechart.ProgressColor = Color.DarkOrange;
                                        home1.HDD3storagechart.ForeColor = Color.DarkOrange;
                                    }

                                    if (hdd3storagepercent >= 80)
                                    {
                                        home1.HDD3storagechart.ProgressColor = Color.OrangeRed;
                                        home1.HDD3storagechart.ForeColor = Color.OrangeRed;
                                    }


                                    home1.HDD3storagechart.Maximum = Convert.ToInt32(PC1hddmath[4]);
                                    home1.HDD3storagechart.Value = Convert.ToInt32(PC1hddmath[5]);
                                    home1.HDD3storagechart.Text = Convert.ToInt32(hdd3storagepercent).ToString() + "%";

                                }

                            }

                        }
                        #endregion

                        #region Life chart

                        if (PC1hddcount >= 1)
                        {
                            double hdd1lifepercent = 0;

                            home1.HDD1lifechart.Visible = true;

                            int PCCalculation = 0;


                            if (PC1hddmath2[1] <= 500)
                            {
                                PCCalculation = 80000;
                            }

                            if (PC1hddmath2[1] > 500 && PC1hddmath2[1] <= 1000)
                            {
                                PCCalculation = 70000;
                            }

                            if (PC1hddmath2[1] > 1000 && PC1hddmath2[1] <= 1500)
                            {
                                PCCalculation = 65000;
                            }

                            if (PC1hddmath2[1] > 1500 && PC1hddmath2[1] <= 2000)
                            {
                                PCCalculation = 60000;
                            }

                            if (PC1hddmath2[1] > 2000 && PC1hddmath2[1] <= 2500)
                            {
                                PCCalculation = 55000;
                            }

                            if (PC1hddmath2[1] > 2500 && PC1hddmath2[1] <= 3000)
                            {
                                PCCalculation = 50000;
                            }

                            if (PC1hddmath2[1] > 3000 && PC1hddmath2[1] <= 3500)
                            {
                                PCCalculation = 45000;
                            }

                            if (PC1hddmath2[1] > 3500 && PC1hddmath2[1] <= 4000)
                            {
                                PCCalculation = 40000;
                            }

                            if (PC1hddmath2[1] > 4000)
                            {
                                PCCalculation = 30000;
                            }

                            hdd1lifepercent = Math.Round((PC1hddmath2[0] / PCCalculation) * 100);

                            if (hdd1lifepercent <= 40)
                            {
                                home1.HDD1lifechart.ProgressColor = Color.Chartreuse;
                                home1.HDD1lifechart.ForeColor = Color.Chartreuse;
                            }

                            if (hdd1lifepercent > 40 && hdd1lifepercent < 80)
                            {
                                home1.HDD1lifechart.ProgressColor = Color.DarkOrange;
                                home1.HDD1lifechart.ForeColor = Color.DarkOrange;
                            }

                            if (hdd1lifepercent >= 80)
                            {
                                home1.HDD1lifechart.ProgressColor = Color.OrangeRed;
                                home1.HDD1lifechart.ForeColor = Color.OrangeRed;
                            }

                            home1.HDD1lifechart.Maximum = PCCalculation;
                            home1.HDD1lifechart.Value = Convert.ToInt32(PC1hddmath2[0]);

                            home1.HDD1lifechart.Text = Convert.ToInt32(hdd1lifepercent).ToString() + "%";



                            if (PC1hddcount >= 2)
                            {

                                double hdd2lifepercent = 0;

                                home1.HDD2lifechart.Visible = true;

                                int PCCalculation2 = 0;


                                if (PC1hddmath2[3] <= 500)
                                {
                                    PCCalculation2 = 80000;
                                }

                                if (PC1hddmath2[3] > 500 && PC1hddmath2[3] <= 1000)
                                {
                                    PCCalculation2 = 70000;
                                }

                                if (PC1hddmath2[3] > 1000 && PC1hddmath2[3] <= 1500)
                                {
                                    PCCalculation2 = 65000;
                                }

                                if (PC1hddmath2[3] > 1500 && PC1hddmath2[3] <= 2000)
                                {
                                    PCCalculation2 = 60000;
                                }

                                if (PC1hddmath2[3] > 2000 && PC1hddmath2[3] <= 2500)
                                {
                                    PCCalculation2 = 55000;
                                }

                                if (PC1hddmath2[3] > 2500 && PC1hddmath2[3] <= 3000)
                                {
                                    PCCalculation2 = 50000;
                                }

                                if (PC1hddmath2[3] > 3000 && PC1hddmath2[3] <= 3500)
                                {
                                    PCCalculation2 = 45000;
                                }

                                if (PC1hddmath2[3] > 3500 && PC1hddmath2[3] <= 4000)
                                {
                                    PCCalculation2 = 40000;
                                }

                                if (PC1hddmath2[3] > 4000)
                                {
                                    PCCalculation2 = 30000;
                                }

                                hdd2lifepercent = Math.Round((PC1hddmath2[2] / PCCalculation2) * 100);

                                if (hdd2lifepercent <= 40)
                                {
                                    home1.HDD2lifechart.ProgressColor = Color.Chartreuse;
                                    home1.HDD2lifechart.ForeColor = Color.Chartreuse;
                                }

                                if (hdd2lifepercent > 40 && hdd2lifepercent < 80)
                                {
                                    home1.HDD2lifechart.ProgressColor = Color.DarkOrange;
                                    home1.HDD2lifechart.ForeColor = Color.DarkOrange;
                                }

                                if (hdd2lifepercent >= 80)
                                {
                                    home1.HDD2lifechart.ProgressColor = Color.OrangeRed;
                                    home1.HDD2lifechart.ForeColor = Color.OrangeRed;
                                }

                                home1.HDD2lifechart.Maximum = PCCalculation2;
                                home1.HDD2lifechart.Value = Convert.ToInt32(PC1hddmath2[2]);

                                home1.HDD2lifechart.Text = Convert.ToInt32(hdd2lifepercent).ToString() + "%";

                                if (PC1hddcount >= 3)
                                {
                                    double hdd3lifepercent = 0;

                                    home1.HDD3lifechart.Visible = true;

                                    int PCCalculation3 = 0;


                                    if (PC1hddmath2[5] <= 500)
                                    {
                                        PCCalculation3 = 80000;
                                    }

                                    if (PC1hddmath2[5] > 500 && PC1hddmath2[5] <= 1000)
                                    {
                                        PCCalculation3 = 70000;
                                    }

                                    if (PC1hddmath2[5] > 1000 && PC1hddmath2[5] <= 1500)
                                    {
                                        PCCalculation3 = 65000;
                                    }

                                    if (PC1hddmath2[5] > 1500 && PC1hddmath2[5] <= 2000)
                                    {
                                        PCCalculation3 = 60000;
                                    }

                                    if (PC1hddmath2[5] > 2000 && PC1hddmath2[5] <= 2500)
                                    {
                                        PCCalculation3 = 55000;
                                    }

                                    if (PC1hddmath2[5] > 2500 && PC1hddmath2[5] <= 3000)
                                    {
                                        PCCalculation3 = 50000;
                                    }

                                    if (PC1hddmath2[5] > 3000 && PC1hddmath2[5] <= 3500)
                                    {
                                        PCCalculation3 = 45000;
                                    }

                                    if (PC1hddmath2[5] > 3500 && PC1hddmath2[5] <= 4000)
                                    {
                                        PCCalculation3 = 40000;
                                    }

                                    if (PC1hddmath2[5] > 4000)
                                    {
                                        PCCalculation3 = 30000;
                                    }

                                    hdd3lifepercent = Math.Round((PC1hddmath2[4] / PCCalculation3) * 100);

                                    if (hdd3lifepercent <= 40)
                                    {
                                        home1.HDD3lifechart.ProgressColor = Color.Chartreuse;
                                        home1.HDD3lifechart.ForeColor = Color.Chartreuse;
                                    }

                                    if (hdd3lifepercent > 40 && hdd3lifepercent < 80)
                                    {
                                        home1.HDD3lifechart.ProgressColor = Color.DarkOrange;
                                        home1.HDD3lifechart.ForeColor = Color.DarkOrange;
                                    }

                                    if (hdd3lifepercent >= 80)
                                    {
                                        home1.HDD3lifechart.ProgressColor = Color.OrangeRed;
                                        home1.HDD3lifechart.ForeColor = Color.OrangeRed;
                                    }

                                    home1.HDD3lifechart.Maximum = PCCalculation3;
                                    home1.HDD3lifechart.Value = Convert.ToInt32(PC1hddmath2[4]);

                                    home1.HDD3lifechart.Text = Convert.ToInt32(hdd3lifepercent).ToString() + "%";




                                }

                            }

                        }


                        #endregion

                    });



                    #endregion


                    #endregion

                    #region NetWork

                    #region PING

                    this.home1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        int pingn = 0;

                        if (int.TryParse(PC1[26], out pingn) == false)
                        {

                        }
                        else
                        {
                            pingn = Convert.ToInt32(PC1[26]);
                        }
                       

                        if(pingn <= 180)
                        {

                            home1.pingt.ForeColor = Color.Chartreuse;
                            home1.pingi.Image = pgreen;
                            pc1pt.ForeColor = Color.Chartreuse;
                            pc1p.Image = pgreen;
                        }

                        if (pingn > 180 &&  pingn < 500)
                        {
                            home1.pingt.ForeColor = Color.Yellow;
                            home1.pingi.Image = pyellow;
                            pc1pt.ForeColor = Color.Yellow;
                            pc1p.Image = pyellow;
                        }

                        if (pingn >=500)
                        {
                            home1.pingt.ForeColor = Color.Crimson;
                            home1.pingi.Image = pred;
                            pc1pt.ForeColor = Color.Crimson;
                            pc1p.Image = pred;
                        }


                        home1.pingt.Text = PC1[26] + "MS";
                        pc1pt.Text = PC1[26] + "MS";


                    });

                    #endregion

                    #region NetWorkSpeed



                    double download = 0;
                    double upload = 0;
                    upload = up;
                    download = down;



                    this.home1.BeginInvoke((MethodInvoker)delegate ()
                    {

                        if (download > maxd)
                        {
                            maxd = download;
                        }
                        double downloadfinal = 0;


                        downloadfinal = Math.Round((download / maxd) * 100);

                        if (downloadfinal >= 0 && downloadfinal <= 100)
                        {
                            home1.downloadchart.Value = Convert.ToInt32(downloadfinal);
                        }
                        else
                        {
                            home1.downloadchart.Value = 0;
                        }

                        if (upload > maxup)
                        {
                            maxup = upload;
                        }
                        double uploadfinal = 0;
                        uploadfinal = Math.Round((upload / maxup) * 100);

                        if (uploadfinal >= 0 && uploadfinal <= 100)
                        {
                            home1.uploadchart.Value = Convert.ToInt32(uploadfinal);
                        }
                        else
                        {
                            home1.uploadchart.Value = 0;

                        }

                        home1.downloadchart.Text = downloadfinal.ToString() + "%" + "\n" + PC1[24];

                        if (PC1[24].ToLower().Contains("mbs"))
                        {
                            home1.downloadchart.SubscriptText = "Max:" + (maxd / 1000).ToString() + "Mbs";
                        }
                        else
                        {
                            if (home1.downloadchart.SubscriptText.ToLower().Contains("kbps"))
                            {
                                home1.downloadchart.SubscriptText = "Max:" + maxd.ToString() + "Kbps";
                            }
                        }

                        if (PC1[25].ToLower().Contains("mbs"))
                        {
                            home1.uploadchart.SubscriptText = "Max:" + (maxup / 1000).ToString() + "Mbs";
                        }
                        else
                        {
                            if (home1.uploadchart.SubscriptText.ToLower().Contains("kbps"))
                            {
                                home1.uploadchart.SubscriptText = "Max:" + maxup.ToString() + "Kbps";
                            }
                        }
                        home1.uploadchart.Text = uploadfinal.ToString() + "%" + "\n" + PC1[25];

                    });
                    #endregion

                    #endregion

                }
                catch (SystemException exception)
                {
                    DateTime dateTime = DateTime.UtcNow.Date;
                    string data = dateTime.ToString("dd/MM/yyyy");
                    string text = "";
                    StreamReader Reader = new StreamReader(Application.StartupPath + "//" + "log.txt");
                    text = Reader.ReadToEnd();
                    Reader.Close();


                    ConsolePC1.content = true;
                    StreamWriter writer = new StreamWriter(Application.StartupPath + "//" + "log.txt");
                    writer.WriteLine(text + "\n");
                    writer.WriteLine("[" + data + "] " + exception.ToString());
                    writer.Close();
                }
            }
            else
            {
                PC1offcounter++;

                if (PC1offcounter >= 50)
                {
                    this.home1.BeginInvoke((MethodInvoker)delegate ()
                    {

                        home1.pconoff.Text = "OFF-LINE";
                        home1.pconoff.ForeColor = Color.Crimson;

                    });

                    PC1init = true;
                }

            }
            await Task.Delay(100);
            

        }
        #endregion
    }
}
