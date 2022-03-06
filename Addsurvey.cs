using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ConsumerSurvey
{
    public partial class Addsurvey : Form
    {
        Survey newSurvey = new Survey();
        administrator admin = new administrator();
        public Addsurvey(string Sname)
        {
            InitializeComponent();
        }

        private void CmdCreateSurvey_Click(object sender, EventArgs e)
        {

            newSurvey.SurveyName = txtSurveyName.Text;
            newSurvey.Date = txtDateAdded.Text;

            if(newSurvey.SurveyName != null && newSurvey.Date != null)
            {
                admin.AddSurvey(newSurvey.SurveyName,newSurvey.Date);

                MessageBox.Show("Survey Created Successfully \nClick Ok to Proceed and Add Survey Questions");
                QuestionPage QPage = new QuestionPage(newSurvey.SurveyName);
                QPage.Show();
                this.Hide();
            }
        }

        private void Addsurvey_Load(object sender, EventArgs e)
        {

        }
    }
}
