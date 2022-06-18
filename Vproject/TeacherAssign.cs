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
    public partial class TeacherAssign : Form
    {
        public TeacherAssign()
        {
            InitializeComponent();
        }


        SqlConnection baglanti;
        SqlDataAdapter da;
        SqlCommand komut;


        void gridgetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From TeacherRegistration", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dtGridAssign.DataSource = tablo;
            baglanti.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmBxCourse.Text == "" || cmBxTeacher.Text == "")
            {

                MessageBox.Show("Lütfen verdiğiniz değerleri kontrol ediniz");
            }

            else
            {
                baglanti.Open();
                string add = "INSERT INTO Tea_Assign(TeacherId, TeacherName, CourseName) VALUES (@TeacherId, @TeacherName, @CourseName)";
                komut = new SqlCommand(add, baglanti);
                komut.Parameters.AddWithValue("@TeacherId", cmBxId.Text);
                komut.Parameters.AddWithValue("@TeacherName", cmBxTeacher.Text);
                komut.Parameters.AddWithValue("@CourseName", cmBxCourse.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi");

            }
           
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Assign().Show();
            this.Hide();
        }

        private void TeacherAssign_Load(object sender, EventArgs e)
        {
            gridgetir();
            {

                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True";
                baglanti.Open();

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM TeacherRegistration";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmBxTeacher.Items.Add(dr["TeacherName"]);
                }
                baglanti.Close();


                komut.CommandText = "SELECT *FROM CourseCreation";
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmBxCourse.Items.Add(dr["CourseName"]);
                }
                baglanti.Close();

            }
        }

        private void dtGridAssign_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmBxId.Text = dtGridAssign.CurrentRow.Cells[0].Value.ToString();
            cmBxTeacher.Text = dtGridAssign.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
