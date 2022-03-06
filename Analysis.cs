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
    public partial class Analysis : Form
    {
        administrator admin = new administrator();
        public Analysis()
        {
            InitializeComponent();
        }

        private void CmdViewData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = admin.GetRespondentsData();
        }
    }
}
