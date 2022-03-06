namespace ConsumerSurvey
{
    partial class AdminSurveyPage
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
            this.cmdAnalyze = new System.Windows.Forms.Button();
            this.CmdAddSurvey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAnalyze
            // 
            this.cmdAnalyze.Location = new System.Drawing.Point(125, 217);
            this.cmdAnalyze.Name = "cmdAnalyze";
            this.cmdAnalyze.Size = new System.Drawing.Size(132, 36);
            this.cmdAnalyze.TabIndex = 0;
            this.cmdAnalyze.Text = "Analyze Survey";
            this.cmdAnalyze.UseVisualStyleBackColor = true;
            this.cmdAnalyze.Click += new System.EventHandler(this.CmdAnalyze_Click);
            // 
            // CmdAddSurvey
            // 
            this.CmdAddSurvey.Location = new System.Drawing.Point(125, 137);
            this.CmdAddSurvey.Name = "CmdAddSurvey";
            this.CmdAddSurvey.Size = new System.Drawing.Size(132, 36);
            this.CmdAddSurvey.TabIndex = 1;
            this.CmdAddSurvey.Text = "Add Survey";
            this.CmdAddSurvey.UseVisualStyleBackColor = true;
            this.CmdAddSurvey.Click += new System.EventHandler(this.CmdAddSurvey_Click);
            // 
            // AdminSurveyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 388);
            this.Controls.Add(this.CmdAddSurvey);
            this.Controls.Add(this.cmdAnalyze);
            this.Name = "AdminSurveyPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSurveyPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAnalyze;
        private System.Windows.Forms.Button CmdAddSurvey;
    }
}