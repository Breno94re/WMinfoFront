namespace WMinfo_Front
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Clock\'s", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node21");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Temperatures", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Load", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Fan Speed");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Fan", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("GPU", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode9,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Total Ram");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Free Ram");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("RAM", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.hname1 = new System.Windows.Forms.Label();
            this.pingt = new System.Windows.Forms.Label();
            this.pconoff = new System.Windows.Forms.Label();
            this.CPUP = new System.Windows.Forms.Panel();
            this.pname = new System.Windows.Forms.Label();
            this.CPUTV = new System.Windows.Forms.TreeView();
            this.chartcpuload = new CircularProgressBar.CircularProgressBar();
            this.charcputemp = new CircularProgressBar.CircularProgressBar();
            this.GPUP = new System.Windows.Forms.Panel();
            this.gname = new System.Windows.Forms.Label();
            this.GPUTV = new System.Windows.Forms.TreeView();
            this.chartgpuload = new CircularProgressBar.CircularProgressBar();
            this.chargputemp = new CircularProgressBar.CircularProgressBar();
            this.HDDP = new System.Windows.Forms.Panel();
            this.hddt = new System.Windows.Forms.Label();
            this.HDDTV = new System.Windows.Forms.TreeView();
            this.HDD3lifechart = new CircularProgressBar.CircularProgressBar();
            this.HDD3storagechart = new CircularProgressBar.CircularProgressBar();
            this.HDD2lifechart = new CircularProgressBar.CircularProgressBar();
            this.HDD2storagechart = new CircularProgressBar.CircularProgressBar();
            this.HDD1lifechart = new CircularProgressBar.CircularProgressBar();
            this.HDD1storagechart = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.uploadchart = new CircularProgressBar.CircularProgressBar();
            this.downloadchart = new CircularProgressBar.CircularProgressBar();
            this.RAMP = new System.Windows.Forms.Panel();
            this.moboname = new System.Windows.Forms.Label();
            this.RAMTV = new System.Windows.Forms.TreeView();
            this.Ramchart = new CircularProgressBar.CircularProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gpunotdetected = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pingi = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.CPUP.SuspendLayout();
            this.GPUP.SuspendLayout();
            this.HDDP.SuspendLayout();
            this.panel5.SuspendLayout();
            this.RAMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpunotdetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // hname1
            // 
            this.hname1.Font = new System.Drawing.Font("Lucida Sans", 13F, System.Drawing.FontStyle.Bold);
            this.hname1.ForeColor = System.Drawing.Color.White;
            this.hname1.Location = new System.Drawing.Point(148, 3);
            this.hname1.Name = "hname1";
            this.hname1.Size = new System.Drawing.Size(263, 147);
            this.hname1.TabIndex = 51;
            this.hname1.Text = "Host-Name: Desk9isPC\r\n\r\nAPI-Key: #78hjgd6H8\r\n\r\nIP: 192.168.1.1";
            this.hname1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hname1.Click += new System.EventHandler(this.hname1_Click);
            // 
            // pingt
            // 
            this.pingt.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pingt.ForeColor = System.Drawing.Color.Yellow;
            this.pingt.Location = new System.Drawing.Point(944, 86);
            this.pingt.Name = "pingt";
            this.pingt.Size = new System.Drawing.Size(111, 45);
            this.pingt.TabIndex = 53;
            this.pingt.Text = "999 MS";
            this.pingt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pconoff
            // 
            this.pconoff.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pconoff.ForeColor = System.Drawing.Color.Chartreuse;
            this.pconoff.Location = new System.Drawing.Point(944, 14);
            this.pconoff.Name = "pconoff";
            this.pconoff.Size = new System.Drawing.Size(111, 45);
            this.pconoff.TabIndex = 55;
            this.pconoff.Text = "ONLINE";
            this.pconoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUP
            // 
            this.CPUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CPUP.Controls.Add(this.pname);
            this.CPUP.Controls.Add(this.pictureBox4);
            this.CPUP.Controls.Add(this.button7);
            this.CPUP.Controls.Add(this.CPUTV);
            this.CPUP.Controls.Add(this.pictureBox8);
            this.CPUP.Controls.Add(this.pictureBox2);
            this.CPUP.Controls.Add(this.chartcpuload);
            this.CPUP.Controls.Add(this.charcputemp);
            this.CPUP.Location = new System.Drawing.Point(0, 150);
            this.CPUP.Name = "CPUP";
            this.CPUP.Size = new System.Drawing.Size(264, 570);
            this.CPUP.TabIndex = 57;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("Lucida Sans", 9.5F, System.Drawing.FontStyle.Bold);
            this.pname.ForeColor = System.Drawing.Color.White;
            this.pname.Location = new System.Drawing.Point(143, 3);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(118, 71);
            this.pname.TabIndex = 68;
            this.pname.Text = "model\'n brand";
            this.pname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CPUTV
            // 
            this.CPUTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.CPUTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTV.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.CPUTV.ForeColor = System.Drawing.Color.White;
            this.CPUTV.Location = new System.Drawing.Point(0, 104);
            this.CPUTV.Name = "CPUTV";
            this.CPUTV.Scrollable = false;
            this.CPUTV.Size = new System.Drawing.Size(264, 23);
            this.CPUTV.TabIndex = 61;
            // 
            // chartcpuload
            // 
            this.chartcpuload.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.chartcpuload.AnimationSpeed = 500;
            this.chartcpuload.BackColor = System.Drawing.Color.Transparent;
            this.chartcpuload.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold);
            this.chartcpuload.ForeColor = System.Drawing.Color.OrangeRed;
            this.chartcpuload.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.chartcpuload.InnerMargin = 2;
            this.chartcpuload.InnerWidth = -1;
            this.chartcpuload.Location = new System.Drawing.Point(33, 133);
            this.chartcpuload.MarqueeAnimationSpeed = 2000;
            this.chartcpuload.Name = "chartcpuload";
            this.chartcpuload.OuterColor = System.Drawing.Color.Gray;
            this.chartcpuload.OuterMargin = -26;
            this.chartcpuload.OuterWidth = 25;
            this.chartcpuload.ProgressColor = System.Drawing.Color.OrangeRed;
            this.chartcpuload.ProgressWidth = 15;
            this.chartcpuload.SecondaryFont = new System.Drawing.Font("Lucida Console", 11F);
            this.chartcpuload.Size = new System.Drawing.Size(200, 200);
            this.chartcpuload.StartAngle = 270;
            this.chartcpuload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.chartcpuload.SubscriptColor = System.Drawing.Color.White;
            this.chartcpuload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.chartcpuload.SubscriptText = "";
            this.chartcpuload.SuperscriptColor = System.Drawing.Color.White;
            this.chartcpuload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.chartcpuload.SuperscriptText = "";
            this.chartcpuload.TabIndex = 62;
            this.chartcpuload.Text = "?%";
            this.chartcpuload.TextMargin = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.chartcpuload, "CPU Load");
            this.chartcpuload.Value = 68;
            // 
            // charcputemp
            // 
            this.charcputemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.charcputemp.AnimationSpeed = 500;
            this.charcputemp.BackColor = System.Drawing.Color.Transparent;
            this.charcputemp.Font = new System.Drawing.Font("Lucida Console", 19F, System.Drawing.FontStyle.Bold);
            this.charcputemp.ForeColor = System.Drawing.Color.Chartreuse;
            this.charcputemp.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.charcputemp.InnerMargin = 2;
            this.charcputemp.InnerWidth = -1;
            this.charcputemp.Location = new System.Drawing.Point(33, 351);
            this.charcputemp.MarqueeAnimationSpeed = 2000;
            this.charcputemp.Name = "charcputemp";
            this.charcputemp.OuterColor = System.Drawing.Color.Gray;
            this.charcputemp.OuterMargin = -26;
            this.charcputemp.OuterWidth = 25;
            this.charcputemp.ProgressColor = System.Drawing.Color.Chartreuse;
            this.charcputemp.ProgressWidth = 15;
            this.charcputemp.SecondaryFont = new System.Drawing.Font("Lucida Console", 11F);
            this.charcputemp.Size = new System.Drawing.Size(200, 200);
            this.charcputemp.StartAngle = 270;
            this.charcputemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.charcputemp.SubscriptColor = System.Drawing.Color.White;
            this.charcputemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.charcputemp.SubscriptText = "";
            this.charcputemp.SuperscriptColor = System.Drawing.Color.White;
            this.charcputemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.charcputemp.SuperscriptText = "";
            this.charcputemp.TabIndex = 63;
            this.charcputemp.Text = "?ºC";
            this.charcputemp.TextMargin = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.charcputemp, "CPU temperatures");
            this.charcputemp.Value = 68;
            // 
            // GPUP
            // 
            this.GPUP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.GPUP.Controls.Add(this.pictureBox14);
            this.GPUP.Controls.Add(this.gname);
            this.GPUP.Controls.Add(this.button6);
            this.GPUP.Controls.Add(this.GPUTV);
            this.GPUP.Controls.Add(this.pictureBox9);
            this.GPUP.Controls.Add(this.pictureBox5);
            this.GPUP.Controls.Add(this.chartgpuload);
            this.GPUP.Controls.Add(this.chargputemp);
            this.GPUP.Controls.Add(this.gpunotdetected);
            this.GPUP.Location = new System.Drawing.Point(270, 151);
            this.GPUP.Name = "GPUP";
            this.GPUP.Size = new System.Drawing.Size(264, 569);
            this.GPUP.TabIndex = 58;
            // 
            // gname
            // 
            this.gname.Font = new System.Drawing.Font("Lucida Sans", 9.5F, System.Drawing.FontStyle.Bold);
            this.gname.ForeColor = System.Drawing.Color.White;
            this.gname.Location = new System.Drawing.Point(140, 3);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(121, 72);
            this.gname.TabIndex = 69;
            this.gname.Text = "model \'n brand";
            this.gname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GPUTV
            // 
            this.GPUTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.GPUTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPUTV.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.GPUTV.ForeColor = System.Drawing.Color.White;
            this.GPUTV.Location = new System.Drawing.Point(0, 104);
            this.GPUTV.Name = "GPUTV";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node2";
            treeNode4.Name = "Clock\'s";
            treeNode4.Text = "Clock\'s";
            treeNode5.Name = "Node21";
            treeNode5.Text = "Node21";
            treeNode6.Name = "Temperatures";
            treeNode6.Text = "Temperatures";
            treeNode7.Name = "Node17";
            treeNode7.Text = "Node17";
            treeNode8.Name = "Node18";
            treeNode8.Text = "Node18";
            treeNode9.Name = "Load";
            treeNode9.Text = "Load";
            treeNode10.Name = "Fan Speed";
            treeNode10.Text = "Fan Speed";
            treeNode11.Name = "Fan";
            treeNode11.Text = "Fan";
            treeNode12.Name = "GPU";
            treeNode12.Text = "GPU";
            this.GPUTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.GPUTV.Scrollable = false;
            this.GPUTV.Size = new System.Drawing.Size(264, 23);
            this.GPUTV.TabIndex = 62;
            this.GPUTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.GPUTV_AfterSelect);
            // 
            // chartgpuload
            // 
            this.chartgpuload.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.chartgpuload.AnimationSpeed = 500;
            this.chartgpuload.BackColor = System.Drawing.Color.Transparent;
            this.chartgpuload.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold);
            this.chartgpuload.ForeColor = System.Drawing.Color.OrangeRed;
            this.chartgpuload.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.chartgpuload.InnerMargin = 2;
            this.chartgpuload.InnerWidth = 2;
            this.chartgpuload.Location = new System.Drawing.Point(33, 133);
            this.chartgpuload.MarqueeAnimationSpeed = 2000;
            this.chartgpuload.Name = "chartgpuload";
            this.chartgpuload.OuterColor = System.Drawing.Color.Gray;
            this.chartgpuload.OuterMargin = -26;
            this.chartgpuload.OuterWidth = 25;
            this.chartgpuload.ProgressColor = System.Drawing.Color.OrangeRed;
            this.chartgpuload.ProgressWidth = 15;
            this.chartgpuload.SecondaryFont = new System.Drawing.Font("Lucida Console", 11F);
            this.chartgpuload.Size = new System.Drawing.Size(200, 200);
            this.chartgpuload.StartAngle = 270;
            this.chartgpuload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.chartgpuload.SubscriptColor = System.Drawing.Color.White;
            this.chartgpuload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.chartgpuload.SubscriptText = "";
            this.chartgpuload.SuperscriptColor = System.Drawing.Color.White;
            this.chartgpuload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.chartgpuload.SuperscriptText = "";
            this.chartgpuload.TabIndex = 64;
            this.chartgpuload.Text = "?%";
            this.chartgpuload.TextMargin = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.chartgpuload, "GPU Load");
            this.chartgpuload.Value = 68;
            // 
            // chargputemp
            // 
            this.chargputemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.chargputemp.AnimationSpeed = 500;
            this.chargputemp.BackColor = System.Drawing.Color.Transparent;
            this.chargputemp.Font = new System.Drawing.Font("Lucida Console", 19F, System.Drawing.FontStyle.Bold);
            this.chargputemp.ForeColor = System.Drawing.Color.Chartreuse;
            this.chargputemp.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.chargputemp.InnerMargin = 2;
            this.chargputemp.InnerWidth = -1;
            this.chargputemp.Location = new System.Drawing.Point(33, 351);
            this.chargputemp.MarqueeAnimationSpeed = 2000;
            this.chargputemp.Name = "chargputemp";
            this.chargputemp.OuterColor = System.Drawing.Color.Gray;
            this.chargputemp.OuterMargin = -26;
            this.chargputemp.OuterWidth = 25;
            this.chargputemp.ProgressColor = System.Drawing.Color.Chartreuse;
            this.chargputemp.ProgressWidth = 15;
            this.chargputemp.SecondaryFont = new System.Drawing.Font("Lucida Console", 11F);
            this.chargputemp.Size = new System.Drawing.Size(200, 200);
            this.chargputemp.StartAngle = 270;
            this.chargputemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.chargputemp.SubscriptColor = System.Drawing.Color.White;
            this.chargputemp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.chargputemp.SubscriptText = "";
            this.chargputemp.SuperscriptColor = System.Drawing.Color.White;
            this.chargputemp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.chargputemp.SuperscriptText = "";
            this.chargputemp.TabIndex = 65;
            this.chargputemp.Text = "?ºC";
            this.chargputemp.TextMargin = new System.Windows.Forms.Padding(0);
            this.toolTip1.SetToolTip(this.chargputemp, "GPU temperatures");
            this.chargputemp.Value = 68;
            // 
            // HDDP
            // 
            this.HDDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDDP.Controls.Add(this.hddt);
            this.HDDP.Controls.Add(this.button8);
            this.HDDP.Controls.Add(this.HDDTV);
            this.HDDP.Controls.Add(this.pictureBox11);
            this.HDDP.Controls.Add(this.pictureBox6);
            this.HDDP.Controls.Add(this.HDD3lifechart);
            this.HDDP.Controls.Add(this.HDD3storagechart);
            this.HDDP.Controls.Add(this.HDD2lifechart);
            this.HDDP.Controls.Add(this.HDD2storagechart);
            this.HDDP.Controls.Add(this.HDD1lifechart);
            this.HDDP.Controls.Add(this.HDD1storagechart);
            this.HDDP.Location = new System.Drawing.Point(540, 151);
            this.HDDP.Name = "HDDP";
            this.HDDP.Size = new System.Drawing.Size(264, 569);
            this.HDDP.TabIndex = 58;
            // 
            // hddt
            // 
            this.hddt.Font = new System.Drawing.Font("Lucida Sans", 7F, System.Drawing.FontStyle.Bold);
            this.hddt.ForeColor = System.Drawing.Color.White;
            this.hddt.Location = new System.Drawing.Point(64, 4);
            this.hddt.Name = "hddt";
            this.hddt.Size = new System.Drawing.Size(197, 72);
            this.hddt.TabIndex = 71;
            this.hddt.Text = "HDD1:\r\nHDD2:\r\nHDD3:";
            this.hddt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HDDTV
            // 
            this.HDDTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.HDDTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDTV.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.HDDTV.ForeColor = System.Drawing.Color.White;
            this.HDDTV.Location = new System.Drawing.Point(0, 104);
            this.HDDTV.Name = "HDDTV";
            this.HDDTV.Scrollable = false;
            this.HDDTV.Size = new System.Drawing.Size(264, 23);
            this.HDDTV.TabIndex = 70;
            this.HDDTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.HDDTV_AfterSelect);
            // 
            // HDD3lifechart
            // 
            this.HDD3lifechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD3lifechart.AnimationSpeed = 500;
            this.HDD3lifechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD3lifechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD3lifechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD3lifechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD3lifechart.InnerMargin = 2;
            this.HDD3lifechart.InnerWidth = 2;
            this.HDD3lifechart.Location = new System.Drawing.Point(141, 440);
            this.HDD3lifechart.MarqueeAnimationSpeed = 2000;
            this.HDD3lifechart.Maximum = 8000;
            this.HDD3lifechart.Name = "HDD3lifechart";
            this.HDD3lifechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD3lifechart.OuterMargin = -24;
            this.HDD3lifechart.OuterWidth = 25;
            this.HDD3lifechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD3lifechart.ProgressWidth = 10;
            this.HDD3lifechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD3lifechart.Size = new System.Drawing.Size(110, 110);
            this.HDD3lifechart.StartAngle = 270;
            this.HDD3lifechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD3lifechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD3lifechart.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.HDD3lifechart.SubscriptText = "Life";
            this.HDD3lifechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD3lifechart.SuperscriptMargin = new System.Windows.Forms.Padding(-30, -5, 0, 0);
            this.HDD3lifechart.SuperscriptText = "HDD3";
            this.HDD3lifechart.TabIndex = 75;
            this.HDD3lifechart.Text = "?%";
            this.HDD3lifechart.TextMargin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD3lifechart, "HDD 2 Life");
            this.HDD3lifechart.Value = 68;
            this.HDD3lifechart.Visible = false;
            // 
            // HDD3storagechart
            // 
            this.HDD3storagechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD3storagechart.AnimationSpeed = 500;
            this.HDD3storagechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD3storagechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD3storagechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD3storagechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD3storagechart.InnerMargin = 2;
            this.HDD3storagechart.InnerWidth = 2;
            this.HDD3storagechart.Location = new System.Drawing.Point(8, 440);
            this.HDD3storagechart.MarqueeAnimationSpeed = 2000;
            this.HDD3storagechart.Name = "HDD3storagechart";
            this.HDD3storagechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD3storagechart.OuterMargin = -24;
            this.HDD3storagechart.OuterWidth = 25;
            this.HDD3storagechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD3storagechart.ProgressWidth = 10;
            this.HDD3storagechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD3storagechart.Size = new System.Drawing.Size(110, 110);
            this.HDD3storagechart.StartAngle = 270;
            this.HDD3storagechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD3storagechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD3storagechart.SubscriptMargin = new System.Windows.Forms.Padding(-28, 5, 0, 0);
            this.HDD3storagechart.SubscriptText = "Storage";
            this.HDD3storagechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD3storagechart.SuperscriptMargin = new System.Windows.Forms.Padding(-28, -5, 0, 0);
            this.HDD3storagechart.SuperscriptText = "HDD3";
            this.HDD3storagechart.TabIndex = 74;
            this.HDD3storagechart.Text = "?%";
            this.HDD3storagechart.TextMargin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD3storagechart, "HDD 3 Storage");
            this.HDD3storagechart.Value = 68;
            this.HDD3storagechart.Visible = false;
            // 
            // HDD2lifechart
            // 
            this.HDD2lifechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD2lifechart.AnimationSpeed = 500;
            this.HDD2lifechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD2lifechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD2lifechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD2lifechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD2lifechart.InnerMargin = 2;
            this.HDD2lifechart.InnerWidth = 2;
            this.HDD2lifechart.Location = new System.Drawing.Point(141, 291);
            this.HDD2lifechart.MarqueeAnimationSpeed = 2000;
            this.HDD2lifechart.Maximum = 80000;
            this.HDD2lifechart.Name = "HDD2lifechart";
            this.HDD2lifechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD2lifechart.OuterMargin = -24;
            this.HDD2lifechart.OuterWidth = 25;
            this.HDD2lifechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD2lifechart.ProgressWidth = 10;
            this.HDD2lifechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD2lifechart.Size = new System.Drawing.Size(110, 110);
            this.HDD2lifechart.StartAngle = 270;
            this.HDD2lifechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD2lifechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD2lifechart.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.HDD2lifechart.SubscriptText = "Life";
            this.HDD2lifechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD2lifechart.SuperscriptMargin = new System.Windows.Forms.Padding(-30, -5, 0, 0);
            this.HDD2lifechart.SuperscriptText = "HDD2";
            this.HDD2lifechart.TabIndex = 73;
            this.HDD2lifechart.Text = "?%";
            this.HDD2lifechart.TextMargin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD2lifechart, "HDD 2 Life");
            this.HDD2lifechart.Value = 68;
            this.HDD2lifechart.Visible = false;
            // 
            // HDD2storagechart
            // 
            this.HDD2storagechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD2storagechart.AnimationSpeed = 500;
            this.HDD2storagechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD2storagechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD2storagechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD2storagechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD2storagechart.InnerMargin = 2;
            this.HDD2storagechart.InnerWidth = 2;
            this.HDD2storagechart.Location = new System.Drawing.Point(8, 291);
            this.HDD2storagechart.MarqueeAnimationSpeed = 2000;
            this.HDD2storagechart.Name = "HDD2storagechart";
            this.HDD2storagechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD2storagechart.OuterMargin = -24;
            this.HDD2storagechart.OuterWidth = 25;
            this.HDD2storagechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD2storagechart.ProgressWidth = 10;
            this.HDD2storagechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD2storagechart.Size = new System.Drawing.Size(110, 110);
            this.HDD2storagechart.StartAngle = 270;
            this.HDD2storagechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD2storagechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD2storagechart.SubscriptMargin = new System.Windows.Forms.Padding(-28, 5, 0, 0);
            this.HDD2storagechart.SubscriptText = "Storage";
            this.HDD2storagechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD2storagechart.SuperscriptMargin = new System.Windows.Forms.Padding(-28, -5, 0, 0);
            this.HDD2storagechart.SuperscriptText = "HDD2";
            this.HDD2storagechart.TabIndex = 72;
            this.HDD2storagechart.Text = "?%";
            this.HDD2storagechart.TextMargin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD2storagechart, "HDD 2 Storage");
            this.HDD2storagechart.Value = 68;
            this.HDD2storagechart.Visible = false;
            // 
            // HDD1lifechart
            // 
            this.HDD1lifechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD1lifechart.AnimationSpeed = 500;
            this.HDD1lifechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD1lifechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD1lifechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD1lifechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD1lifechart.InnerMargin = 2;
            this.HDD1lifechart.InnerWidth = 2;
            this.HDD1lifechart.Location = new System.Drawing.Point(141, 147);
            this.HDD1lifechart.MarqueeAnimationSpeed = 2000;
            this.HDD1lifechart.Maximum = 8000;
            this.HDD1lifechart.Name = "HDD1lifechart";
            this.HDD1lifechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD1lifechart.OuterMargin = -24;
            this.HDD1lifechart.OuterWidth = 25;
            this.HDD1lifechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD1lifechart.ProgressWidth = 10;
            this.HDD1lifechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD1lifechart.Size = new System.Drawing.Size(110, 110);
            this.HDD1lifechart.StartAngle = 270;
            this.HDD1lifechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD1lifechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD1lifechart.SubscriptMargin = new System.Windows.Forms.Padding(-30, 5, 0, 0);
            this.HDD1lifechart.SubscriptText = "Life";
            this.HDD1lifechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD1lifechart.SuperscriptMargin = new System.Windows.Forms.Padding(-30, -5, 0, 0);
            this.HDD1lifechart.SuperscriptText = "HDD1";
            this.HDD1lifechart.TabIndex = 71;
            this.HDD1lifechart.Text = "?%";
            this.HDD1lifechart.TextMargin = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD1lifechart, "HDD 1 Life");
            this.HDD1lifechart.Value = 68;
            this.HDD1lifechart.Visible = false;
            // 
            // HDD1storagechart
            // 
            this.HDD1storagechart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HDD1storagechart.AnimationSpeed = 500;
            this.HDD1storagechart.BackColor = System.Drawing.Color.Transparent;
            this.HDD1storagechart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.HDD1storagechart.ForeColor = System.Drawing.Color.OrangeRed;
            this.HDD1storagechart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HDD1storagechart.InnerMargin = 2;
            this.HDD1storagechart.InnerWidth = 2;
            this.HDD1storagechart.Location = new System.Drawing.Point(8, 147);
            this.HDD1storagechart.MarqueeAnimationSpeed = 2000;
            this.HDD1storagechart.Name = "HDD1storagechart";
            this.HDD1storagechart.OuterColor = System.Drawing.Color.Gray;
            this.HDD1storagechart.OuterMargin = -24;
            this.HDD1storagechart.OuterWidth = 25;
            this.HDD1storagechart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.HDD1storagechart.ProgressWidth = 10;
            this.HDD1storagechart.SecondaryFont = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDD1storagechart.Size = new System.Drawing.Size(110, 110);
            this.HDD1storagechart.StartAngle = 270;
            this.HDD1storagechart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HDD1storagechart.SubscriptColor = System.Drawing.Color.White;
            this.HDD1storagechart.SubscriptMargin = new System.Windows.Forms.Padding(-28, 5, 0, 0);
            this.HDD1storagechart.SubscriptText = "Storage";
            this.HDD1storagechart.SuperscriptColor = System.Drawing.Color.White;
            this.HDD1storagechart.SuperscriptMargin = new System.Windows.Forms.Padding(-28, -5, 0, 0);
            this.HDD1storagechart.SuperscriptText = "HDD1";
            this.HDD1storagechart.TabIndex = 70;
            this.HDD1storagechart.Text = "?%";
            this.HDD1storagechart.TextMargin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.toolTip1.SetToolTip(this.HDD1storagechart, "HDD 1 Storage");
            this.HDD1storagechart.Value = 68;
            this.HDD1storagechart.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1073, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 720);
            this.panel5.TabIndex = 67;
            // 
            // uploadchart
            // 
            this.uploadchart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.uploadchart.AnimationSpeed = 500;
            this.uploadchart.BackColor = System.Drawing.Color.Transparent;
            this.uploadchart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.uploadchart.ForeColor = System.Drawing.Color.SteelBlue;
            this.uploadchart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.uploadchart.InnerMargin = 2;
            this.uploadchart.InnerWidth = 2;
            this.uploadchart.Location = new System.Drawing.Point(523, -1);
            this.uploadchart.MarqueeAnimationSpeed = 2000;
            this.uploadchart.Name = "uploadchart";
            this.uploadchart.OuterColor = System.Drawing.Color.Gray;
            this.uploadchart.OuterMargin = -24;
            this.uploadchart.OuterWidth = 25;
            this.uploadchart.ProgressColor = System.Drawing.Color.SteelBlue;
            this.uploadchart.ProgressWidth = 10;
            this.uploadchart.SecondaryFont = new System.Drawing.Font("Lucida Console", 12F);
            this.uploadchart.Size = new System.Drawing.Size(150, 150);
            this.uploadchart.StartAngle = 270;
            this.uploadchart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.uploadchart.SubscriptColor = System.Drawing.Color.White;
            this.uploadchart.SubscriptMargin = new System.Windows.Forms.Padding(-45, 5, 0, 0);
            this.uploadchart.SubscriptText = "900KBPS";
            this.uploadchart.SuperscriptColor = System.Drawing.Color.White;
            this.uploadchart.SuperscriptMargin = new System.Windows.Forms.Padding(-48, -5, 0, 0);
            this.uploadchart.SuperscriptText = "Upload";
            this.uploadchart.TabIndex = 76;
            this.uploadchart.Text = "100%";
            this.uploadchart.TextMargin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.uploadchart.Value = 68;
            // 
            // downloadchart
            // 
            this.downloadchart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.downloadchart.AnimationSpeed = 500;
            this.downloadchart.BackColor = System.Drawing.Color.Transparent;
            this.downloadchart.Font = new System.Drawing.Font("Lucida Console", 15.25F, System.Drawing.FontStyle.Bold);
            this.downloadchart.ForeColor = System.Drawing.Color.SteelBlue;
            this.downloadchart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.downloadchart.InnerMargin = 2;
            this.downloadchart.InnerWidth = 2;
            this.downloadchart.Location = new System.Drawing.Point(679, -1);
            this.downloadchart.MarqueeAnimationSpeed = 2000;
            this.downloadchart.Name = "downloadchart";
            this.downloadchart.OuterColor = System.Drawing.Color.Gray;
            this.downloadchart.OuterMargin = -24;
            this.downloadchart.OuterWidth = 25;
            this.downloadchart.ProgressColor = System.Drawing.Color.SteelBlue;
            this.downloadchart.ProgressWidth = 10;
            this.downloadchart.SecondaryFont = new System.Drawing.Font("Lucida Console", 12F);
            this.downloadchart.Size = new System.Drawing.Size(150, 150);
            this.downloadchart.StartAngle = 270;
            this.downloadchart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.downloadchart.SubscriptColor = System.Drawing.Color.White;
            this.downloadchart.SubscriptMargin = new System.Windows.Forms.Padding(-45, 5, 0, 0);
            this.downloadchart.SubscriptText = "900KBPS";
            this.downloadchart.SuperscriptColor = System.Drawing.Color.White;
            this.downloadchart.SuperscriptMargin = new System.Windows.Forms.Padding(-48, -5, 0, 0);
            this.downloadchart.SuperscriptText = "Download";
            this.downloadchart.TabIndex = 76;
            this.downloadchart.Text = "100%";
            this.downloadchart.TextMargin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.downloadchart.Value = 68;
            // 
            // RAMP
            // 
            this.RAMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.RAMP.Controls.Add(this.moboname);
            this.RAMP.Controls.Add(this.button9);
            this.RAMP.Controls.Add(this.RAMTV);
            this.RAMP.Controls.Add(this.Ramchart);
            this.RAMP.Controls.Add(this.pictureBox13);
            this.RAMP.Controls.Add(this.pictureBox7);
            this.RAMP.Location = new System.Drawing.Point(810, 151);
            this.RAMP.Name = "RAMP";
            this.RAMP.Size = new System.Drawing.Size(264, 569);
            this.RAMP.TabIndex = 58;
            // 
            // moboname
            // 
            this.moboname.Font = new System.Drawing.Font("Lucida Sans", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moboname.ForeColor = System.Drawing.Color.White;
            this.moboname.Location = new System.Drawing.Point(74, 2);
            this.moboname.Name = "moboname";
            this.moboname.Size = new System.Drawing.Size(187, 72);
            this.moboname.TabIndex = 76;
            this.moboname.Text = "Manufacturer: Intel ";
            this.moboname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RAMTV
            // 
            this.RAMTV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.RAMTV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RAMTV.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.RAMTV.ForeColor = System.Drawing.Color.White;
            this.RAMTV.Location = new System.Drawing.Point(3, 103);
            this.RAMTV.Name = "RAMTV";
            treeNode13.Name = "Total Ram";
            treeNode13.Text = "Total Ram";
            treeNode14.Name = "Free Ram";
            treeNode14.Text = "Free Ram";
            treeNode15.Name = "RAM";
            treeNode15.Text = "RAM";
            this.RAMTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.RAMTV.Scrollable = false;
            this.RAMTV.Size = new System.Drawing.Size(264, 23);
            this.RAMTV.TabIndex = 77;
            // 
            // Ramchart
            // 
            this.Ramchart.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Ramchart.AnimationSpeed = 500;
            this.Ramchart.BackColor = System.Drawing.Color.Transparent;
            this.Ramchart.Font = new System.Drawing.Font("Lucida Console", 18.25F, System.Drawing.FontStyle.Bold);
            this.Ramchart.ForeColor = System.Drawing.Color.OrangeRed;
            this.Ramchart.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Ramchart.InnerMargin = 2;
            this.Ramchart.InnerWidth = -1;
            this.Ramchart.Location = new System.Drawing.Point(33, 230);
            this.Ramchart.MarqueeAnimationSpeed = 2000;
            this.Ramchart.Name = "Ramchart";
            this.Ramchart.OuterColor = System.Drawing.Color.Gray;
            this.Ramchart.OuterMargin = -26;
            this.Ramchart.OuterWidth = 25;
            this.Ramchart.ProgressColor = System.Drawing.Color.OrangeRed;
            this.Ramchart.ProgressWidth = 15;
            this.Ramchart.SecondaryFont = new System.Drawing.Font("Lucida Console", 11F);
            this.Ramchart.Size = new System.Drawing.Size(200, 200);
            this.Ramchart.StartAngle = 270;
            this.Ramchart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Ramchart.SubscriptColor = System.Drawing.Color.White;
            this.Ramchart.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Ramchart.SubscriptText = "";
            this.Ramchart.SuperscriptColor = System.Drawing.Color.White;
            this.Ramchart.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Ramchart.SuperscriptText = "";
            this.Ramchart.TabIndex = 69;
            this.Ramchart.Text = "?%";
            this.Ramchart.TextMargin = new System.Windows.Forms.Padding(0);
            this.Ramchart.Value = 68;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button12.BackgroundImage = global::WMinfo_Front.Properties.Resources.marquee;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button12.Location = new System.Drawing.Point(2, 414);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 56);
            this.button12.TabIndex = 71;
            this.button12.TabStop = false;
            this.toolTip1.SetToolTip(this.button12, "Remote Desktop");
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button11.BackgroundImage = global::WMinfo_Front.Properties.Resources.sitemap__1_;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button11.Location = new System.Drawing.Point(2, 337);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 56);
            this.button11.TabIndex = 70;
            this.button11.TabStop = false;
            this.toolTip1.SetToolTip(this.button11, "Remote TaskViewer");
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button10.BackgroundImage = global::WMinfo_Front.Properties.Resources.grid__1_;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button10.Location = new System.Drawing.Point(2, 265);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 56);
            this.button10.TabIndex = 69;
            this.button10.TabStop = false;
            this.toolTip1.SetToolTip(this.button10, "Remote Console");
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button5.BackgroundImage = global::WMinfo_Front.Properties.Resources.repeat;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button5.Location = new System.Drawing.Point(2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 56);
            this.button5.TabIndex = 68;
            this.button5.TabStop = false;
            this.toolTip1.SetToolTip(this.button5, "Connection");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button4.BackgroundImage = global::WMinfo_Front.Properties.Resources.cancel;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button4.Location = new System.Drawing.Point(3, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 56);
            this.button4.TabIndex = 67;
            this.button4.TabStop = false;
            this.toolTip1.SetToolTip(this.button4, "Delete this Remote PC");
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button3.BackgroundImage = global::WMinfo_Front.Properties.Resources.refresh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button3.Location = new System.Drawing.Point(2, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 56);
            this.button3.TabIndex = 66;
            this.button3.TabStop = false;
            this.toolTip1.SetToolTip(this.button3, "Reboot Remote PC");
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button2.BackgroundImage = global::WMinfo_Front.Properties.Resources.volume1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button2.Location = new System.Drawing.Point(2, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 56);
            this.button2.TabIndex = 65;
            this.button2.TabStop = false;
            this.toolTip1.SetToolTip(this.button2, "Alarms");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button1.BackgroundImage = global::WMinfo_Front.Properties.Resources.power_button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(111)))));
            this.button1.Location = new System.Drawing.Point(2, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 56);
            this.button1.TabIndex = 64;
            this.button1.TabStop = false;
            this.toolTip1.SetToolTip(this.button1, "ShutDown Remote PC");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WMinfo_Front.Properties.Resources.nvidia;
            this.pictureBox14.Location = new System.Drawing.Point(82, 3);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(55, 72);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 69;
            this.pictureBox14.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.button6.BackgroundImage = global::WMinfo_Front.Properties.Resources.BT_double_arrow_left128x___Copy;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(3, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 19);
            this.button6.TabIndex = 66;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.pictureBox9.Image = global::WMinfo_Front.Properties.Resources.exclamation_mark__1_;
            this.pictureBox9.Location = new System.Drawing.Point(59, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 17);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 58;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WMinfo_Front.Properties.Resources.graphic_card;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 72);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // gpunotdetected
            // 
            this.gpunotdetected.Image = global::WMinfo_Front.Properties.Resources.Nocgpu__1_;
            this.gpunotdetected.Location = new System.Drawing.Point(0, -1);
            this.gpunotdetected.Name = "gpunotdetected";
            this.gpunotdetected.Size = new System.Drawing.Size(264, 569);
            this.gpunotdetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gpunotdetected.TabIndex = 70;
            this.gpunotdetected.TabStop = false;
            this.gpunotdetected.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WMinfo_Front.Properties.Resources.cloud;
            this.pictureBox12.Location = new System.Drawing.Point(417, -2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 151);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 64;
            this.pictureBox12.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.button8.BackgroundImage = global::WMinfo_Front.Properties.Resources.BT_double_arrow_left128x___Copy;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(3, 79);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(258, 19);
            this.button8.TabIndex = 70;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.pictureBox11.Image = global::WMinfo_Front.Properties.Resources.exclamation_mark__1_;
            this.pictureBox11.Location = new System.Drawing.Point(41, 10);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(17, 17);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 59;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WMinfo_Front.Properties.Resources.hard_disk;
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 72);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 56;
            this.pictureBox6.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.button9.BackgroundImage = global::WMinfo_Front.Properties.Resources.BT_double_arrow_left128x___Copy;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(3, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(258, 19);
            this.button9.TabIndex = 76;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.pictureBox13.Image = global::WMinfo_Front.Properties.Resources.exclamation_mark__1_;
            this.pictureBox13.Location = new System.Drawing.Point(51, 10);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(17, 17);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 60;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WMinfo_Front.Properties.Resources.mainboard1;
            this.pictureBox7.Location = new System.Drawing.Point(5, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 72);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 57;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WMinfo_Front.Properties.Resources.intel;
            this.pictureBox4.Location = new System.Drawing.Point(72, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 68;
            this.pictureBox4.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.button7.BackgroundImage = global::WMinfo_Front.Properties.Resources.BT_double_arrow_left128x___Copy;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(3, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(258, 19);
            this.button7.TabIndex = 67;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(85)))));
            this.pictureBox8.Image = global::WMinfo_Front.Properties.Resources.exclamation_mark__1_;
            this.pictureBox8.Location = new System.Drawing.Point(38, 42);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 17);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 57;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WMinfo_Front.Properties.Resources.cpu;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WMinfo_Front.Properties.Resources.link;
            this.pictureBox1.Location = new System.Drawing.Point(835, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pingi
            // 
            this.pingi.Image = global::WMinfo_Front.Properties.Resources.rec__1_;
            this.pingi.Location = new System.Drawing.Point(835, 77);
            this.pingi.Name = "pingi";
            this.pingi.Size = new System.Drawing.Size(87, 68);
            this.pingi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pingi.TabIndex = 52;
            this.pingi.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WMinfo_Front.Properties.Resources.monitor;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(142, 151);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 49;
            this.pictureBox10.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.downloadchart);
            this.Controls.Add(this.uploadchart);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.GPUP);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.HDDP);
            this.Controls.Add(this.RAMP);
            this.Controls.Add(this.CPUP);
            this.Controls.Add(this.pconoff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pingi);
            this.Controls.Add(this.pingt);
            this.Controls.Add(this.hname1);
            this.Controls.Add(this.pictureBox10);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1141, 720);
            this.CPUP.ResumeLayout(false);
            this.GPUP.ResumeLayout(false);
            this.HDDP.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.RAMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpunotdetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label hname1;
        public System.Windows.Forms.Label pingt;
        public System.Windows.Forms.Label pconoff;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pingi;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel CPUP;
        public System.Windows.Forms.Panel GPUP;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Panel HDDP;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox12;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TreeView GPUTV;
        public System.Windows.Forms.TreeView CPUTV;
        public CircularProgressBar.CircularProgressBar chartcpuload;
        public CircularProgressBar.CircularProgressBar charcputemp;
        public CircularProgressBar.CircularProgressBar chartgpuload;
        public CircularProgressBar.CircularProgressBar chargputemp;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label pname;
        private System.Windows.Forms.PictureBox pictureBox14;
        public System.Windows.Forms.Label gname;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TreeView HDDTV;
        public CircularProgressBar.CircularProgressBar HDD1storagechart;
        public CircularProgressBar.CircularProgressBar HDD1lifechart;
        public CircularProgressBar.CircularProgressBar HDD3lifechart;
        public CircularProgressBar.CircularProgressBar HDD3storagechart;
        public CircularProgressBar.CircularProgressBar HDD2lifechart;
        public CircularProgressBar.CircularProgressBar HDD2storagechart;
        public CircularProgressBar.CircularProgressBar uploadchart;
        public CircularProgressBar.CircularProgressBar downloadchart;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox13;
        public System.Windows.Forms.Panel RAMP;
        public System.Windows.Forms.Label hddt;
        public CircularProgressBar.CircularProgressBar Ramchart;
        public System.Windows.Forms.PictureBox gpunotdetected;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.TreeView RAMTV;
        public System.Windows.Forms.Label moboname;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button12;
    }
}
