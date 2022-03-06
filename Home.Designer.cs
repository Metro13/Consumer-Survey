namespace ConsumerSurvey
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdParticipate = new System.Windows.Forms.Button();
            this.cmdAdministrator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(67, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer Survey";
            // 
            // cmdParticipate
            // 
            this.cmdParticipate.Location = new System.Drawing.Point(92, 210);
            this.cmdParticipate.Name = "cmdParticipate";
            this.cmdParticipate.Size = new System.Drawing.Size(180, 40);
            this.cmdParticipate.TabIndex = 1;
            this.cmdParticipate.Text = "Participate";
            this.cmdParticipate.UseVisualStyleBackColor = true;
            this.cmdParticipate.Click += new System.EventHandler(this.CmdParticipate_Click);
            // 
            // cmdAdministrator
            // 
            this.cmdAdministrator.Location = new System.Drawing.Point(130, 286);
            this.cmdAdministrator.Name = "cmdAdministrator";
            this.cmdAdministrator.Size = new System.Drawing.Size(104, 32);
            this.cmdAdministrator.TabIndex = 2;
            this.cmdAdministrator.Text = "Administrator";
            this.cmdAdministrator.UseVisualStyleBackColor = true;
            this.cmdAdministrator.Click += new System.EventHandler(this.CmdAdministrator_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 439);
            this.Controls.Add(this.cmdAdministrator);
            this.Controls.Add(this.cmdParticipate);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdParticipate;
        private System.Windows.Forms.Button cmdAdministrator;
    }
}