using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;

namespace ConsumerSurvey
{
    public partial class UserSurveyPage : Form
    {

        Survey sv = new Survey();
        public UserSurveyPage(string name)
        {
            InitializeComponent();
          
        }

        private void UserSurveyPage_Load(object sender, EventArgs e)
        {
            var surv = Survey.getSurvey();
             foreach(var survname in surv)
             {
                comboBox1.Items.Add(survname);
             }      
            
        }
        private void CmdStart_Click(object sender, EventArgs e)
        {


            sv.SurveyName = comboBox1.SelectedItem.ToString();

            if(sv.SurveyName != null)
            {
                Main frm = new Main(sv.SurveyName);
                frm.Show();
                this.Hide();

            }
        }
    }
}
