using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vproject
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnStuOperations_Click(object sender, EventArgs e)
        {
            new StuOperations().Show();
            this.Hide();
        }

        private void btnTeaOperations_Click(object sender, EventArgs e)
        {
            new TeaOperations().Show();
            this.Hide();
        }

        private void btnCouOperations_Click(object sender, EventArgs e)
        {
            new CouOperations().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new RegistrationPanel().Show();
            this.Hide();
        }
    }
}
