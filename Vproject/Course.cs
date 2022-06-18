using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vproject
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;


        void coursegetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From CourseCreation", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new RegistrationPanel().Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True");
            string add = "INSERT INTO CourseCreation(CourseID, CourseName, Fee, CourseStartDate, CourseFinishDate) VALUES (@CourseId, @CourseName, @Fee, @CourseStartDate, @CourseFinishDate)";
            komut = new SqlCommand(add, baglanti);
            komut.Parameters.AddWithValue("@CourseId", txtBxId.Text);
            komut.Parameters.AddWithValue("@CourseName", txtBxCourse.Text);
            komut.Parameters.AddWithValue("@Fee", txtBxFee.Text);
            komut.Parameters.AddWithValue("@CourseStartDate", dtTimeStart.Value);
            komut.Parameters.AddWithValue("@CourseFinishDate", dtTimeFinish.Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            coursegetir();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi");

        }

        private void Course2_Load(object sender, EventArgs e)
        {

            coursegetir();

            
        }
    }
}
