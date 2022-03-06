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
    public partial class Form1 : Form
    {
        Consumer cons = new Consumer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void CmdRegister_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    // setting Textbox Values
                    // associating with Acessor Functions from class Consumer
                    cons.Username = TxtUsername.Text;
                    cons.Firstname = TxtFirstname.Text;
                    cons.Lastname = TxtLastname.Text;
                    cons.Age = Int32.Parse(TxtAge.Text);
                    cons.Gender = CmbGender.SelectedItem.ToString();
                    cons.Password = TxtPassword.Text;
                    

                    cons.AddConsumer();

                    MessageBox.Show("Successfully Registered");
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Age Field with an Integer");
                }
               
            }
            catch(SQLiteException )
            {
                MessageBox.Show("Username Already Available, Please choose a different Username");
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please Fill in All Fields");
            }
            
            

        }
    }
}
