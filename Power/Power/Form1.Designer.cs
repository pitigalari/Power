namespace Power
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reportBugsRequestHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SDl = new System.Windows.Forms.Label();
            this.Rl = new System.Windows.Forms.Label();
            this.Hl = new System.Windows.Forms.Label();
            this.SBl = new System.Windows.Forms.Label();
            this.Ll = new System.Windows.Forms.Label();
            this.LOl = new System.Windows.Forms.Label();
            this.SOl = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SDb = new System.Windows.Forms.Button();
            this.Rb = new System.Windows.Forms.Button();
            this.Hb = new System.Windows.Forms.Button();
            this.SBb = new System.Windows.Forms.Button();
            this.Lb = new System.Windows.Forms.Button();
            this.LOb = new System.Windows.Forms.Button();
            this.SOb = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SB = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.H = new System.Windows.Forms.Panel();
            this.L = new System.Windows.Forms.Panel();
            this.LO = new System.Windows.Forms.Panel();
            this.SO = new System.Windows.Forms.Panel();
            this.R = new System.Windows.Forms.Panel();
            this.SD = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Close application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefencesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // prefencesToolStripMenuItem
            // 
            this.prefencesToolStripMenuItem.Image = global::Power.Properties.Resources.setico;
            this.prefencesToolStripMenuItem.Name = "prefencesToolStripMenuItem";
            this.prefencesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.prefencesToolStripMenuItem.Text = "&Settings";
            this.prefencesToolStripMenuItem.ToolTipText = "Settings";
            this.prefencesToolStripMenuItem.Click += new System.EventHandler(this.prefencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2,
            this.toolStripSeparator2,
            this.reportBugsRequestHelpToolStripMenuItem});
            this.helpToolStripMenuItem1.Image = global::Power.Properties.Resources.helpico;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Image = global::Power.Properties.Resources.infoico;
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(253, 22);
            this.helpToolStripMenuItem2.Text = "&Information Panel";
            this.helpToolStripMenuItem2.ToolTipText = "Help - Tips";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(250, 6);
            // 
            // reportBugsRequestHelpToolStripMenuItem
            // 
            this.reportBugsRequestHelpToolStripMenuItem.Image = global::Power.Properties.Resources.bugico;
            this.reportBugsRequestHelpToolStripMenuItem.Name = "reportBugsRequestHelpToolStripMenuItem";
            this.reportBugsRequestHelpToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.reportBugsRequestHelpToolStripMenuItem.Text = "&Report bugs / Request online help";
            this.reportBugsRequestHelpToolStripMenuItem.Click += new System.EventHandler(this.reportBugsRequestHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About ";
            this.aboutToolStripMenuItem.ToolTipText = "About Power";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SDl
            // 
            this.SDl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SDl.AutoSize = true;
            this.SDl.BackColor = System.Drawing.Color.Transparent;
            this.SDl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SDl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDl.ForeColor = System.Drawing.Color.White;
            this.SDl.Location = new System.Drawing.Point(102, 334);
            this.SDl.Name = "SDl";
            this.SDl.Size = new System.Drawing.Size(79, 18);
            this.SDl.TabIndex = 3;
            this.SDl.Text = "Shutdown";
            this.SDl.Enter += new System.EventHandler(this.SD_MouseEnter);
            this.SDl.Leave += new System.EventHandler(this.SD_MouseLeave);
            this.SDl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SD_MouseDown);
            this.SDl.MouseEnter += new System.EventHandler(this.SD_MouseEnter);
            this.SDl.MouseLeave += new System.EventHandler(this.SD_MouseLeave);
            this.SDl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // Rl
            // 
            this.Rl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rl.AutoSize = true;
            this.Rl.BackColor = System.Drawing.Color.Transparent;
            this.Rl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rl.ForeColor = System.Drawing.Color.White;
            this.Rl.Location = new System.Drawing.Point(300, 334);
            this.Rl.Name = "Rl";
            this.Rl.Size = new System.Drawing.Size(60, 18);
            this.Rl.TabIndex = 4;
            this.Rl.Text = "Restart";
            this.Rl.Enter += new System.EventHandler(this.R_MouseEnter);
            this.Rl.Leave += new System.EventHandler(this.R_MouseLeave);
            this.Rl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.R_MouseDown);
            this.Rl.MouseEnter += new System.EventHandler(this.R_MouseEnter);
            this.Rl.MouseLeave += new System.EventHandler(this.R_MouseLeave);
            this.Rl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // Hl
            // 
            this.Hl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Hl.AutoSize = true;
            this.Hl.BackColor = System.Drawing.Color.Transparent;
            this.Hl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hl.ForeColor = System.Drawing.Color.White;
            this.Hl.Location = new System.Drawing.Point(479, 334);
            this.Hl.Name = "Hl";
            this.Hl.Size = new System.Drawing.Size(78, 18);
            this.Hl.TabIndex = 5;
            this.Hl.Text = "Hibernate";
            this.Hl.Enter += new System.EventHandler(this.H_MouseEnter);
            this.Hl.Leave += new System.EventHandler(this.H_MouseLeave);
            this.Hl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hl_MouseDown);
            this.Hl.MouseEnter += new System.EventHandler(this.H_MouseEnter);
            this.Hl.MouseLeave += new System.EventHandler(this.H_MouseLeave);
            this.Hl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // SBl
            // 
            this.SBl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SBl.AutoSize = true;
            this.SBl.BackColor = System.Drawing.Color.Transparent;
            this.SBl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBl.ForeColor = System.Drawing.Color.White;
            this.SBl.Location = new System.Drawing.Point(676, 334);
            this.SBl.Name = "SBl";
            this.SBl.Size = new System.Drawing.Size(65, 18);
            this.SBl.TabIndex = 6;
            this.SBl.Text = "Standby";
            this.SBl.Enter += new System.EventHandler(this.SB_MouseEnter);
            this.SBl.Leave += new System.EventHandler(this.SB_MouseLeave);
            this.SBl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SBl_MouseDown);
            this.SBl.MouseEnter += new System.EventHandler(this.SB_MouseEnter);
            this.SBl.MouseLeave += new System.EventHandler(this.SB_MouseLeave);
            this.SBl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // Ll
            // 
            this.Ll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ll.AutoSize = true;
            this.Ll.BackColor = System.Drawing.Color.Transparent;
            this.Ll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ll.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ll.ForeColor = System.Drawing.Color.White;
            this.Ll.Location = new System.Drawing.Point(211, 554);
            this.Ll.Name = "Ll";
            this.Ll.Size = new System.Drawing.Size(42, 18);
            this.Ll.TabIndex = 7;
            this.Ll.Text = "Lock";
            this.Ll.Enter += new System.EventHandler(this.L_MouseEnter);
            this.Ll.Leave += new System.EventHandler(this.L_MouseLeave);
            this.Ll.MouseEnter += new System.EventHandler(this.L_MouseEnter);
            this.Ll.MouseLeave += new System.EventHandler(this.L_MouseLeave);
            // 
            // LOl
            // 
            this.LOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LOl.AutoSize = true;
            this.LOl.BackColor = System.Drawing.Color.Transparent;
            this.LOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOl.ForeColor = System.Drawing.Color.White;
            this.LOl.Location = new System.Drawing.Point(394, 554);
            this.LOl.Name = "LOl";
            this.LOl.Size = new System.Drawing.Size(61, 18);
            this.LOl.TabIndex = 8;
            this.LOl.Text = "Log Off";
            this.LOl.Enter += new System.EventHandler(this.LO_MouseEnter);
            this.LOl.Leave += new System.EventHandler(this.LO_MouseLeave);
            this.LOl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LO_MouseDown);
            this.LOl.MouseEnter += new System.EventHandler(this.LO_MouseEnter);
            this.LOl.MouseLeave += new System.EventHandler(this.LO_MouseLeave);
            this.LOl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // SOl
            // 
            this.SOl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SOl.AutoSize = true;
            this.SOl.BackColor = System.Drawing.Color.Transparent;
            this.SOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SOl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOl.ForeColor = System.Drawing.Color.White;
            this.SOl.Location = new System.Drawing.Point(571, 554);
            this.SOl.Name = "SOl";
            this.SOl.Size = new System.Drawing.Size(85, 18);
            this.SOl.TabIndex = 9;
            this.SOl.Text = "Screen Off";
            this.SOl.Enter += new System.EventHandler(this.SO_MouseEnter);
            this.SOl.Leave += new System.EventHandler(this.SO_MouseLeave);
            this.SOl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO_MouseDown);
            this.SOl.MouseEnter += new System.EventHandler(this.SO_MouseEnter);
            this.SOl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Arial", 10F);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(625, 95);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(210, 16);
            this.date.TabIndex = 0;
            this.date.Text = "Wednesday, 08 November 2014";
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(564, 56);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(175, 33);
            this.time.TabIndex = 24;
            this.time.Text = "12:59:59 AM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "© RoshSoft Co.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(-8, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 1);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(746, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "V. 7. 15. 09. 26";
            this.label2.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SDb
            // 
            this.SDb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SDb.Location = new System.Drawing.Point(228, 598);
            this.SDb.Name = "SDb";
            this.SDb.Size = new System.Drawing.Size(60, 20);
            this.SDb.TabIndex = 1;
            this.SDb.Text = "Shutdown";
            this.SDb.UseVisualStyleBackColor = true;
            this.SDb.Click += new System.EventHandler(this.SDb_Click);
            this.SDb.Enter += new System.EventHandler(this.SD_MouseEnter);
            this.SDb.Leave += new System.EventHandler(this.SD_MouseLeave);
            // 
            // Rb
            // 
            this.Rb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Rb.Location = new System.Drawing.Point(294, 598);
            this.Rb.Name = "Rb";
            this.Rb.Size = new System.Drawing.Size(60, 20);
            this.Rb.TabIndex = 2;
            this.Rb.Text = "Restart";
            this.Rb.UseVisualStyleBackColor = true;
            this.Rb.Click += new System.EventHandler(this.Rb_Click);
            this.Rb.Enter += new System.EventHandler(this.R_MouseEnter);
            this.Rb.Leave += new System.EventHandler(this.R_MouseLeave);
            // 
            // Hb
            // 
            this.Hb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Hb.Location = new System.Drawing.Point(360, 598);
            this.Hb.Name = "Hb";
            this.Hb.Size = new System.Drawing.Size(60, 20);
            this.Hb.TabIndex = 3;
            this.Hb.Text = "Hibernate";
            this.Hb.UseVisualStyleBackColor = true;
            this.Hb.Click += new System.EventHandler(this.Hb_Click);
            this.Hb.Enter += new System.EventHandler(this.H_MouseEnter);
            this.Hb.Leave += new System.EventHandler(this.H_MouseLeave);
            // 
            // SBb
            // 
            this.SBb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SBb.Location = new System.Drawing.Point(426, 598);
            this.SBb.Name = "SBb";
            this.SBb.Size = new System.Drawing.Size(60, 20);
            this.SBb.TabIndex = 4;
            this.SBb.Text = "Standby";
            this.SBb.UseVisualStyleBackColor = true;
            this.SBb.Click += new System.EventHandler(this.SBb_Click);
            this.SBb.Enter += new System.EventHandler(this.SB_MouseEnter);
            this.SBb.Leave += new System.EventHandler(this.SB_MouseLeave);
            // 
            // Lb
            // 
            this.Lb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lb.Location = new System.Drawing.Point(492, 598);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(60, 20);
            this.Lb.TabIndex = 5;
            this.Lb.Text = "Lock";
            this.Lb.UseVisualStyleBackColor = true;
            this.Lb.Click += new System.EventHandler(this.Lb_Click);
            this.Lb.Enter += new System.EventHandler(this.L_MouseEnter);
            this.Lb.Leave += new System.EventHandler(this.L_MouseLeave);
            // 
            // LOb
            // 
            this.LOb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LOb.Location = new System.Drawing.Point(558, 598);
            this.LOb.Name = "LOb";
            this.LOb.Size = new System.Drawing.Size(60, 20);
            this.LOb.TabIndex = 6;
            this.LOb.Text = "Logoff";
            this.LOb.UseVisualStyleBackColor = true;
            this.LOb.Click += new System.EventHandler(this.LOb_Click);
            this.LOb.Enter += new System.EventHandler(this.LO_MouseEnter);
            this.LOb.Leave += new System.EventHandler(this.LO_MouseLeave);
            // 
            // SOb
            // 
            this.SOb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SOb.Location = new System.Drawing.Point(624, 598);
            this.SOb.Name = "SOb";
            this.SOb.Size = new System.Drawing.Size(60, 20);
            this.SOb.TabIndex = 7;
            this.SOb.Text = "Screen Off";
            this.SOb.UseVisualStyleBackColor = true;
            this.SOb.Click += new System.EventHandler(this.SOb_Click);
            this.SOb.Enter += new System.EventHandler(this.SO_MouseEnter);
            this.SOb.Leave += new System.EventHandler(this.SO_MouseLeave);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.Location = new System.Drawing.Point(162, 598);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 20);
            this.button8.TabIndex = 0;
            this.button8.Text = "None";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(133, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 24);
            this.panel2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 44);
            this.label3.TabIndex = 31;
            this.label3.Text = "Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "V. 7. 15. 09. 26";
            // 
            // SB
            // 
            this.SB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SB.AutoSize = true;
            this.SB.BackColor = System.Drawing.Color.Transparent;
            this.SB.BackgroundImage = global::Power.Properties.Resources.SB;
            this.SB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SB.Location = new System.Drawing.Point(618, 151);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(180, 180);
            this.SB.TabIndex = 4;
            this.SB.Enter += new System.EventHandler(this.SB_MouseEnter);
            this.SB.Leave += new System.EventHandler(this.SB_MouseLeave);
            this.SB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SBl_MouseDown);
            this.SB.MouseEnter += new System.EventHandler(this.SB_MouseEnter);
            this.SB.MouseLeave += new System.EventHandler(this.SB_MouseLeave);
            this.SB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(23, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 30;
            // 
            // H
            // 
            this.H.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.H.AutoSize = true;
            this.H.BackColor = System.Drawing.Color.Transparent;
            this.H.BackgroundImage = global::Power.Properties.Resources.Hn;
            this.H.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.H.Cursor = System.Windows.Forms.Cursors.Hand;
            this.H.Location = new System.Drawing.Point(429, 151);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(180, 180);
            this.H.TabIndex = 3;
            this.H.Enter += new System.EventHandler(this.H_MouseEnter);
            this.H.Leave += new System.EventHandler(this.H_MouseLeave);
            this.H.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hl_MouseDown);
            this.H.MouseEnter += new System.EventHandler(this.H_MouseEnter);
            this.H.MouseLeave += new System.EventHandler(this.H_MouseLeave);
            this.H.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // L
            // 
            this.L.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L.AutoSize = true;
            this.L.BackColor = System.Drawing.Color.Transparent;
            this.L.BackgroundImage = global::Power.Properties.Resources.L;
            this.L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L.Location = new System.Drawing.Point(143, 371);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(180, 180);
            this.L.TabIndex = 5;
            this.L.Enter += new System.EventHandler(this.L_MouseEnter);
            this.L.MouseDown += new System.Windows.Forms.MouseEventHandler(this.L_MouseDown);
            this.L.MouseEnter += new System.EventHandler(this.L_MouseEnter);
            this.L.MouseLeave += new System.EventHandler(this.L_MouseLeave);
            this.L.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // LO
            // 
            this.LO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LO.AutoSize = true;
            this.LO.BackColor = System.Drawing.Color.Transparent;
            this.LO.BackgroundImage = global::Power.Properties.Resources.LO;
            this.LO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LO.Location = new System.Drawing.Point(332, 371);
            this.LO.Name = "LO";
            this.LO.Size = new System.Drawing.Size(180, 180);
            this.LO.TabIndex = 6;
            this.LO.Enter += new System.EventHandler(this.LO_MouseEnter);
            this.LO.Leave += new System.EventHandler(this.LO_MouseLeave);
            this.LO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LO_MouseDown);
            this.LO.MouseEnter += new System.EventHandler(this.LO_MouseEnter);
            this.LO.MouseLeave += new System.EventHandler(this.LO_MouseLeave);
            this.LO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // SO
            // 
            this.SO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SO.AutoSize = true;
            this.SO.BackColor = System.Drawing.Color.Transparent;
            this.SO.BackgroundImage = global::Power.Properties.Resources.SO;
            this.SO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SO.Location = new System.Drawing.Point(521, 371);
            this.SO.Name = "SO";
            this.SO.Size = new System.Drawing.Size(180, 180);
            this.SO.TabIndex = 7;
            this.SO.Leave += new System.EventHandler(this.SO_MouseLeave);
            this.SO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO_MouseDown);
            this.SO.MouseEnter += new System.EventHandler(this.SO_MouseEnter);
            this.SO.MouseLeave += new System.EventHandler(this.SO_MouseLeave);
            this.SO.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // R
            // 
            this.R.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.R.AutoSize = true;
            this.R.BackColor = System.Drawing.Color.Transparent;
            this.R.BackgroundImage = global::Power.Properties.Resources.R;
            this.R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R.Location = new System.Drawing.Point(240, 151);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(180, 180);
            this.R.TabIndex = 2;
            this.R.Enter += new System.EventHandler(this.R_MouseEnter);
            this.R.Leave += new System.EventHandler(this.R_MouseLeave);
            this.R.MouseDown += new System.Windows.Forms.MouseEventHandler(this.R_MouseDown);
            this.R.MouseEnter += new System.EventHandler(this.R_MouseEnter);
            this.R.MouseLeave += new System.EventHandler(this.R_MouseLeave);
            this.R.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // SD
            // 
            this.SD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SD.AutoSize = true;
            this.SD.BackColor = System.Drawing.Color.Transparent;
            this.SD.BackgroundImage = global::Power.Properties.Resources.S;
            this.SD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SD.Location = new System.Drawing.Point(51, 151);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(180, 180);
            this.SD.TabIndex = 1;
            this.SD.Enter += new System.EventHandler(this.SD_MouseEnter);
            this.SD.Leave += new System.EventHandler(this.SD_MouseLeave);
            this.SD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SD_MouseDown);
            this.SD.MouseEnter += new System.EventHandler(this.SD_MouseEnter);
            this.SD.MouseLeave += new System.EventHandler(this.SD_MouseLeave);
            this.SD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Power.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 622);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LOb);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.SDb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SOb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hb);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Lb);
            this.Controls.Add(this.time);
            this.Controls.Add(this.SBb);
            this.Controls.Add(this.SOl);
            this.Controls.Add(this.LOl);
            this.Controls.Add(this.Ll);
            this.Controls.Add(this.SBl);
            this.Controls.Add(this.Hl);
            this.Controls.Add(this.Rl);
            this.Controls.Add(this.SDl);
            this.Controls.Add(this.H);
            this.Controls.Add(this.L);
            this.Controls.Add(this.LO);
            this.Controls.Add(this.SO);
            this.Controls.Add(this.R);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel SD;
        private System.Windows.Forms.Panel R;
        private System.Windows.Forms.Panel H;
        private System.Windows.Forms.Panel SB;
        private System.Windows.Forms.Panel L;
        private System.Windows.Forms.Panel LO;
        private System.Windows.Forms.Panel SO;
        private System.Windows.Forms.Label SDl;
        private System.Windows.Forms.Label Rl;
        private System.Windows.Forms.Label Hl;
        private System.Windows.Forms.Label SBl;
        private System.Windows.Forms.Label Ll;
        private System.Windows.Forms.Label LOl;
        private System.Windows.Forms.Label SOl;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SDb;
        private System.Windows.Forms.Button Rb;
        private System.Windows.Forms.Button Hb;
        private System.Windows.Forms.Button SBb;
        private System.Windows.Forms.Button Lb;
        private System.Windows.Forms.Button LOb;
        private System.Windows.Forms.Button SOb;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem prefencesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportBugsRequestHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

