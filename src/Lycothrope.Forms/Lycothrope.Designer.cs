namespace Lycothrope.Forms
{
    partial class Lycothrope
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
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnLongBreak = new System.Windows.Forms.Button();
            this.btnShortBreak = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTomatoTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Location = new System.Drawing.Point(12, 28);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(135, 41);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "Begin &Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Location = new System.Drawing.Point(12, 122);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(135, 41);
            this.btnLongBreak.TabIndex = 1;
            this.btnLongBreak.Text = "Begin &Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = true;
            this.btnLongBreak.Click += new System.EventHandler(this.btnLongBreak_Click);
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Location = new System.Drawing.Point(12, 75);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(135, 41);
            this.btnShortBreak.TabIndex = 2;
            this.btnShortBreak.Text = "Begin &Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = true;
            this.btnShortBreak.Click += new System.EventHandler(this.btnShortBreak_Click);
            // 
            // tbTimer
            // 
            this.tbTimer.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.tbTimer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTimer.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.Location = new System.Drawing.Point(185, 54);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.ReadOnly = true;
            this.tbTimer.Size = new System.Drawing.Size(179, 49);
            this.tbTimer.TabIndex = 1;
            this.tbTimer.TabStop = false;
            this.tbTimer.Text = "00:00";
            this.tbTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 169);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 41);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "&Stop Pomodoro";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(409, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Hello!";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(409, 24);
            this.menuStrip.TabIndex = 6;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTomatoTimesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // changeTomatoTimesToolStripMenuItem
            // 
            this.changeTomatoTimesToolStripMenuItem.Name = "changeTomatoTimesToolStripMenuItem";
            this.changeTomatoTimesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.changeTomatoTimesToolStripMenuItem.Text = "&Change tomato times";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Lycothrope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 242);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnPomodoro);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Lycothrope";
            this.Text = "Lycothrope";
            this.Load += new System.EventHandler(this.Lycothrope_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Button btnShortBreak;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTomatoTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}