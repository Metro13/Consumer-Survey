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
    public partial class AdminSurveyPage : Form
    {
        string s;
        public AdminSurveyPage()
        {
            InitializeComponent();
        }

        private void CmdAddSurvey_Click(object sender, EventArgs e)
        {
            Addsurvey add = new Addsurvey(s);
            add.Show();
            this.Hide();
        }

        private void CmdAnalyze_Click(object sender, EventArgs e)
        {
            Analysis analysze = new Analysis();
            analysze.Show();
            this.Hide();
        }
    }
}
