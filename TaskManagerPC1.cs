using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WMinfo_Front
{
    public partial class TaskManagerPC1 : Form
    {
        public TaskManagerPC1()
        {
            InitializeComponent();
            Home.open1 = true;
            open = true;
            Task.Run(() => doworkAsync());
            loadprograms();
        }
        bool open;

        bool firstimegrid = true;
        async void doworkAsync()
        {
            while (open == true)
            {
                
                Thread.Sleep(50);
                ListenerPC1.SetResponse("TaskView");
                await Task.Run(() => TaskViewListenerPC1.StartListenAsync());
                string[] split = TaskViewListenerPC1.consoletext.Split('\n');
                //string[] split2 = TaskViewListenerPC1.networktext.Split('$');

                if (TaskViewListenerPC1.ok == true)
                {
                    string[] finalsplit;
                    int count = 0;
                    string contentfiltered ="";
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        foreach(string lines in split)
                        {
                            if(lines != " "&& lines != string.Empty && lines != null)
                            {
                                try
                                {
                                    string[] lastsplit = lines.Split(' ');
                                    for(int i=0; i<lastsplit.Length;i++)
                                    {
                                        if(lastsplit[i]!= " " && lastsplit[i] != "" && lastsplit[i] != string.Empty && lastsplit[i] != null)
                                        {
                                            contentfiltered += lastsplit[i] + "&";
                                        }

                                    }
                                   
                                    finalsplit = contentfiltered.Split('&');
                                    
                                    if (firstimegrid == true)
                                    {
                                        firstimegrid = false;
                                        while(count < 300)
                                        {
                                            dataGridView1.Rows.Add();
                                            count++;
                                        }
                                        count = 0;
                                    }

                                    /*string netinfo = "";

                                    for (int l = 0; l < split2.Length; l++)
                                    {
                                        string[] splitnet = split2[l].Split('&');
                                        if(splitnet[0].Contains(finalsplit[1]))
                                        {
                                            netinfo = splitnet[1].Replace("-",".") + "MB/s";
                                            break;
                                        }

                                    }*/

                                    dataGridView1.Rows[count].SetValues(count,finalsplit[0], finalsplit[1],finalsplit[2],finalsplit[3], finalsplit[4]);
                                    contentfiltered = "";
                                    count++;
                                }
                                catch(SystemException e)
                                { }

                               
                            }

                            
                        }
                        
                    });
                    TaskViewListenerPC1.ok = false;
                    TaskViewListenerPC1.consoletext = "";
                    TaskViewListenerPC1.networktext = "";
                    TaskViewListenerPC1.received = "";
                    Thread.Sleep(1000);
                }
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void TaskManagerPC1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListenerPC1.SetResponse("Accept");
            Home.pcform1.Dispose();
            Home.pcform1 = null;
            Home.openform1 = false;
            open = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".exe"))
            {
                TaskViewListenerPC1.responsetng = "kill&" + textBox1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string run = "";
            run = runprogram(comboBox1.SelectedItem.ToString());

            TaskViewListenerPC1.responsetng = "run*" + run;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(sidepanel.Width == 193)
            {
                sidepanel.Width = 0;
            }
            else
            {
                sidepanel.Width = 193;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox4.Hide();
            }
            else
            {
                textBox4.Show();
            }

        }

        ArrayList items = new ArrayList();

        #region RUNPROGRAM Method
        string runprogram(string program)
        {
            string content = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            content = reader.ReadLine();
            reader.Close();

            if (content != "" && content != " " && content != String.Empty)
            {
                string[] split = content.Split('#');

                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Contains(program))
                    {
                        string[] splitfinal = split[i].Split('&');
                        content = "";
                        content = splitfinal[1];
                        break;

                    }
                }

            }

            return content;
        }
        #endregion

        #region LOADPROGRAM Method
        void loadprograms()
        {
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
            string content = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            content = reader.ReadLine();
            reader.Close();
            items.Clear();
            if (content != "" && content != " " && content != String.Empty)
            {
                string[] split = content.Split('#');

                for(int i =0; i<split.Length;i++)
                {
                    string[]splitfinal = split[i].Split('&');
                    items.Add(splitfinal[0]);
                }
                comboBox1.DataSource = items;
                comboBox2.DataSource = items;
            }
        }
        #endregion

        #region READPROGRAM Method
        void readprograms(string program)
        {
            
            string content = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            content = reader.ReadLine();
            reader.Close();

            if (content != "" && content != " " && content != String.Empty)
            {
                string[] split = content.Split('#');

                for (int i = 0; i < split.Length; i++)
                {
                    if(split[i].Contains(program))
                    {
                        string[] splitfinal = split[i].Split('&');

                        textBox2.Enabled = true;
                        textBox2.Text = splitfinal[0];
                        textBox3.Enabled = true;
                        textBox3.Text = splitfinal[1];
                        break;

                    }
                }
               
            }

        }
        #endregion

        #region SAVEPROGRAM Method
        void saveprograms(string save)
        {
            string content = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            content = reader.ReadLine();
            reader.Close();

            StreamWriter Writer = new StreamWriter(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            Writer.WriteLine(content + save);
            Writer.Close();
        }
        #endregion

        #region EDIT Method
        private void button5_Click(object sender, EventArgs e)
        {
            string content = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
            content = reader.ReadLine();
            reader.Close();

            if (content != "" && content != " " && content != String.Empty)
            {
                string[] split = content.Split('#');

                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Contains(textBox2.Text))
                    {
                        split[i] = textBox2.Text +"&"+ textBox3.Text;
                        break;
                    }
                }
                content = "";

                foreach(string item in split)
                {
                    content += item + "#";
                }

                StreamWriter Writer = new StreamWriter(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
                Writer.WriteLine(content);
                Writer.Close();

            }
            loadprograms();
        }
        #endregion

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.DataSource != null)
            {
                string text = null;
                text = comboBox2.SelectedItem.ToString();
                if (text != null)
                {
                    readprograms(text);
                }
            }
        }

        #region Save Method
        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                string name = "";
                string adress = "";
                string tobesaved = "";
                name = textBox5.Text;
                adress = "@" + textBox4.Text;
                tobesaved = name + "&" + adress + "#";
                saveprograms(tobesaved);
                Task.Run(() => MessageBox.Show("Saved!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));
            }
            else
            {
                string name = "";
                string adress = "";
                string tobesaved = "";
                name = textBox5.Text;
                adress = name + ".exe";
                tobesaved = name + "&" + adress + "#";
                saveprograms(tobesaved);
                Task.Run(() => MessageBox.Show("Saved!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation));
            }
            loadprograms();

        }
        #endregion

        #region DELETEPROGRAM Method
        void deleteprogram()
        {
            if (MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string content = "";
                StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
                content = reader.ReadLine();
                reader.Close();

                if (content != "" && content != " " && content != String.Empty)
                {
                    string[] split = content.Split('#');

                    for (int i = 0; i < split.Length; i++)
                    {

                        if (split[i].Contains(textBox2.Text))
                        {
                            split[i] = "";
                            break;
                        }
                    }
                    content = "";

                    foreach (string item in split)
                    {
                        
                        if (item != null && item != "" && item != " " && item != string.Empty)
                        {
                            content += item + "#";
                        }
                        
                    }

                    StreamWriter Writer = new StreamWriter(Application.StartupPath + @"\Data\Colections\Programs\CB.cfg");
                    Writer.WriteLine(content);
                    Writer.Close();
                }
            }
            else
            {

            }
        }
        #endregion

        #region Delete Method
        private void button7_Click(object sender, EventArgs e)
        {
            Task.Run(() => deleteprogram());
            loadprograms();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.DataSource != null)
            {
                string text = null;
                text = comboBox2.SelectedItem.ToString();
                if (text != null)
                {
                    readprograms(text);
                }
            }
        }
    }
}
