using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ConsumerSurvey
{
    public partial class Login : Form
    {
        Consumer cons = new Consumer();
        int LogAttempt = 3;
        int ReturnedValue;
        int value;
        string s;
        System.Timers.Timer time;
        int hh, mm, ss;


        public Login()
        {
            InitializeComponent();
        }

       
        private void CmdRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
          
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            time.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            time = new System.Timers.Timer();
            time.Interval = 1000;

            time.Elapsed += onTimeEvent;

        }

        private void onTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ss += 1;
                if(ss == 60)
                {
                    ss = 0;
                    mm += 1;
                }
                if(mm == 60)
                {
                    mm = 0;
                    hh += 1;
                }

                TxtTime.Text = string.Format("{0}:{1}:{2}", hh.ToString().PadLeft(2, '0'), mm.ToString().PadLeft(2, '0'), ss.ToString().PadLeft(2, '0'));
               
            }));

           
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            // setting Textbox Values
            // associating with Acessor Functions from class Consumer
            cons.Username = txtUsername.Text;
            cons.Password = txtPassword.Text;

            ReturnedValue = cons.ConsumerLogin(value);
            

            if (ReturnedValue == 1)
            {
                MessageBox.Show("Credentials Matched, Login Successful");
                if (cons.Username == "Admin")
                {
                    AdminSurveyPage adminSurvey = new AdminSurveyPage();
                    adminSurvey.Show();
                    this.Hide();
                }
                else
                {

                    UserSurveyPage userSurvey = new UserSurveyPage(s);
                    userSurvey.Show();
                    this.Hide();
                }
            }
            if (ReturnedValue == 0)
            {
                LogAttempt = LogAttempt - 1;

                MessageBox.Show("Inccorrect Login Details Try Again \n" + "Attempts Left = " + LogAttempt);

                if (LogAttempt < 1)
                {
                    MessageBox.Show("Maximum Attempts Reached you Have been Temporarily Blocked from Logging in for 5 Minutes");
                    time.Start();
                    cmdSubmit.Visible = false;

                    if (time.Interval == 300000)
                    {
                        time.Stop();
                        cmdSubmit.Visible = true;
                        LogAttempt = 3;
                        time.Dispose();
                    }

                }

            }
        }

    }
}
