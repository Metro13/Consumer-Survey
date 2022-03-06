namespace ConsumerSurvey
{
    partial class QuestionPage
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
            this.txtSurveyQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuestionType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAddQuestion = new System.Windows.Forms.Button();
            this.TxtSurveyName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepare Survey Questions";
            // 
            // txtSurveyQuestion
            // 
            this.txtSurveyQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurveyQuestion.Location = new System.Drawing.Point(104, 138);
            this.txtSurveyQuestion.Multiline = true;
            this.txtSurveyQuestion.Name = "txtSurveyQuestion";
            this.txtSurveyQuestion.Size = new System.Drawing.Size(254, 115);
            this.txtSurveyQuestion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // cmbQuestionType
            // 
            this.cmbQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuestionType.FormattingEnabled = true;
            this.cmbQuestionType.Items.AddRange(new object[] {
            "Yes Or No",
            "5-Point Likert Scale",
            "Rating Scale"});
            this.cmbQuestionType.Location = new System.Drawing.Point(141, 301);
            this.cmbQuestionType.Name = "cmbQuestionType";
            this.cmbQuestionType.Size = new System.Drawing.Size(180, 23);
            this.cmbQuestionType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Question Type";
            // 
            // cmdAddQuestion
            // 
            this.cmdAddQuestion.Location = new System.Drawing.Point(167, 390);
            this.cmdAddQuestion.Name = "cmdAddQuestion";
            this.cmdAddQuestion.Size = new System.Drawing.Size(129, 38);
            this.cmdAddQuestion.TabIndex = 5;
            this.cmdAddQuestion.Text = "Add Question";
            this.cmdAddQuestion.UseVisualStyleBackColor = true;
            this.cmdAddQuestion.Click += new System.EventHandler(this.CmdAddQuestion_Click);
            // 
            // TxtSurveyName
            // 
            this.TxtSurveyName.AutoSize = true;
            this.TxtSurveyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurveyName.Location = new System.Drawing.Point(180, 61);
            this.TxtSurveyName.Name = "TxtSurveyName";
            this.TxtSurveyName.Size = new System.Drawing.Size(101, 16);
            this.TxtSurveyName.TabIndex = 6;
            this.TxtSurveyName.Text = "Survey Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(59, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add questions in the order of the question type in the drop down";
            // 
            // QuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSurveyName);
            this.Controls.Add(this.cmdAddQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbQuestionType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurveyQuestion);
            this.Controls.Add(this.label1);
            this.Name = "QuestionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionPage";
            this.Load += new System.EventHandler(this.QuestionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurveyQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQuestionType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAddQuestion;
        private System.Windows.Forms.Label TxtSurveyName;
        private System.Windows.Forms.Label label4;
    }
}