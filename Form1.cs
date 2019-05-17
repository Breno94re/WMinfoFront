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
using System.Collections;

namespace WMinfo_Front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThreadListenerPC1();
            T1();
            intelImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "cross final.png");
            amdImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "cross final.png");
            kekImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "cross final.png");
            popImage = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "test.gif");
            pgreen = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pgreen.png");
            pred = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pRed.png");
            pyellow = Image.FromFile(Application.StartupPath + "\\" + "Data" + "\\" + "Icons" + "\\" + "pYellow.png");
            statsChart1.monthCalendar2.DateSelected += Getdate;
            statsChart1.comboBox1.SelectedIndexChanged += Getinstance;
            statsChart1.button2.Click += SetDailyMode;
            statsChart1.button1.Click += SetRTMode;
            statsChart1.button3.Click += SetDateMode;

        }
        Image intelImage;
        Image amdImage;
        Image kekImage;
        Image popImage;
        Image pgreen;
        Image pred;
        Image pyellow;
        public static bool cmdinit = true;

        void SetDateMode(object sender, EventArgs e)
        {
            this.cpudaily = false;
            this.cpudate = true;
            this.cpurealtime = false;
        }

        void SetRTMode(object sender, EventArgs e)
        {
            this.cpudaily = false;
            this.cpudate = false;
            this.cpurealtime = true;
        }

        void SetDailyMode(object sender, EventArgs e)
        {
            this.cpudaily = true;
            this.cpudate = false;
            this.cpurealtime = false;
        }

        void Getinstance(object sender, EventArgs e)
        {
            if (statsChart1.comboBox1.SelectedItem.ToString().ToLower() == "temperature")
            {
                this.cputemp = true;
                this.cpuload = false;
                cpuinit = true;
            }

            if (statsChart1.comboBox1.SelectedItem.ToString().ToLower() == "load")
            {
                this.cputemp = false;
                this.cpuload = true;
                cpuinit = true;
            }

        }

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
            hname1.Text = "\nHost-Name: Desk9isPC" + "\n\nApiKey: " + "#" + apikey();
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



        void T1()
        {
            Thread att = new Thread(new ThreadStart(WorkPC1Async));
            att.IsBackground = true;
            att.Start();
        }

        public async void WorkPC1Async()
        {
            await Task.Run(UpdatePC1MethodAsync);
        }

        #region PC1 Method's

        static double maxd = 0;
        static double maxup = 0;
        public int PC1offcounter = 0;

        async Task UpdatePC1MethodAsync()
        {
            
            bool firstimecpu = true;
            bool firstimehdd = true;
            bool Online = false;
            bool initial = true;

            while (true)
            {
                Online = ListenerPC1.GetStatus();
                ListenerPC1.ResetStatus();
                if (Online == true)
                {
                    if(initial == true)
                    {
                        initial = false;
                        Task.Run(() => UpdatePC1CPUChart());
                        Task.Run(() => UpdatePCFiles());
                    }
                    Online = false;

                    try
                    {
                        PC1offcounter = 0;

                        this.home1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.pconoff.Text = "ON-LINE";
                            home1.pconoff.ForeColor = Color.Chartreuse;
                        });

                        #region BASIC INFO
                        string mobonbs = "";
                        mobonbs = ListenerPC1.GetMOBOInfo();
                        string[] mobonbasic = mobonbs.Split('/');
                        string ips = "";
                        ips = ListenerPC1.GetIPInfo();
                        this.home1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            try
                            {
                                home1.hname1.Text = "Host-Name:" + mobonbasic[4] + "\n\nAPI-KEY:#78hjgd6H8" + "\n\n" + ips;
                            }
                            catch
                            {

                            }
                        });


                        #endregion

                        #region CPU

                        #region GetCpuInfo()
                        string cpuinfo = ListenerPC1.GetCPUInfo();
                        string[] splitcpuinfo = cpuinfo.Split('/');

                        string cpuname = splitcpuinfo[0];
                        string cpucores = splitcpuinfo[1];
                        string cpuclock = splitcpuinfo[2];
                        string cputemp = splitcpuinfo[3];
                        string cpuload = splitcpuinfo[4];
                        #endregion

                        #region Filter info

                        #region clock
                        string[] clocksplit = cpuclock.Split('&');

                        #endregion

                        #region temp
                        string[] tempsplit = cputemp.Split('&');
                        int temppack = 0;
                        #endregion

                        #region load
                        string[] loadsplit = cpuload.Split('&');
                        int loadpack = 0;
                        #endregion

                        #endregion

                        #region Brand and Model's

                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            if (cpuname.ToLower().Contains("i5") || cpuname.ToLower().Contains("atom") || cpuname.ToLower().Contains("i3"))
                            {
                                home1.pname.Text = cpuname + "\n\nCores: " + cpucores.ToString();
                            }

                        });

                        #endregion

                        #region Tree View
                        this.home1.CPUP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            ProgressBar pb = new ProgressBar();

                            try
                            {

                                if (firstimecpu == true)
                                {
                                    int row = clocksplit.Length;
                                    home1.CPUTV.Nodes.Add("CPU");
                                    home1.CPUTV.Nodes[0].Nodes.Add("Clock");
                                    home1.CPUTV.Nodes[0].Nodes.Add("Temperatures");
                                    home1.CPUTV.Nodes[0].Nodes.Add("Load");
                                    for (int i = 0; i < clocksplit.Length - 1; i++)
                                    {
                                        home1.CPUTV.Nodes[0].Nodes[0].Nodes.Add("");
                                        home1.CPUTV.Nodes[0].Nodes[1].Nodes.Add("");
                                        home1.CPUTV.Nodes[0].Nodes[2].Nodes.Add("");
                                    }
                                    firstimecpu = false;
                                }


                            }
                            catch
                            {

                            }

                            #region Clock
                            for (int i = 0; i < clocksplit.Length; i++)
                            {
                                if (i == clocksplit.Length - 2)
                                {
                                    if (clocksplit[i] != "" && clocksplit[i] != String.Empty && clocksplit[i] != null)
                                    {
                                        home1.CPUTV.Nodes[0].Nodes[0].Nodes[i].Text = "BUS " + clocksplit[i] + "Mhz";
                                    }
                                }
                                else
                                {
                                    if (clocksplit[i] != "" && clocksplit[i] != String.Empty && clocksplit[i] != null)
                                    {
                                        home1.CPUTV.Nodes[0].Nodes[0].Nodes[i].Text = "Clock#" + i.ToString() + " " + clocksplit[i] + "Mhz";//clock

                                    }
                                }

                            }
                            #endregion

                            #region Temperature

                            int tempcount = 0;
                            int temps = 0;
                            bool problematic = false;
                            try
                            {
                                for (int i = 0; i < tempsplit.Length; i++)
                                {

                                    if (cpuname.ToLower().Contains("atom 330"))
                                        problematic = true;

                                    if (problematic == true)
                                    {
                                        if (i == tempsplit.Length - 1)
                                        {
                                            temppack = temps / tempcount;
                                            this.charcputemp = temppack;
                                            home1.CPUTV.Nodes[0].Nodes[1].Nodes[i].Text = "Package " + (temps / tempcount).ToString() + "ºC";

                                        }
                                        else
                                        {
                                            if (tempsplit[i] != "" && tempsplit[i] != String.Empty && tempsplit[i] != null)
                                            {
                                                temps += Convert.ToInt32(tempsplit[i]);
                                                tempcount++;
                                                home1.CPUTV.Nodes[0].Nodes[1].Nodes[i].Text = "Core#" + i.ToString() + " " + tempsplit[i] + "ºC";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (i == tempsplit.Length - 2)
                                        {
                                            if (tempsplit[i] != "" && tempsplit[i] != String.Empty && tempsplit[i] != null)
                                            {
                                                temppack = temps / tempcount;
                                                this.charcputemp = temppack;
                                                home1.CPUTV.Nodes[0].Nodes[1].Nodes[i].Text = "Package " + (temps / tempcount).ToString() + "ºC";
                                            }
                                        }
                                        else
                                        {
                                            if (tempsplit[i] != "" && tempsplit[i] != String.Empty && tempsplit[i] != null)
                                            {
                                                temps += Convert.ToInt32(tempsplit[i]);
                                                tempcount++;
                                                home1.CPUTV.Nodes[0].Nodes[1].Nodes[i].Text = "Core#" + i.ToString() + " " + tempsplit[i] + "ºC";
                                            }
                                        }
                                    }



                                }
                            }
                            catch
                            {

                            }
                            #endregion

                            #region Load
                            int loadcount = 0;
                            int loads = 0;
                            try
                            {
                                for (int i = 0; i < loadsplit.Length; i++)
                                {
                                    if (i == loadsplit.Length - 2)
                                    {

                                        if (loadsplit[i] != "" && loadsplit[i] != String.Empty && loadsplit[i] != null)
                                        {
                                            loadpack = loads / loadcount;
                                            this.charcpuload = loadpack;
                                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[i].Text = "Package " + loadpack.ToString() + "%";
                                        }
                                    }
                                    else
                                    {
                                        if (loadsplit[i] != "" && loadsplit[i] != String.Empty && loadsplit[i] != null)
                                        {
                                            loads += Convert.ToInt32(loadsplit[i]);
                                            loadcount++;
                                            home1.CPUTV.Nodes[0].Nodes[2].Nodes[i].Text = "Core#" + i.ToString() + " " + loadsplit[i] + "%";
                                        }


                                    }

                                }
                            }
                            catch
                            {

                            }
                            #endregion

                        });
                        #endregion

                        #region Charts




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

                        #endregion

                        #region GPU

                        string gpuinfo = "";
                        gpuinfo = ListenerPC1.GetGPUInfo();
                        string[] gpusplit = gpuinfo.Split('/');
                        bool vganotdetected = false;
                        if (gpusplit[gpusplit.Length - 1] == "true")
                        {
                            vganotdetected = true;
                        }
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
                            home1.gname.Text = gpusplit[0];
                        });

                        #endregion

                        #region TreeView
                        this.home1.GPUP.BeginInvoke((MethodInvoker)delegate ()
                        {

                            home1.GPUTV.Nodes[0].Nodes[0].Nodes[0].Text = gpusplit[1];//Core Clock
                            home1.GPUTV.Nodes[0].Nodes[0].Nodes[1].Text = gpusplit[2];//Shader Clock
                            home1.GPUTV.Nodes[0].Nodes[0].Nodes[2].Text = gpusplit[3];//Memory Clock

                            home1.GPUTV.Nodes[0].Nodes[1].Nodes[0].Text = "Core Temperature " + gpusplit[4] + "ºC";//Core Temp

                            home1.GPUTV.Nodes[0].Nodes[2].Nodes[0].Text = "Core Load " + gpusplit[5] + "%";//Core Load
                            home1.GPUTV.Nodes[0].Nodes[2].Nodes[1].Text = gpusplit[6];//Memory Load

                            home1.GPUTV.Nodes[0].Nodes[3].Nodes[0].Text = gpusplit[7];//FanSpeed


                        });
                        #endregion

                        #region GPU Charts

                        int loadpack1 = 0;
                        int temppack1 = 0;

                        loadpack1 = Convert.ToInt32(gpusplit[5]);
                        temppack1 = Convert.ToInt32(gpusplit[4]);



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

                        #region GetRamInfo()
                        string raminfo = ListenerPC1.GetRAMinfo();
                        string[] splitraminfo = raminfo.Split('/');

                        string ramtotal = splitraminfo[0];
                        string ramavailabe = splitraminfo[1];
                        string usefinal = splitraminfo[2];
                        string totalfinal = splitraminfo[3];
                        double Raminuse = Convert.ToInt32(splitraminfo[4]);
                        #endregion

                        #region TreeView

                        this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.RAMTV.Nodes[0].Nodes[0].Text = "Total Ram: " + ramtotal;//total
                            home1.RAMTV.Nodes[0].Nodes[1].Text = "Free Ram: " + ramavailabe;//free
                        });

                        #endregion

                        #region Ram Charts


                        this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.Ramchart.Text = "RAM\n" + Raminuse.ToString() + "%" + "\n" + usefinal + "/" + totalfinal + "GBs";
                            home1.Ramchart.Value = Convert.ToInt32(Raminuse);

                            if (Raminuse <= 40)
                            {
                                home1.Ramchart.ProgressColor = Color.Chartreuse;
                                home1.Ramchart.ForeColor = Color.Chartreuse;
                            }

                            if (Raminuse > 40 && Raminuse < 80)
                            {
                                home1.Ramchart.ProgressColor = Color.DarkOrange;
                                home1.Ramchart.ForeColor = Color.DarkOrange;
                            }
                            if (Raminuse >= 80)
                            {
                                home1.Ramchart.ProgressColor = Color.OrangeRed;
                                home1.Ramchart.ForeColor = Color.OrangeRed;
                            }

                        });
                        #endregion

                        #endregion

                        #region MOBO

                        #region MOBO TEXT

                        this.home1.RAMP.BeginInvoke((MethodInvoker)delegate ()
                        {
                            home1.moboname.Text = "Manufacturer: " + mobonbasic[0] + "\nModel: " + mobonbasic[1] + "\nSerial Number: " + mobonbasic[2] + "\nVersion: " + mobonbasic[3];
                        });

                        #endregion

                        #endregion

                        #region HDD's

                        #region GetHddInfo()
                        string hddinfo = ListenerPC1.GetHDDinfo();
                        string[] splithddinfo = hddinfo.Split('/');
                        int hddcount = Convert.ToInt32(splithddinfo[3]);//hddcount
                        string[] splithdddata = splithddinfo[0].Split('&'); //infos
                        string[] splithdddata1 = splithddinfo[1].Split('&'); //hddmath1
                        string[] splithdddata2 = splithddinfo[2].Split('&'); //hddmath2

                        double[] hddmath1 = new double[10];

                        for (int i = 0; i < splithdddata1.Length; i++)
                        {
                            hddmath1[i] = Convert.ToDouble(splithdddata1[i]);
                        }

                        double[] hddmath2 = new double[10];

                        for (int i = 0; i < splithdddata2.Length; i++)
                        {
                            hddmath2[i] = Convert.ToDouble(splithdddata2[i]);
                        }

                        #endregion

                        #region Tree View

                        this.home1.HDDP.BeginInvoke((MethodInvoker)delegate ()
                        {

                            if (firstimehdd == true)
                            {
                                if (hddcount >= 1)
                                {
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

                                    if (hddcount >= 2)
                                    {
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

                                    }

                                    if (hddcount >= 3)
                                    {
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

                                    }

                                }

                                firstimehdd = false;
                            }

                            if (hddcount >= 1)
                            {
                                home1.hddt.Text = "HDD1 " + splithdddata[0];
                                home1.HDDTV.Nodes[0].Text = splithdddata[0];
                                home1.HDDTV.Nodes[0].Nodes[0].Text = splithdddata[1];
                                home1.HDDTV.Nodes[0].Nodes[1].Text = splithdddata[2];
                                home1.HDDTV.Nodes[0].Nodes[2].Text = "Storage";
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes[0].Text = splithdddata[3];
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes[1].Text = splithdddata[4];
                                home1.HDDTV.Nodes[0].Nodes[2].Nodes[2].Text = splithdddata[5];
                                home1.HDDTV.Nodes[0].Nodes[3].Text = "Temperatures";
                                home1.HDDTV.Nodes[0].Nodes[3].Nodes[0].Text = splithdddata[6];
                                home1.HDDTV.Nodes[0].Nodes[3].Nodes[1].Text = splithdddata[7];
                                home1.HDDTV.Nodes[0].Nodes[4].Text = splithdddata[8];
                                home1.HDDTV.Nodes[0].Nodes[5].Text = splithdddata[9];

                                if (hddcount >= 2)
                                {
                                    home1.hddt.Text = "HDD1 " + splithdddata[0] + "\n\nHDD2 " + splithdddata[10];
                                    home1.HDDTV.Nodes[1].Text = splithdddata[10];
                                    home1.HDDTV.Nodes[1].Nodes[0].Text = splithdddata[11];
                                    home1.HDDTV.Nodes[1].Nodes[1].Text = splithdddata[12];
                                    home1.HDDTV.Nodes[1].Nodes[2].Text = "Storage";
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes[0].Text = splithdddata[13];
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes[1].Text = splithdddata[14];
                                    home1.HDDTV.Nodes[1].Nodes[2].Nodes[2].Text = splithdddata[15];
                                    home1.HDDTV.Nodes[1].Nodes[3].Text = "Temperatures";
                                    home1.HDDTV.Nodes[1].Nodes[3].Nodes[0].Text = splithdddata[16];
                                    home1.HDDTV.Nodes[1].Nodes[3].Nodes[1].Text = splithdddata[17];
                                    home1.HDDTV.Nodes[1].Nodes[4].Text = splithdddata[18];
                                    home1.HDDTV.Nodes[1].Nodes[5].Text = splithdddata[19];

                                    if (hddcount >= 3)
                                    {
                                        home1.hddt.Text = "HDD1 " + splithdddata[0] + "\n\nHDD2 " + splithdddata[10] + "\n\nHDD3 " + splithdddata[20];
                                        home1.HDDTV.Nodes[2].Text = splithdddata[20];
                                        home1.HDDTV.Nodes[2].Nodes[0].Text = splithdddata[21];
                                        home1.HDDTV.Nodes[2].Nodes[1].Text = splithdddata[22];
                                        home1.HDDTV.Nodes[2].Nodes[2].Text = "Storage";
                                        home1.HDDTV.Nodes[2].Nodes[2].Nodes[0].Text = splithdddata[23];
                                        home1.HDDTV.Nodes[2].Nodes[2].Nodes[1].Text = splithdddata[24];
                                        home1.HDDTV.Nodes[2].Nodes[2].Nodes[2].Text = splithdddata[25];
                                        home1.HDDTV.Nodes[2].Nodes[3].Text = "Temperatures";
                                        home1.HDDTV.Nodes[2].Nodes[3].Nodes[0].Text = splithdddata[26];
                                        home1.HDDTV.Nodes[2].Nodes[3].Nodes[1].Text = splithdddata[27];
                                        home1.HDDTV.Nodes[2].Nodes[4].Text = splithdddata[28];
                                        home1.HDDTV.Nodes[2].Nodes[5].Text = splithdddata[29];

                                    }
                                }
                            }

                        });
                        #endregion

                        #region HDD's Chart

                        this.home1.HDDP.BeginInvoke((MethodInvoker)delegate ()
                        {

                            #region Storage Chart

                            if (hddcount >= 1)
                            {
                                home1.HDD1storagechart.Visible = true;
                                double hdd1storagepercent = 0;


                                hdd1storagepercent = (hddmath1[1] / hddmath1[0] * 100);

                                if (hdd1storagepercent <= 40)
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


                                home1.HDD1storagechart.Maximum = Convert.ToInt32(hddmath1[0]);
                                home1.HDD1storagechart.Value = Convert.ToInt32(hddmath1[1]);
                                home1.HDD1storagechart.Text = Convert.ToInt32(hdd1storagepercent).ToString() + "%";


                                if (hddcount >= 2)
                                {
                                    double hdd2storagepercent = 0;

                                    home1.HDD2storagechart.Visible = true;

                                    hdd2storagepercent = (hddmath1[3] / hddmath1[2] * 100);

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


                                    home1.HDD2storagechart.Maximum = Convert.ToInt32(hddmath1[2]);
                                    home1.HDD2storagechart.Value = Convert.ToInt32(hddmath1[3]);
                                    home1.HDD2storagechart.Text = Convert.ToInt32(hdd2storagepercent).ToString() + "%";

                                    if (hddcount >= 3)
                                    {
                                        double hdd3storagepercent = 0;

                                        home1.HDD3storagechart.Visible = true;

                                        hdd3storagepercent = (hddmath1[5] / hddmath1[4] * 100);

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


                                        home1.HDD3storagechart.Maximum = Convert.ToInt32(hddmath1[4]);
                                        home1.HDD3storagechart.Value = Convert.ToInt32(hddmath1[5]);
                                        home1.HDD3storagechart.Text = Convert.ToInt32(hdd3storagepercent).ToString() + "%";

                                    }

                                }

                            }
                            #endregion

                            #region Life chart

                            if (hddcount >= 1)
                            {
                                double hdd1lifepercent = 0;

                                home1.HDD1lifechart.Visible = true;

                                int PCCalculation = 0;


                                if (hddmath2[1] <= 500)
                                {
                                    PCCalculation = 80000;
                                }

                                if (hddmath2[1] > 500 && hddmath2[1] <= 1000)
                                {
                                    PCCalculation = 70000;
                                }

                                if (hddmath2[1] > 1000 && hddmath2[1] <= 1500)
                                {
                                    PCCalculation = 65000;
                                }

                                if (hddmath2[1] > 1500 && hddmath2[1] <= 2000)
                                {
                                    PCCalculation = 60000;
                                }

                                if (hddmath2[1] > 2000 && hddmath2[1] <= 2500)
                                {
                                    PCCalculation = 55000;
                                }

                                if (hddmath2[1] > 2500 && hddmath2[1] <= 3000)
                                {
                                    PCCalculation = 50000;
                                }

                                if (hddmath2[1] > 3000 && hddmath2[1] <= 3500)
                                {
                                    PCCalculation = 45000;
                                }

                                if (hddmath2[1] > 3500 && hddmath2[1] <= 4000)
                                {
                                    PCCalculation = 40000;
                                }

                                if (hddmath2[1] > 4000)
                                {
                                    PCCalculation = 30000;
                                }

                                hdd1lifepercent = Math.Round((hddmath2[0] / PCCalculation) * 100);

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
                                home1.HDD1lifechart.Value = Convert.ToInt32(hddmath2[0]);

                                home1.HDD1lifechart.Text = Convert.ToInt32(hdd1lifepercent).ToString() + "%";



                                if (hddcount >= 2)
                                {

                                    double hdd2lifepercent = 0;

                                    home1.HDD2lifechart.Visible = true;

                                    int PCCalculation2 = 0;


                                    if (hddmath2[3] <= 500)
                                    {
                                        PCCalculation2 = 80000;
                                    }

                                    if (hddmath2[3] > 500 && hddmath2[3] <= 1000)
                                    {
                                        PCCalculation2 = 70000;
                                    }

                                    if (hddmath2[3] > 1000 && hddmath2[3] <= 1500)
                                    {
                                        PCCalculation2 = 65000;
                                    }

                                    if (hddmath2[3] > 1500 && hddmath2[3] <= 2000)
                                    {
                                        PCCalculation2 = 60000;
                                    }

                                    if (hddmath2[3] > 2000 && hddmath2[3] <= 2500)
                                    {
                                        PCCalculation2 = 55000;
                                    }

                                    if (hddmath2[3] > 2500 && hddmath2[3] <= 3000)
                                    {
                                        PCCalculation2 = 50000;
                                    }

                                    if (hddmath2[3] > 3000 && hddmath2[3] <= 3500)
                                    {
                                        PCCalculation2 = 45000;
                                    }

                                    if (hddmath2[3] > 3500 && hddmath2[3] <= 4000)
                                    {
                                        PCCalculation2 = 40000;
                                    }

                                    if (hddmath2[3] > 4000)
                                    {
                                        PCCalculation2 = 30000;
                                    }

                                    hdd2lifepercent = Math.Round((hddmath2[2] / PCCalculation2) * 100);

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
                                    home1.HDD2lifechart.Value = Convert.ToInt32(hddmath2[2]);

                                    home1.HDD2lifechart.Text = Convert.ToInt32(hdd2lifepercent).ToString() + "%";

                                    if (hddcount >= 3)
                                    {
                                        double hdd3lifepercent = 0;

                                        home1.HDD3lifechart.Visible = true;

                                        int PCCalculation3 = 0;


                                        if (hddmath2[5] <= 500)
                                        {
                                            PCCalculation3 = 80000;
                                        }

                                        if (hddmath2[5] > 500 && hddmath2[5] <= 1000)
                                        {
                                            PCCalculation3 = 70000;
                                        }

                                        if (hddmath2[5] > 1000 && hddmath2[5] <= 1500)
                                        {
                                            PCCalculation3 = 65000;
                                        }

                                        if (hddmath2[5] > 1500 && hddmath2[5] <= 2000)
                                        {
                                            PCCalculation3 = 60000;
                                        }

                                        if (hddmath2[5] > 2000 && hddmath2[5] <= 2500)
                                        {
                                            PCCalculation3 = 55000;
                                        }

                                        if (hddmath2[5] > 2500 && hddmath2[5] <= 3000)
                                        {
                                            PCCalculation3 = 50000;
                                        }

                                        if (hddmath2[5] > 3000 && hddmath2[5] <= 3500)
                                        {
                                            PCCalculation3 = 45000;
                                        }

                                        if (hddmath2[5] > 3500 && hddmath2[5] <= 4000)
                                        {
                                            PCCalculation3 = 40000;
                                        }

                                        if (hddmath2[5] > 4000)
                                        {
                                            PCCalculation3 = 30000;
                                        }

                                        hdd3lifepercent = Math.Round((hddmath2[4] / PCCalculation3) * 100);

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
                                        home1.HDD3lifechart.Value = Convert.ToInt32(hddmath2[4]);

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
                            string ping = "";
                            ping = ListenerPC1.GetPingInfo();
                            if (int.TryParse(ping, out pingn) == false)
                            {

                            }
                            else
                            {
                                pingn = Convert.ToInt32(ping);
                            }


                            if (pingn <= 180)
                            {

                                home1.pingt.ForeColor = Color.Chartreuse;
                                home1.pingi.Image = pgreen;
                                pc1pt.ForeColor = Color.Chartreuse;
                                pc1p.Image = pgreen;
                            }

                            if (pingn > 180 && pingn < 500)
                            {
                                home1.pingt.ForeColor = Color.Yellow;
                                home1.pingi.Image = pyellow;
                                pc1pt.ForeColor = Color.Yellow;
                                pc1p.Image = pyellow;
                            }

                            if (pingn >= 500)
                            {
                                home1.pingt.ForeColor = Color.Crimson;
                                home1.pingi.Image = pred;
                                pc1pt.ForeColor = Color.Crimson;
                                pc1p.Image = pred;
                            }


                            home1.pingt.Text = ping + "MS";
                            pc1pt.Text = ping + "MS";


                        });

                        #endregion

                        #region NetWorkSpeed

                        string networkinfo = "";
                        networkinfo = ListenerPC1.GetNetworkInfo();
                        string[] networkinfosplit = networkinfo.Split('/');
                        double down = 0;
                        double up = 0;
                        if (networkinfosplit[0] != String.Empty)
                        {
                            down = Convert.ToDouble(networkinfosplit[0]);
                            up = Convert.ToDouble(networkinfosplit[1]);
                        }
                        double download = 0;
                        double upload = 0;

                        upload = up;
                        download = down;

                        this.home1.BeginInvoke((MethodInvoker)delegate ()
                        {

                            if (download > maxd)
                            {
                                maxd = 0;
                                maxd = download;
                                if (maxd < 1000)
                                {
                                    home1.downloadchart.SubscriptText = "Max:" + Math.Round(maxd).ToString() + "Kbps";
                                }
                                else
                                {
                                    home1.downloadchart.SubscriptText = "Max:" + Math.Round((maxd / 1000), 2).ToString() + "Mbs";
                                }

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

                                if (maxup < 1000)
                                {
                                    home1.uploadchart.SubscriptText = "Max:" + Math.Round(maxup).ToString() + "Kbps";
                                }
                                else
                                {
                                    home1.uploadchart.SubscriptText = "Max:" + Math.Round((maxup / 1000), 2) + "Mbs";
                                }
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



                            if (down < 1000)
                            {

                                home1.downloadchart.Text = downloadfinal.ToString() + "%" + "\n" + Math.Round(down).ToString() + "Kbps";
                            }
                            else
                            {
                                home1.downloadchart.Text = downloadfinal.ToString() + "%" + "\n" + Math.Round(down / 1000, 2).ToString() + "Mbs";
                            }

                            if (up < 1000)
                            {

                                home1.uploadchart.Text = uploadfinal.ToString() + "%" + "\n" + Math.Round(up).ToString() + "Kbps";
                            }
                            else
                            {

                                home1.uploadchart.Text = uploadfinal.ToString() + "%" + "\n" + Math.Round(up / 1000, 2).ToString() + "Mbs";

                            }



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

                        firstimecpu = true;
                        firstimehdd = true;
                    }

                }
                await Task.Delay(200);
            }

        }
        #endregion

        #region PC1 Charts

        #region Variables
        private int charcputemp;
        private int charcputempmax;
        private int charcputempmin = 100;
        private int charcpuload;
        private int charcpuloadmax;
        private int charcpuloadmin = 100;
        private bool cpuload = false;
        private bool cputemp = true;
        private bool cpuinit = true;
        private bool cpurealtime = true;
        private bool cpudaily = false;
        private bool cpudate = false;
        private string date;
        private int[] dailycpuloadcount = new int[25];
        private int[] dailycputempcount = new int[25];

        #endregion

        Task UpdatePC1CPUChart()
        {
            Thread.Sleep(2000);
            ArrayList array = new ArrayList();
            ArrayList array1 = new ArrayList();

            #region Chart preset

            #endregion

            while (true)
            {

                #region CPU RealTime
                if (cpurealtime == true)
                {

                    #region Cpu Temp
                    if (this.cputemp == true)
                    {
                        if (cpuinit == true)
                        {
                            this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                            {
                                statsChart1.chart1.Series["Series1"].Points.Clear();
                                statsChart1.chart1.ChartAreas[0].AxisY.Minimum = 0;
                                statsChart1.chart1.ChartAreas[0].AxisY.Maximum = 110;
                                statsChart1.chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                                statsChart1.chart1.Legends["Legend1"].BackColor = Color.FromArgb(32, 34, 37);
                                statsChart1.chart1.Legends["Legend1"].ForeColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.Interval = 5;
                            });
                            cpuinit = false;
                        }

                        array.Add(this.charcputemp);
                        if (array.Count >= 60)
                        {
                            array.RemoveAt(0);
                        }
                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            if (this.charcputemp > this.charcputempmax)
                            {
                                this.charcputempmax = this.charcputemp;
                            }

                            if (this.charcputemp < this.charcputempmin && this.charcputemp > 0)
                            {
                                this.charcputempmin = this.charcputemp;
                            }

                            statsChart1.chart1.Series["Series1"].LegendText = "Max  " + this.charcputempmax.ToString() + "ºC" + "\nNow  " + this.charcputemp.ToString() + "ºC" + "\nMin   " + this.charcputempmin.ToString() + "ºC";

                            statsChart1.chart1.Series["Series1"].Points.Clear();
                            foreach (int k in array)
                            {
                                
                                statsChart1.chart1.Series["Series1"].Points.AddXY(k.ToString() + "ºC", k);
                            }

                        });
                    }
                    #endregion

                    #region CPU Load
                    if (this.cpuload == true)
                    {

                        if (cpuinit == true)
                        {
                            this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                            {
                                statsChart1.chart1.Series["Series1"].Points.Clear();
                                statsChart1.chart1.ChartAreas[0].AxisY.Minimum = 0;
                                statsChart1.chart1.ChartAreas[0].AxisY.Maximum = 100;
                                statsChart1.chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                                statsChart1.chart1.Legends["Legend1"].BackColor = Color.FromArgb(32, 34, 37);
                                statsChart1.chart1.Legends["Legend1"].ForeColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                                statsChart1.chart1.ChartAreas[0].AxisX.Interval = 5;
                            });
                            cpuinit = false;
                        }

                        array1.Add(this.charcpuload);
                        if (array1.Count >= 60)
                        {
                            array1.RemoveAt(0);
                        }
                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            if (this.charcpuload > this.charcpuloadmax)
                            {
                                this.charcpuloadmax = this.charcpuload;
                            }

                            if (this.charcpuload < this.charcpuloadmin && this.charcpuload > 0)
                            {
                                this.charcpuloadmin = this.charcpuload;
                            }

                           
                            statsChart1.chart1.Series["Series1"].LegendText = "Max  " + this.charcpuloadmax.ToString() + "%" + "\nNow  " + this.charcpuload.ToString() + "%" + "\nMin   " + this.charcpuloadmin.ToString() + "%";

                            statsChart1.chart1.Series["Series1"].Points.Clear();
                           
                            foreach (int k in array1)
                            {
                               statsChart1.chart1.Series["Series1"].Points.AddXY(k.ToString() + "%", k);
                                
                            }

                        });
                    }
                    #endregion

                    Thread.Sleep(500);
                }
                #endregion

                #region CPU Daily

                if (cpudaily == true)
                {

                    #region CPU temp

                    if (cputemp == true)
                    {
                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            statsChart1.chart1.Series["Series1"].Points.Clear();
                            statsChart1.chart1.ChartAreas[0].AxisY.Minimum = 0;
                            statsChart1.chart1.ChartAreas[0].AxisY.Maximum = 100;
                            statsChart1.chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                            statsChart1.chart1.Legends["Legend1"].BackColor = Color.FromArgb(32, 34, 37);
                            statsChart1.chart1.Legends["Legend1"].ForeColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.Interval = 1;
                        });


                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            statsChart1.chart1.Series["Series1"].LegendText = "Max  " + dailycputempcount.Max().ToString() + "%" + "\nMin   " + dailycputempcount.Min().ToString() + "%";

                            for (int i = 0; i < dailycputempcount.Length; i++)
                            {
                                int index = statsChart1.chart1.Series["Series1"].Points.AddXY(i.ToString() + "H", dailycputempcount[i]);
                                if(dailycputempcount[i]!=0)
                                {
                                    statsChart1.chart1.Series["Series1"].Points[index].Label = dailycputempcount[i].ToString();
                                }
                            }

                        });
                    }
                    #endregion

                    #region CPU Load
                    if (cpuload == true)
                    {

                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            statsChart1.chart1.Series["Series1"].Points.Clear();
                            statsChart1.chart1.ChartAreas[0].AxisY.Minimum = 0;
                            statsChart1.chart1.ChartAreas[0].AxisY.Maximum = 100;
                            statsChart1.chart1.ChartAreas[0].AxisX.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                            statsChart1.chart1.Legends["Legend1"].BackColor = Color.FromArgb(32, 34, 37);
                            statsChart1.chart1.Legends["Legend1"].ForeColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                            statsChart1.chart1.ChartAreas[0].AxisX.Interval = 1;
                        });


                        this.statsChart1.chart1.BeginInvoke((MethodInvoker)delegate ()
                        {
                            statsChart1.chart1.Series["Series1"].LegendText = "Max  " + dailycpuloadcount.Max().ToString() + "%" + "\nMin   " + dailycpuloadcount.Min().ToString() + "%";

                            for (int i = 0; i < dailycpuloadcount.Length; i++)
                            {
                                int index = statsChart1.chart1.Series["Series1"].Points.AddXY(i.ToString() + "H", dailycpuloadcount[i]);
                                if (dailycpuloadcount[i] != 0)
                                {
                                    statsChart1.chart1.Series["Series1"].Points[index].Label = dailycpuloadcount[i].ToString();
                                }
                            }

                        });
                    }
                    #endregion
                    Thread.Sleep(500);


                }
                #endregion

                #region CPU Date
                if (cpudate == true)
                {

                }
                #endregion

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
            blacktrack.Location = button1.Location;
            sidemenupanel.BringToFront();

        }

        void Getdate(object sender, EventArgs e)
        {
            this.date = statsChart1.monthCalendar2.SelectionRange.Start.ToString();
            string message = "Search on this date?\n" + date;
            DialogResult result = MessageBox.Show(message, "Ok?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //código para procurar data
                statsChart1.panel4.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statsChart1.BringToFront();
            sidemenupanel.BringToFront();
            blacktrack.Location = button4.Location;

        }
        #endregion

        #region PC1 Files

        void Writedays(bool temp, bool load)
        {
            string cpudailytoparse = "";
            string day = DateTime.Now.ToString("dd/MM/yyyy");
            string path = "";

            if (temp == true)
            {
                path = @"\Data\Colections\Charts\dtc.cfg";
            }

            if (load == true)
            {
                path = @"\Data\Colections\Charts\dlc.cfg";
            }

            StreamReader reader = new StreamReader(Application.StartupPath + path);
            cpudailytoparse = reader.ReadLine();
            reader.Close();

            string[] split = cpudailytoparse.Split('$');

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Contains(day))
                {
                    string[] splitdays = split[i].Split('%');

                    for (int k = 1; k < 24; k++)
                    {

                        if(load == true)
                        {
                            if (splitdays[k] == "0" && dailycpuloadcount[k] != 0)
                            {
                                if (k == splitdays.Length - 1)
                                {
                                    splitdays[k] = dailycpuloadcount[k].ToString();
                                }
                                else
                                {
                                    splitdays[k] = dailycpuloadcount[k].ToString();
                                }

                            }
                        }

                        if(temp == true)
                        {
                            if (splitdays[k] == "0" && dailycputempcount[k] != 0)
                            {
                                if (k == splitdays.Length - 1)
                                {
                                    splitdays[k] = dailycputempcount[k].ToString();
                                }
                                else
                                {
                                    splitdays[k] = dailycputempcount[k].ToString();
                                }

                            }
                        }
                        

                    }

                    for (int l = 0; l < splitdays.Length; l++)
                    {
                        if (l == 0)
                        {
                            split[i] = "$";
                        }

                        if (l == splitdays.Length - 1)
                        {
                            split[i] += splitdays[l].ToString() + "$";
                        }
                        else
                        {
                            split[i] += splitdays[l].ToString() + "%";
                        }
                    }

                }

            }

            StreamWriter writer = new StreamWriter(Application.StartupPath + path);

            string tosave = "";
            for (int i = 0; i < split.Length; i++)
            {
                tosave += split[i];
            }
            writer.WriteLine(tosave);
            writer.Close();
            

        }

        void ReadDay1st(bool temp, bool load)
        {
            string day = "";
            string cpudailytoparse = "";
            bool contains = false;
            day = DateTime.Now.ToString("dd/MM/yyyy");
            string path = "";
            
            if(temp == true)
            {
                path = @"\Data\Colections\Charts\dtc.cfg";
            }

            if(load == true)
            {
                path = @"\Data\Colections\Charts\dlc.cfg";
            }

            

            do
            {
                StreamReader reader = new StreamReader(Application.StartupPath + path);
                cpudailytoparse = reader.ReadLine();
                reader.Close();
                if (cpudailytoparse != " " && cpudailytoparse != null && cpudailytoparse != string.Empty)
                {
                    string[] split = cpudailytoparse.Split('$');

                    for (int i = 0; i < split.Length; i++)
                    {
                        if (split[i].Contains(day))
                        {
                            contains = true;
                            string[] splitdays = split[i].Split('%');

                            for (int k = 1; k < splitdays.Length; k++)
                            {
                                if(load == true)
                                dailycpuloadcount[k] = Convert.ToInt32(splitdays[k]);
                                if(temp == true)
                                dailycputempcount[k] = Convert.ToInt32(splitdays[k]);

                            }
                        }

                    }

                    if (contains == false)
                    {
                        StreamWriter writer = new StreamWriter(Application.StartupPath + path);
                        string insernewdate = day + "%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0" + "$";
                        writer.WriteLine(cpudailytoparse + insernewdate);
                        writer.Close();
                    }

                }
                else
                {
                    StreamWriter writer = new StreamWriter(Application.StartupPath + path);
                    string insernewdate = day + "%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0%0" + "$";
                    writer.WriteLine(cpudailytoparse + insernewdate);
                    writer.Close();
                }

            } while (contains == false);
           
        }


        void ReadDay(string datetofind, bool today)
        {
            string day = "";
            string cpudailytoparse = "";
            if (today == true)
            {
                day = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                day = datetofind;
            }
            StreamReader reader = new StreamReader(Application.StartupPath + @"\Data\Colections\Charts\dlc.cfg");
            cpudailytoparse = reader.ReadLine();
            reader.Close();
            if (cpudailytoparse != " " && cpudailytoparse != null && cpudailytoparse != string.Empty)
            {
                string[] split = cpudailytoparse.Split('$');
                
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i].Contains(day))
                    {
                        string[] splitdays = split[i].Split('%');

                        for (int k = 1; i < split.Length; k++)
                        {
                            dailycpuloadcount[k] = Convert.ToInt32(split[k]);
                        }
                    }

                }

            }
        }

        Task UpdatePCFiles()
        {
            ReadDay1st(true,false);
            ReadDay1st(false,true);
            string[] hours = new string[24];
            hours[0] = "00";
            hours[1] = "01";
            hours[2] = "02";
            hours[3] = "03";
            hours[4] = "04";
            hours[5] = "05";
            hours[6] = "06";
            hours[7] = "07";
            hours[8] = "08";
            hours[9] = "09";
            hours[10] = "10";
            hours[11] = "11";
            hours[12] = "12";
            hours[13] = "13";
            hours[14] = "14";
            hours[15] = "15";
            hours[16] = "16";
            hours[17] = "17";
            hours[18] = "18";
            hours[19] = "19";
            hours[20] = "20";
            hours[21] = "21";
            hours[22] = "22";
            hours[23] = "23";

            bool hoursdiff = false;

            string lasthour = " ";

            while (true)
            {
                #region CPU 
                Thread.Sleep(5000);
                string hour = DateTime.Now.ToString("HH:mm");
                string[] datesplit = hour.Split(':');
                for (int i = 0; i < hours.Length; i++)
                {
                    if (datesplit[0] == hours[i] && hoursdiff == false)
                    {

                        hoursdiff = true;
                        lasthour = datesplit[0];
                        if(dailycpuloadcount[i]==0)
                        {
                            this.dailycpuloadcount[i] = this.charcpuload;
                        }
                        if (dailycputempcount[i] == 0)
                        {
                          this.dailycputempcount[i] = this.charcputemp;
                        }

                    }
                    else
                    {
                        if (datesplit[0] != lasthour)
                        {
                            hoursdiff = false;
                        }

                    }

                }
                Writedays(true,false);
                Writedays(false, true);

                #endregion




            }
        }
        #endregion
    }
}
