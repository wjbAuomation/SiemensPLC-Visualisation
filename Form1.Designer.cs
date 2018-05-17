namespace Demo_Visualisation
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lvTags = new System.Windows.Forms.ListView();
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRepresentation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cControlName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Visual = new System.Windows.Forms.TabPage();
            this.tb_ENG_NO = new System.Windows.Forms.TextBox();
            this.tb_WPC_Status = new System.Windows.Forms.TextBox();
            this.tb_WPC_Number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Switch1 = new System.Windows.Forms.PictureBox();
            this.pb_Switch2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pb_Conveyor1 = new System.Windows.Forms.PictureBox();
            this.tp_Tags = new System.Windows.Forms.TabPage();
            this.bwOnlineMode = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.bi_m30_0 = new Indicator.BoolIndicator();
            this.bi_m25_0 = new Indicator.BoolIndicator();
            this.bi_e61_0 = new Indicator.BoolIndicator();
            this.bi_a61_3 = new Indicator.BoolIndicator();
            this.bi_a62_1 = new Indicator.BoolIndicator();
            this.bi_a62_0 = new Indicator.BoolIndicator();
            this.bi_e61_7 = new Indicator.BoolIndicator();
            this.bi_e61_6 = new Indicator.BoolIndicator();
            this.bi_a64_2 = new Indicator.BoolIndicator();
            this.bi_a64_1 = new Indicator.BoolIndicator();
            this.bi_e63_3 = new Indicator.BoolIndicator();
            this.bi_e63_2 = new Indicator.BoolIndicator();
            this.bi_e61_4 = new Indicator.BoolIndicator();
            this.bi_a60_0 = new Indicator.BoolIndicator();
            this.bi_e60_1 = new Indicator.BoolIndicator();
            this.bi_e61_5 = new Indicator.BoolIndicator();
            this.bi_e60_6 = new Indicator.BoolIndicator();
            this.bi_e60_5 = new Indicator.BoolIndicator();
            this.bi_e63_1 = new Indicator.BoolIndicator();
            this.bi_e63_0 = new Indicator.BoolIndicator();
            this.bi_e63_4 = new Indicator.BoolIndicator();
            this.bi_a64_0 = new Indicator.BoolIndicator();
            this.bi_m20_1 = new Indicator.BoolIndicator();
            this.tabControl1.SuspendLayout();
            this.tp_Visual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Switch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Switch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Conveyor1)).BeginInit();
            this.tp_Tags.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvTags
            // 
            this.lvTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cType,
            this.cDB,
            this.cStart,
            this.cLength,
            this.cBit,
            this.cRepresentation,
            this.cControlName,
            this.cValue,
            this.cDisplayName});
            this.lvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTags.GridLines = true;
            this.lvTags.Location = new System.Drawing.Point(3, 3);
            this.lvTags.Name = "lvTags";
            this.lvTags.Size = new System.Drawing.Size(1012, 519);
            this.lvTags.TabIndex = 1;
            this.lvTags.UseCompatibleStateImageBehavior = false;
            this.lvTags.View = System.Windows.Forms.View.Details;
            // 
            // cType
            // 
            this.cType.Text = "Type";
            // 
            // cDB
            // 
            this.cDB.Text = "DB Address";
            // 
            // cStart
            // 
            this.cStart.Text = "Start";
            // 
            // cLength
            // 
            this.cLength.Text = "Legth";
            // 
            // cBit
            // 
            this.cBit.Text = "Bit";
            // 
            // cRepresentation
            // 
            this.cRepresentation.Text = "Representation";
            // 
            // cControlName
            // 
            this.cControlName.Text = "Control Name";
            // 
            // cValue
            // 
            this.cValue.Text = "Value";
            // 
            // cDisplayName
            // 
            this.cDisplayName.Text = "Display Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Visual);
            this.tabControl1.Controls.Add(this.tp_Tags);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 551);
            this.tabControl1.TabIndex = 4;
            // 
            // tp_Visual
            // 
            this.tp_Visual.Controls.Add(this.bi_m30_0);
            this.tp_Visual.Controls.Add(this.bi_m25_0);
            this.tp_Visual.Controls.Add(this.bi_e61_0);
            this.tp_Visual.Controls.Add(this.bi_a61_3);
            this.tp_Visual.Controls.Add(this.bi_a62_1);
            this.tp_Visual.Controls.Add(this.bi_a62_0);
            this.tp_Visual.Controls.Add(this.bi_e61_7);
            this.tp_Visual.Controls.Add(this.bi_e61_6);
            this.tp_Visual.Controls.Add(this.bi_a64_2);
            this.tp_Visual.Controls.Add(this.bi_a64_1);
            this.tp_Visual.Controls.Add(this.bi_e63_3);
            this.tp_Visual.Controls.Add(this.bi_e63_2);
            this.tp_Visual.Controls.Add(this.bi_e61_4);
            this.tp_Visual.Controls.Add(this.bi_a60_0);
            this.tp_Visual.Controls.Add(this.bi_e60_1);
            this.tp_Visual.Controls.Add(this.bi_e61_5);
            this.tp_Visual.Controls.Add(this.bi_e60_6);
            this.tp_Visual.Controls.Add(this.bi_e60_5);
            this.tp_Visual.Controls.Add(this.bi_e63_1);
            this.tp_Visual.Controls.Add(this.bi_e63_0);
            this.tp_Visual.Controls.Add(this.bi_e63_4);
            this.tp_Visual.Controls.Add(this.bi_a64_0);
            this.tp_Visual.Controls.Add(this.bi_m20_1);
            this.tp_Visual.Controls.Add(this.tb_ENG_NO);
            this.tp_Visual.Controls.Add(this.tb_WPC_Status);
            this.tp_Visual.Controls.Add(this.tb_WPC_Number);
            this.tp_Visual.Controls.Add(this.pictureBox1);
            this.tp_Visual.Controls.Add(this.pb_Switch1);
            this.tp_Visual.Controls.Add(this.pb_Switch2);
            this.tp_Visual.Controls.Add(this.pictureBox3);
            this.tp_Visual.Controls.Add(this.pictureBox4);
            this.tp_Visual.Controls.Add(this.pictureBox2);
            this.tp_Visual.Controls.Add(this.pictureBox5);
            this.tp_Visual.Controls.Add(this.pb_Conveyor1);
            this.tp_Visual.Location = new System.Drawing.Point(4, 22);
            this.tp_Visual.Name = "tp_Visual";
            this.tp_Visual.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Visual.Size = new System.Drawing.Size(1018, 525);
            this.tp_Visual.TabIndex = 0;
            this.tp_Visual.Text = "Visualisation";
            this.tp_Visual.UseVisualStyleBackColor = true;
            // 
            // tb_ENG_NO
            // 
            this.tb_ENG_NO.Location = new System.Drawing.Point(798, 386);
            this.tb_ENG_NO.Name = "tb_ENG_NO";
            this.tb_ENG_NO.Size = new System.Drawing.Size(100, 20);
            this.tb_ENG_NO.TabIndex = 7;
            // 
            // tb_WPC_Status
            // 
            this.tb_WPC_Status.Location = new System.Drawing.Point(798, 360);
            this.tb_WPC_Status.Name = "tb_WPC_Status";
            this.tb_WPC_Status.Size = new System.Drawing.Size(100, 20);
            this.tb_WPC_Status.TabIndex = 7;
            // 
            // tb_WPC_Number
            // 
            this.tb_WPC_Number.Location = new System.Drawing.Point(798, 334);
            this.tb_WPC_Number.Name = "tb_WPC_Number";
            this.tb_WPC_Number.Size = new System.Drawing.Size(100, 20);
            this.tb_WPC_Number.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo_Visualisation.Properties.Resources.MotorIcon;
            this.pictureBox1.Location = new System.Drawing.Point(190, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Switch1
            // 
            this.pb_Switch1.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pb_Switch1.Location = new System.Drawing.Point(363, 309);
            this.pb_Switch1.Name = "pb_Switch1";
            this.pb_Switch1.Size = new System.Drawing.Size(103, 122);
            this.pb_Switch1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Switch1.TabIndex = 6;
            this.pb_Switch1.TabStop = false;
            // 
            // pb_Switch2
            // 
            this.pb_Switch2.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pb_Switch2.Location = new System.Drawing.Point(363, 26);
            this.pb_Switch2.Name = "pb_Switch2";
            this.pb_Switch2.Size = new System.Drawing.Size(104, 129);
            this.pb_Switch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Switch2.TabIndex = 6;
            this.pb_Switch2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon_Vertical;
            this.pictureBox3.Location = new System.Drawing.Point(363, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pictureBox4.Location = new System.Drawing.Point(466, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(525, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(466, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pictureBox5.Location = new System.Drawing.Point(190, 309);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 122);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pb_Conveyor1
            // 
            this.pb_Conveyor1.Image = global::Demo_Visualisation.Properties.Resources.Conveyor_Icon;
            this.pb_Conveyor1.Location = new System.Drawing.Point(190, 26);
            this.pb_Conveyor1.Name = "pb_Conveyor1";
            this.pb_Conveyor1.Size = new System.Drawing.Size(173, 129);
            this.pb_Conveyor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Conveyor1.TabIndex = 6;
            this.pb_Conveyor1.TabStop = false;
            // 
            // tp_Tags
            // 
            this.tp_Tags.Controls.Add(this.lvTags);
            this.tp_Tags.Location = new System.Drawing.Point(4, 22);
            this.tp_Tags.Name = "tp_Tags";
            this.tp_Tags.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Tags.Size = new System.Drawing.Size(1018, 525);
            this.tp_Tags.TabIndex = 1;
            this.tp_Tags.Text = "Tags";
            this.tp_Tags.UseVisualStyleBackColor = true;
            // 
            // bwOnlineMode
            // 
            this.bwOnlineMode.WorkerReportsProgress = true;
            this.bwOnlineMode.WorkerSupportsCancellation = true;
            this.bwOnlineMode.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOnlineMode_DoWork);
            this.bwOnlineMode.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwOnlineMode_ProgressChanged);
            this.bwOnlineMode.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOnlineMode_RunWorkerCompleted);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(85, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OFFLINE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bi_m30_0
            // 
            this.bi_m30_0.AlignLeft = true;
            this.bi_m30_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_m30_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_m30_0.Diagonal = 18;
            this.bi_m30_0.LabelText = "Control Name";
            this.bi_m30_0.LabelWidth = 80;
            this.bi_m30_0.Location = new System.Drawing.Point(8, 391);
            this.bi_m30_0.Name = "bi_m30_0";
            this.bi_m30_0.Size = new System.Drawing.Size(116, 18);
            this.bi_m30_0.State = false;
            this.bi_m30_0.TabIndex = 8;
            this.bi_m30_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_m25_0
            // 
            this.bi_m25_0.AlignLeft = true;
            this.bi_m25_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_m25_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_m25_0.Diagonal = 18;
            this.bi_m25_0.LabelText = "Control Name";
            this.bi_m25_0.LabelWidth = 80;
            this.bi_m25_0.Location = new System.Drawing.Point(8, 367);
            this.bi_m25_0.Name = "bi_m25_0";
            this.bi_m25_0.Size = new System.Drawing.Size(116, 18);
            this.bi_m25_0.State = false;
            this.bi_m25_0.TabIndex = 8;
            this.bi_m25_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e61_0
            // 
            this.bi_e61_0.AlignLeft = true;
            this.bi_e61_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e61_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e61_0.Diagonal = 18;
            this.bi_e61_0.LabelText = "Control Name";
            this.bi_e61_0.LabelWidth = 80;
            this.bi_e61_0.Location = new System.Drawing.Point(798, 461);
            this.bi_e61_0.Name = "bi_e61_0";
            this.bi_e61_0.Size = new System.Drawing.Size(116, 18);
            this.bi_e61_0.State = false;
            this.bi_e61_0.TabIndex = 8;
            this.bi_e61_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a61_3
            // 
            this.bi_a61_3.AlignLeft = true;
            this.bi_a61_3.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a61_3.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a61_3.Diagonal = 18;
            this.bi_a61_3.LabelText = "Control Name";
            this.bi_a61_3.LabelWidth = 80;
            this.bi_a61_3.Location = new System.Drawing.Point(798, 437);
            this.bi_a61_3.Name = "bi_a61_3";
            this.bi_a61_3.Size = new System.Drawing.Size(116, 18);
            this.bi_a61_3.State = false;
            this.bi_a61_3.TabIndex = 8;
            this.bi_a61_3.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a62_1
            // 
            this.bi_a62_1.AlignLeft = true;
            this.bi_a62_1.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a62_1.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a62_1.Diagonal = 18;
            this.bi_a62_1.LabelText = "Control Name";
            this.bi_a62_1.LabelWidth = 80;
            this.bi_a62_1.Location = new System.Drawing.Point(858, 81);
            this.bi_a62_1.Name = "bi_a62_1";
            this.bi_a62_1.Size = new System.Drawing.Size(116, 18);
            this.bi_a62_1.State = false;
            this.bi_a62_1.TabIndex = 8;
            this.bi_a62_1.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a62_0
            // 
            this.bi_a62_0.AlignLeft = true;
            this.bi_a62_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a62_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a62_0.Diagonal = 18;
            this.bi_a62_0.LabelText = "Control Name";
            this.bi_a62_0.LabelWidth = 80;
            this.bi_a62_0.Location = new System.Drawing.Point(687, 81);
            this.bi_a62_0.Name = "bi_a62_0";
            this.bi_a62_0.Size = new System.Drawing.Size(116, 18);
            this.bi_a62_0.State = false;
            this.bi_a62_0.TabIndex = 8;
            this.bi_a62_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e61_7
            // 
            this.bi_e61_7.AlignLeft = true;
            this.bi_e61_7.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e61_7.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e61_7.Diagonal = 18;
            this.bi_e61_7.LabelText = "Control Name";
            this.bi_e61_7.LabelWidth = 80;
            this.bi_e61_7.Location = new System.Drawing.Point(471, 81);
            this.bi_e61_7.Name = "bi_e61_7";
            this.bi_e61_7.Size = new System.Drawing.Size(116, 18);
            this.bi_e61_7.State = false;
            this.bi_e61_7.TabIndex = 8;
            this.bi_e61_7.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e61_6
            // 
            this.bi_e61_6.AlignLeft = true;
            this.bi_e61_6.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e61_6.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e61_6.Diagonal = 18;
            this.bi_e61_6.LabelText = "Control Name";
            this.bi_e61_6.LabelWidth = 80;
            this.bi_e61_6.Location = new System.Drawing.Point(207, 81);
            this.bi_e61_6.Name = "bi_e61_6";
            this.bi_e61_6.Size = new System.Drawing.Size(116, 18);
            this.bi_e61_6.State = false;
            this.bi_e61_6.TabIndex = 8;
            this.bi_e61_6.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a64_2
            // 
            this.bi_a64_2.AlignLeft = true;
            this.bi_a64_2.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a64_2.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a64_2.Diagonal = 18;
            this.bi_a64_2.LabelText = "Control Name";
            this.bi_a64_2.LabelWidth = 80;
            this.bi_a64_2.Location = new System.Drawing.Point(247, 197);
            this.bi_a64_2.Name = "bi_a64_2";
            this.bi_a64_2.Size = new System.Drawing.Size(116, 18);
            this.bi_a64_2.State = false;
            this.bi_a64_2.TabIndex = 8;
            this.bi_a64_2.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a64_1
            // 
            this.bi_a64_1.AlignLeft = true;
            this.bi_a64_1.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a64_1.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a64_1.Diagonal = 18;
            this.bi_a64_1.LabelText = "Control Name";
            this.bi_a64_1.LabelWidth = 80;
            this.bi_a64_1.Location = new System.Drawing.Point(247, 179);
            this.bi_a64_1.Name = "bi_a64_1";
            this.bi_a64_1.Size = new System.Drawing.Size(116, 18);
            this.bi_a64_1.State = false;
            this.bi_a64_1.TabIndex = 8;
            this.bi_a64_1.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e63_3
            // 
            this.bi_e63_3.AlignLeft = true;
            this.bi_e63_3.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e63_3.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e63_3.Diagonal = 18;
            this.bi_e63_3.LabelText = "Control Name";
            this.bi_e63_3.LabelWidth = 80;
            this.bi_e63_3.Location = new System.Drawing.Point(858, 161);
            this.bi_e63_3.Name = "bi_e63_3";
            this.bi_e63_3.Size = new System.Drawing.Size(116, 18);
            this.bi_e63_3.State = false;
            this.bi_e63_3.TabIndex = 8;
            this.bi_e63_3.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e63_2
            // 
            this.bi_e63_2.AlignLeft = true;
            this.bi_e63_2.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e63_2.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e63_2.Diagonal = 18;
            this.bi_e63_2.LabelText = "Control Name";
            this.bi_e63_2.LabelWidth = 80;
            this.bi_e63_2.Location = new System.Drawing.Point(687, 161);
            this.bi_e63_2.Name = "bi_e63_2";
            this.bi_e63_2.Size = new System.Drawing.Size(116, 18);
            this.bi_e63_2.State = false;
            this.bi_e63_2.TabIndex = 8;
            this.bi_e63_2.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e61_4
            // 
            this.bi_e61_4.AlignLeft = true;
            this.bi_e61_4.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e61_4.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e61_4.Diagonal = 18;
            this.bi_e61_4.LabelText = "Control Name";
            this.bi_e61_4.LabelWidth = 80;
            this.bi_e61_4.Location = new System.Drawing.Point(471, 437);
            this.bi_e61_4.Name = "bi_e61_4";
            this.bi_e61_4.Size = new System.Drawing.Size(116, 18);
            this.bi_e61_4.State = false;
            this.bi_e61_4.TabIndex = 8;
            this.bi_e61_4.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a60_0
            // 
            this.bi_a60_0.AlignLeft = true;
            this.bi_a60_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a60_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a60_0.Diagonal = 18;
            this.bi_a60_0.LabelText = "Control Name";
            this.bi_a60_0.LabelWidth = 80;
            this.bi_a60_0.Location = new System.Drawing.Point(644, 380);
            this.bi_a60_0.Name = "bi_a60_0";
            this.bi_a60_0.Size = new System.Drawing.Size(116, 18);
            this.bi_a60_0.State = false;
            this.bi_a60_0.TabIndex = 8;
            this.bi_a60_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e60_1
            // 
            this.bi_e60_1.AlignLeft = true;
            this.bi_e60_1.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e60_1.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e60_1.Diagonal = 18;
            this.bi_e60_1.LabelText = "Control Name";
            this.bi_e60_1.LabelWidth = 80;
            this.bi_e60_1.Location = new System.Drawing.Point(644, 343);
            this.bi_e60_1.Name = "bi_e60_1";
            this.bi_e60_1.Size = new System.Drawing.Size(116, 18);
            this.bi_e60_1.State = false;
            this.bi_e60_1.TabIndex = 8;
            this.bi_e60_1.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e61_5
            // 
            this.bi_e61_5.AlignLeft = true;
            this.bi_e61_5.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e61_5.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e61_5.Diagonal = 18;
            this.bi_e61_5.LabelText = "Control Name";
            this.bi_e61_5.LabelWidth = 80;
            this.bi_e61_5.Location = new System.Drawing.Point(471, 285);
            this.bi_e61_5.Name = "bi_e61_5";
            this.bi_e61_5.Size = new System.Drawing.Size(116, 18);
            this.bi_e61_5.State = false;
            this.bi_e61_5.TabIndex = 8;
            this.bi_e61_5.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e60_6
            // 
            this.bi_e60_6.AlignLeft = true;
            this.bi_e60_6.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e60_6.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e60_6.Diagonal = 26;
            this.bi_e60_6.LabelText = "Control Name";
            this.bi_e60_6.LabelWidth = 40;
            this.bi_e60_6.Location = new System.Drawing.Point(369, 380);
            this.bi_e60_6.Name = "bi_e60_6";
            this.bi_e60_6.Size = new System.Drawing.Size(91, 26);
            this.bi_e60_6.State = false;
            this.bi_e60_6.TabIndex = 8;
            this.bi_e60_6.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e60_5
            // 
            this.bi_e60_5.AlignLeft = true;
            this.bi_e60_5.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e60_5.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e60_5.Diagonal = 26;
            this.bi_e60_5.LabelText = "Control Name";
            this.bi_e60_5.LabelWidth = 40;
            this.bi_e60_5.Location = new System.Drawing.Point(369, 335);
            this.bi_e60_5.Name = "bi_e60_5";
            this.bi_e60_5.Size = new System.Drawing.Size(91, 26);
            this.bi_e60_5.State = false;
            this.bi_e60_5.TabIndex = 8;
            this.bi_e60_5.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e63_1
            // 
            this.bi_e63_1.AlignLeft = true;
            this.bi_e63_1.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e63_1.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e63_1.Diagonal = 26;
            this.bi_e63_1.LabelText = "Control Name";
            this.bi_e63_1.LabelWidth = 40;
            this.bi_e63_1.Location = new System.Drawing.Point(369, 105);
            this.bi_e63_1.Name = "bi_e63_1";
            this.bi_e63_1.Size = new System.Drawing.Size(91, 26);
            this.bi_e63_1.State = false;
            this.bi_e63_1.TabIndex = 8;
            this.bi_e63_1.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e63_0
            // 
            this.bi_e63_0.AlignLeft = true;
            this.bi_e63_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e63_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e63_0.Diagonal = 26;
            this.bi_e63_0.LabelText = "Control Name";
            this.bi_e63_0.LabelWidth = 40;
            this.bi_e63_0.Location = new System.Drawing.Point(369, 54);
            this.bi_e63_0.Name = "bi_e63_0";
            this.bi_e63_0.Size = new System.Drawing.Size(91, 26);
            this.bi_e63_0.State = false;
            this.bi_e63_0.TabIndex = 8;
            this.bi_e63_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_e63_4
            // 
            this.bi_e63_4.AlignLeft = true;
            this.bi_e63_4.ColorFalse = System.Drawing.Color.Gray;
            this.bi_e63_4.ColorTrue = System.Drawing.Color.Lime;
            this.bi_e63_4.Diagonal = 18;
            this.bi_e63_4.LabelText = "Control Name";
            this.bi_e63_4.LabelWidth = 80;
            this.bi_e63_4.Location = new System.Drawing.Point(471, 161);
            this.bi_e63_4.Name = "bi_e63_4";
            this.bi_e63_4.Size = new System.Drawing.Size(116, 18);
            this.bi_e63_4.State = false;
            this.bi_e63_4.TabIndex = 8;
            this.bi_e63_4.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_a64_0
            // 
            this.bi_a64_0.AlignLeft = true;
            this.bi_a64_0.ColorFalse = System.Drawing.Color.Gray;
            this.bi_a64_0.ColorTrue = System.Drawing.Color.Lime;
            this.bi_a64_0.Diagonal = 18;
            this.bi_a64_0.LabelText = "Control Name";
            this.bi_a64_0.LabelWidth = 80;
            this.bi_a64_0.Location = new System.Drawing.Point(247, 161);
            this.bi_a64_0.Name = "bi_a64_0";
            this.bi_a64_0.Size = new System.Drawing.Size(116, 18);
            this.bi_a64_0.State = false;
            this.bi_a64_0.TabIndex = 8;
            this.bi_a64_0.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // bi_m20_1
            // 
            this.bi_m20_1.AlignLeft = true;
            this.bi_m20_1.ColorFalse = System.Drawing.Color.Gray;
            this.bi_m20_1.ColorTrue = System.Drawing.Color.Lime;
            this.bi_m20_1.Diagonal = 18;
            this.bi_m20_1.LabelText = "Control Name";
            this.bi_m20_1.LabelWidth = 80;
            this.bi_m20_1.Location = new System.Drawing.Point(8, 343);
            this.bi_m20_1.Name = "bi_m20_1";
            this.bi_m20_1.Size = new System.Drawing.Size(116, 18);
            this.bi_m20_1.State = false;
            this.bi_m20_1.TabIndex = 8;
            this.bi_m20_1.TextDock = System.Windows.Forms.DockStyle.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tp_Visual.ResumeLayout(false);
            this.tp_Visual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Switch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Switch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Conveyor1)).EndInit();
            this.tp_Tags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvTags;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cDB;
        private System.Windows.Forms.ColumnHeader cStart;
        private System.Windows.Forms.ColumnHeader cLength;
        private System.Windows.Forms.ColumnHeader cBit;
        private System.Windows.Forms.ColumnHeader cRepresentation;
        private System.Windows.Forms.ColumnHeader cControlName;
        private System.Windows.Forms.ColumnHeader cValue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Visual;
        private System.Windows.Forms.TabPage tp_Tags;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader cDisplayName;
        private System.Windows.Forms.PictureBox pb_Switch1;
        private System.Windows.Forms.PictureBox pb_Switch2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_Conveyor1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.ComponentModel.BackgroundWorker bwOnlineMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_ENG_NO;
        private System.Windows.Forms.TextBox tb_WPC_Status;
        private System.Windows.Forms.TextBox tb_WPC_Number;
        private Indicator.BoolIndicator bi_m20_1;
        private Indicator.BoolIndicator bi_m30_0;
        private Indicator.BoolIndicator bi_m25_0;
        private Indicator.BoolIndicator bi_e61_0;
        private Indicator.BoolIndicator bi_a61_3;
        private Indicator.BoolIndicator bi_a62_1;
        private Indicator.BoolIndicator bi_a62_0;
        private Indicator.BoolIndicator bi_e61_7;
        private Indicator.BoolIndicator bi_e61_6;
        private Indicator.BoolIndicator bi_a64_2;
        private Indicator.BoolIndicator bi_a64_1;
        private Indicator.BoolIndicator bi_e63_3;
        private Indicator.BoolIndicator bi_e63_2;
        private Indicator.BoolIndicator bi_e61_4;
        private Indicator.BoolIndicator bi_a60_0;
        private Indicator.BoolIndicator bi_e60_1;
        private Indicator.BoolIndicator bi_e61_5;
        private Indicator.BoolIndicator bi_e60_6;
        private Indicator.BoolIndicator bi_e60_5;
        private Indicator.BoolIndicator bi_e63_1;
        private Indicator.BoolIndicator bi_e63_0;
        private Indicator.BoolIndicator bi_e63_4;
        private Indicator.BoolIndicator bi_a64_0;
    }
}

