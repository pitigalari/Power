namespace Power
{
    partial class action
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(action));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Hnud = new System.Windows.Forms.NumericUpDown();
            this.Mnud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DDnud = new System.Windows.Forms.NumericUpDown();
            this.MMnud = new System.Windows.Forms.NumericUpDown();
            this.YYnud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ico = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YYnud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Arial", 8F);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(415, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(161, 14);
            this.date.TabIndex = 25;
            this.date.Text = "Wednesday, 08 November 2014";
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Arial", 19F);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(378, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(121, 31);
            this.time.TabIndex = 26;
            this.time.Text = "12:59 AM";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(12, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(215, 26);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Select Specific Time";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 247);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(208, 26);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Countdown Trigger";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.MaximumSize = new System.Drawing.Size(299, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Set time to issue command.";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(260, 290);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(42, 26);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(150, 290);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 26);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Hnud
            // 
            this.Hnud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hnud.Enabled = false;
            this.Hnud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hnud.Location = new System.Drawing.Point(150, 139);
            this.Hnud.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hnud.Name = "Hnud";
            this.Hnud.Size = new System.Drawing.Size(42, 26);
            this.Hnud.TabIndex = 2;
            this.Hnud.ValueChanged += new System.EventHandler(this.Hnud_ValueChanged);
            // 
            // Mnud
            // 
            this.Mnud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mnud.Enabled = false;
            this.Mnud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mnud.Location = new System.Drawing.Point(228, 139);
            this.Mnud.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Mnud.Name = "Mnud";
            this.Mnud.Size = new System.Drawing.Size(42, 26);
            this.Mnud.TabIndex = 3;
            this.Mnud.ValueChanged += new System.EventHandler(this.MMnud_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(198, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "hour(s)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(308, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "minute(s)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(376, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(482, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(159, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 44;
            this.label6.Text = "HH";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(148, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "Enter values to start the countdown";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(228, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 2);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(228, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 2);
            this.panel1.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Hibernate",
            "Standby",
            "Lock",
            "Log Off",
            "Screen Off"});
            this.comboBox1.Location = new System.Drawing.Point(129, 67);
            this.comboBox1.MaxDropDownItems = 3;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 27);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "-Select Command-";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.MaximumSize = new System.Drawing.Size(299, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Command :";
            // 
            // DDnud
            // 
            this.DDnud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DDnud.Enabled = false;
            this.DDnud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDnud.Location = new System.Drawing.Point(150, 194);
            this.DDnud.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DDnud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DDnud.Name = "DDnud";
            this.DDnud.Size = new System.Drawing.Size(42, 26);
            this.DDnud.TabIndex = 4;
            this.DDnud.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.DDnud.ValueChanged += new System.EventHandler(this.DDnud_ValueChanged);
            // 
            // MMnud
            // 
            this.MMnud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MMnud.Enabled = false;
            this.MMnud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMnud.Location = new System.Drawing.Point(227, 194);
            this.MMnud.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MMnud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MMnud.Name = "MMnud";
            this.MMnud.Size = new System.Drawing.Size(42, 26);
            this.MMnud.TabIndex = 5;
            this.MMnud.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MMnud.ValueChanged += new System.EventHandler(this.MMnud_ValueChanged);
            // 
            // YYnud
            // 
            this.YYnud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YYnud.Enabled = false;
            this.YYnud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YYnud.Location = new System.Drawing.Point(301, 194);
            this.YYnud.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.YYnud.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.YYnud.Name = "YYnud";
            this.YYnud.Size = new System.Drawing.Size(60, 26);
            this.YYnud.TabIndex = 6;
            this.YYnud.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.YYnud.ValueChanged += new System.EventHandler(this.YYnud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(280, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "/";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(236, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 14);
            this.label10.TabIndex = 61;
            this.label10.Text = "MM";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(158, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 62;
            this.label11.Text = "DD";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(235, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 14);
            this.label12.TabIndex = 63;
            this.label12.Text = "MM";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(312, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 14);
            this.label13.TabIndex = 64;
            this.label13.Text = "YYYY";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(16, 385);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Ask me before executing command(s)";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ico
            // 
            this.ico.BackColor = System.Drawing.Color.Transparent;
            this.ico.BackgroundImage = global::Power.Properties.Resources.helpicowhite;
            this.ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ico.FlatAppearance.BorderSize = 0;
            this.ico.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ico.ForeColor = System.Drawing.Color.White;
            this.ico.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ico.Location = new System.Drawing.Point(560, 8);
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(25, 25);
            this.ico.TabIndex = 13;
            this.ico.UseVisualStyleBackColor = false;
            this.ico.Click += new System.EventHandler(this.ico_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.ico_Click);
            // 
            // action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Power.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.ico);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YYnud);
            this.Controls.Add(this.MMnud);
            this.Controls.Add(this.DDnud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mnud);
            this.Controls.Add(this.Hnud);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "action";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power - Action Panel";
            this.Load += new System.EventHandler(this.action_Load);
            this.Shown += new System.EventHandler(this.action_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YYnud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown Hnud;
        private System.Windows.Forms.NumericUpDown Mnud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown DDnud;
        private System.Windows.Forms.NumericUpDown MMnud;
        private System.Windows.Forms.NumericUpDown YYnud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ico;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}