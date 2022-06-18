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
    public partial class Assign : Form
    {
        public Assign()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            new StudentAssign().Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            new TeacherAssign().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new RegistrationPanel().Show();
            this.Hide();
        }
    }
}
