namespace ConsumerSurvey
{
    partial class Addsurvey
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
            this.txtSurveyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.cmdCreateSurvey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Survey Name";
            // 
            // txtSurveyName
            // 
            this.txtSurveyName.Location = new System.Drawing.Point(72, 154);
            this.txtSurveyName.Multiline = true;
            this.txtSurveyName.Name = "txtSurveyName";
            this.txtSurveyName.Size = new System.Drawing.Size(199, 34);
            this.txtSurveyName.TabIndex = 1;
            this.txtSurveyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(72, 248);
            this.txtDateAdded.Multiline = true;
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(199, 34);
            this.txtDateAdded.TabIndex = 3;
            this.txtDateAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdCreateSurvey
            // 
            this.cmdCreateSurvey.Location = new System.Drawing.Point(118, 312);
            this.cmdCreateSurvey.Name = "cmdCreateSurvey";
            this.cmdCreateSurvey.Size = new System.Drawing.Size(106, 36);
            this.cmdCreateSurvey.TabIndex = 4;
            this.cmdCreateSurvey.Text = "Create";
            this.cmdCreateSurvey.UseVisualStyleBackColor = true;
            this.cmdCreateSurvey.Click += new System.EventHandler(this.CmdCreateSurvey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create a Survey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DD/MM/YY";
            // 
            // Addsurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdCreateSurvey);
            this.Controls.Add(this.txtDateAdded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurveyName);
            this.Controls.Add(this.label1);
            this.Name = "Addsurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addsurvey";
            this.Load += new System.EventHandler(this.Addsurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurveyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.Button cmdCreateSurvey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}