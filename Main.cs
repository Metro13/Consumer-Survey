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
    public partial class Main : Form
    {
      
        administrator admin = new administrator();
        Survey sv = new Survey();
        Consumer cs = new Consumer();
        int id,RetID;
        int newId =1;
        int numrows;
        int counter = 0;
      
        string[] types;
        
      
        public Main(string name)
        {
            InitializeComponent();
            LblSurveyName.Text = name;
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
             id = int.Parse(admin.getSurveyID(LblSurveyName.Text));

             RetID = int.Parse(sv.GetQuestionId(id));

            types = new string[3];
            types[0] = "Yes or No";
            types[1] = "Rating Scale";
            types[2] = "5-Point Likert Scale";

            LblQtype.Text = types[0];
            panelRating.Visible = false;
            PanelLikert.Hide();
          
            numrows = int.Parse(sv.Num_rows(id));
            lblHelp.Hide();
            LnkExit.Hide();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            LblDisplayQustioon.Text = sv.GetQuestions(id, RetID);
            Increment();
            cmdStart.Text = "Next";
            if (counter == 7)
            {
                label16.Hide();
                LblQtype.Text = types[1];
                panelRating.Visible = true;
                LblAnswerField.Visible = false;
                cmdSubmit.Visible = false;
            }
            if (counter == 13)
            {
                PanelLikert.Show();
                LblQtype.Text = types[2];
                panelRating.Visible = true;
                cmdSubmit.Visible = true;
                LblAnswerField.Visible = false;
            }
            
            if (counter > numrows + 1)
            {
                MessageBox.Show("Thanks for the Feedback!! \nYou sucessfully Finished the Survey...");
            }

        }

        private void Increment()
        {
            newId = RetID++;
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
           

            if (radYes.Checked.Equals(true))
            {
                sv.Response = "Yes";
                
            }
            if (radNo.Checked.Equals(true))
            {
                sv.Response = "No";
            }
            if (RadSdis.Checked.Equals(true))
            {
                sv.Response = "Strongly Disagree";
            }
            if (RadDis.Checked.Equals(true))
            {
                sv.Response = "Disagree";
            }
            if (RadNeut.Checked.Equals(true))
            {
                sv.Response = "Neutral";
            }
            if (RadAgg.Checked.Equals(true))
            {
                sv.Response = "Agree";
            }
            if (RadStAgg.Checked.Equals(true))
            {
                sv.Response = "Strongly Agree";
             
            }
               
               cs.SurveyReply(id, newId, sv.Response);
           
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            sv.Response = 3.ToString();
            cs.SurveyReply(id, newId, sv.Response);

        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            sv.Response = 4.ToString();
            cs.SurveyReply(id, newId, sv.Response);

        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            sv.Response = 5.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            sv.Response = 6.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            sv.Response = 7.ToString();
            cs.SurveyReply(id, newId, sv.Response);

        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            sv.Response = 8.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            sv.Response = 9.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd10_Click(object sender, EventArgs e)
        {
            sv.Response = 10.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            sv.Response = 2.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            sv.Response = 1.ToString();
            cs.SurveyReply(id, newId, sv.Response);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblHelp.Show();
            LnkExit.Show();

        }

        private void LnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblHelp.Hide();
            LnkExit.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Cmd0_Click(object sender, EventArgs e)
        {
            sv.Response = 0.ToString();
        }

    }
}
