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
    public partial class RegistrationPanel : Form
    {
        public RegistrationPanel()
        {
            InitializeComponent();
        }


        private void btnStudent_Click(object sender, EventArgs e)
        {
            new StudentRegistration().Show();
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            new TeacherRegistration().Show();
            this.Hide();
        }

        private void btnCourseCreation_Click(object sender, EventArgs e)
        {
            new Course().Show();
            this.Hide();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            new Assign().Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
