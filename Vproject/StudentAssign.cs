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
    public partial class StudentAssign : Form
    {
       
        public StudentAssign()

        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Assign().Show();
            this.Hide();
        }

        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;


        void gridgetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From StudentRegistration", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dtGridAssign.DataSource = tablo;
            baglanti.Close();
        }

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

        private void btnAssign_Click(object sender, EventArgs e)
        {

            if (cmBxCourse.Text == "" || cmBxStudent.Text == "")
            {

                MessageBox.Show("Lütfen verdiğiniz değerleri kontrol ediniz");
            }

            else
            {
                baglanti.Open();
                string add = "INSERT INTO Stu_Assign(StudentId, StudentName, CourseName, Fee) VALUES (@StudentId, @StudentName, @CourseName, @Fee)";
                komut = new SqlCommand(add, baglanti);
                komut.Parameters.AddWithValue("@StudentId", cmBxId.Text);
                komut.Parameters.AddWithValue("@StudentName", cmBxStudent.Text);
                komut.Parameters.AddWithValue("@CourseName", cmBxCourse.Text);
                komut.Parameters.AddWithValue("@Fee", cmBxCoursePrice.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi");

            }
 
            
        }

        private void StudentAssign_Load(object sender, EventArgs e)
        {
            gridgetir();
            coursegetir();

            {

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True";
                baglanti.Open();

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM StudentRegistration";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmBxStudent.Items.Add(dr["StudentName"]);
                }
                baglanti.Close();


                komut.CommandText = "SELECT *FROM CourseCreation";
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmBxCourse.Items.Add(dr["CourseName"]);
                    cmBxCoursePrice.Items.Add(dr["Fee"]);
                }
                baglanti.Close();

               
            }


        }

        private void dtGridAssign_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmBxId.Text = dtGridAssign.CurrentRow.Cells[0].Value.ToString();
            cmBxStudent.Text = dtGridAssign.CurrentRow.Cells[1].Value.ToString();


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmBxCoursePrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmBxCourse.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}