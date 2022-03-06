using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumerSurvey
{
    public partial class QuestionPage : Form
    {
        administrator admin = new administrator();
        Survey newSurvey = new Survey();
        int id;
        string response;
        public QuestionPage(string sName)
        {
            InitializeComponent();
            TxtSurveyName.Text = sName;
        }

        private void QuestionPage_Load(object sender, EventArgs e)
        {
           id = int.Parse(admin.getSurveyID(TxtSurveyName.Text));
        }

        private void CmdAddQuestion_Click(object sender, EventArgs e)
        {
            newSurvey.Question = txtSurveyQuestion.Text;
            newSurvey.QuestionType = cmbQuestionType.SelectedItem.ToString();

            if (newSurvey.Question != null && newSurvey.QuestionType != null)
            {
                admin.addSurveyQuestions(id, newSurvey.Question, newSurvey.QuestionType, response);
                MessageBox.Show("Survey Question Added Successfully");
            }
        }
    }
}
