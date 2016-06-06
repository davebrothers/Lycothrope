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
            this.SuspendLayout();
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Location = new System.Drawing.Point(12, 58);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(135, 41);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.Text = "Begin &Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            // 
            // btnLongBreak
            // 
            this.btnLongBreak.Location = new System.Drawing.Point(12, 152);
            this.btnLongBreak.Name = "btnLongBreak";
            this.btnLongBreak.Size = new System.Drawing.Size(135, 41);
            this.btnLongBreak.TabIndex = 1;
            this.btnLongBreak.Text = "Begin &Long Break";
            this.btnLongBreak.UseVisualStyleBackColor = true;
            // 
            // btnShortBreak
            // 
            this.btnShortBreak.Location = new System.Drawing.Point(12, 105);
            this.btnShortBreak.Name = "btnShortBreak";
            this.btnShortBreak.Size = new System.Drawing.Size(135, 41);
            this.btnShortBreak.TabIndex = 2;
            this.btnShortBreak.Text = "Begin &Short Break";
            this.btnShortBreak.UseVisualStyleBackColor = true;
            // 
            // Lycothrope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 265);
            this.Controls.Add(this.btnShortBreak);
            this.Controls.Add(this.btnLongBreak);
            this.Controls.Add(this.btnPomodoro);
            this.Name = "Lycothrope";
            this.Text = "Lycothrope";
            this.Load += new System.EventHandler(this.Lycothrope_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnLongBreak;
        private System.Windows.Forms.Button btnShortBreak;
    }
}