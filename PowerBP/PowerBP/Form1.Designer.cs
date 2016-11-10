namespace PowerBP
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showCommandWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortthisCommandAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abortAllCommandsAndExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.typelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commandlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openPowerUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Power Background Process";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoCMS,
            this.TimeCMS,
            this.toolStripSeparator3,
            this.openPowerUIToolStripMenuItem,
            this.toolStripSeparator2,
            this.showCommandWindowToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutPowerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 176);
            this.contextMenuStrip1.Text = "PowerBP";
            // 
            // infoCMS
            // 
            this.infoCMS.Enabled = false;
            this.infoCMS.Name = "infoCMS";
            this.infoCMS.Size = new System.Drawing.Size(227, 22);
            this.infoCMS.Text = "Info";
            // 
            // TimeCMS
            // 
            this.TimeCMS.Enabled = false;
            this.TimeCMS.Name = "TimeCMS";
            this.TimeCMS.Size = new System.Drawing.Size(227, 22);
            this.TimeCMS.Text = "Time";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // showCommandWindowToolStripMenuItem
            // 
            this.showCommandWindowToolStripMenuItem.Name = "showCommandWindowToolStripMenuItem";
            this.showCommandWindowToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.showCommandWindowToolStripMenuItem.Text = "Show Status";
            this.showCommandWindowToolStripMenuItem.Click += new System.EventHandler(this.showCommandWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortthisCommandAndExitToolStripMenuItem,
            this.abortAllCommandsAndExitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.exitToolStripMenuItem.Text = "Abort command(s) and Exit";
            // 
            // abortthisCommandAndExitToolStripMenuItem
            // 
            this.abortthisCommandAndExitToolStripMenuItem.Name = "abortthisCommandAndExitToolStripMenuItem";
            this.abortthisCommandAndExitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.abortthisCommandAndExitToolStripMenuItem.Text = "Abort &this command and Exit";
            this.abortthisCommandAndExitToolStripMenuItem.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // abortAllCommandsAndExitToolStripMenuItem
            // 
            this.abortAllCommandsAndExitToolStripMenuItem.Name = "abortAllCommandsAndExitToolStripMenuItem";
            this.abortAllCommandsAndExitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.abortAllCommandsAndExitToolStripMenuItem.Text = "&Abort all commands";
            this.abortAllCommandsAndExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(16, 15);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Abort all commands";
            this.linkLabel1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type :";
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelbl.Location = new System.Drawing.Point(94, 13);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(35, 16);
            this.typelbl.TabIndex = 6;
            this.typelbl.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command :";
            // 
            // commandlbl
            // 
            this.commandlbl.AutoSize = true;
            this.commandlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandlbl.Location = new System.Drawing.Point(94, 37);
            this.commandlbl.Name = "commandlbl";
            this.commandlbl.Size = new System.Drawing.Size(67, 16);
            this.commandlbl.TabIndex = 8;
            this.commandlbl.Text = "Command";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(94, 61);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(151, 16);
            this.timelbl.TabIndex = 10;
            this.timelbl.Text = "1439 minutes Remaining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Time :";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(94, 85);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(197, 16);
            this.datelbl.TabIndex = 12;
            this.datelbl.Text = "Wednesday, 08 September 2015";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date :";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(254, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Ask me before executing the command";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer3
            // 
            this.timer3.Interval = 60000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(13, 140);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(177, 16);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Abort this command and Exit";
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(224, 6);
            // 
            // openPowerUIToolStripMenuItem
            // 
            this.openPowerUIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPowerUIToolStripMenuItem.Image = global::PowerBP.Properties.Resources.icon;
            this.openPowerUIToolStripMenuItem.Name = "openPowerUIToolStripMenuItem";
            this.openPowerUIToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openPowerUIToolStripMenuItem.Text = "Open Power User Interface";
            this.openPowerUIToolStripMenuItem.Click += new System.EventHandler(this.openPowerUIToolStripMenuItem_Click);
            // 
            // aboutPowerToolStripMenuItem
            // 
            this.aboutPowerToolStripMenuItem.Image = global::PowerBP.Properties.Resources.infoico;
            this.aboutPowerToolStripMenuItem.Name = "aboutPowerToolStripMenuItem";
            this.aboutPowerToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.aboutPowerToolStripMenuItem.Text = "About Power";
            this.aboutPowerToolStripMenuItem.Click += new System.EventHandler(this.aboutPowerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.linkLabel1;
            this.ClientSize = new System.Drawing.Size(314, 192);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commandlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 220);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Background Process";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openPowerUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCommandWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutPowerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label commandlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ToolStripMenuItem abortthisCommandAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abortAllCommandsAndExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoCMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TimeCMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

