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
    public partial class TeacherRegistration : Form
    {

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
            dtGridTeacher.DataSource = tablo;
            baglanti.Close();
        }
        public TeacherRegistration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new RegistrationPanel().Show();
            this.Hide();
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                if (txtBxContact.Text == "" || txtBxId.Text == "" || txtBxMail.Text == "" || txtBxName.Text == "" || rchTxAddress.Text == "" || dtTimeBirth.Text == "" || cmBxGender.Text == "")
                {

                    MessageBox.Show("Lütfen verdiğiniz değerleri kontrol ediniz");
                }
                else
                {
                    baglanti.Open();
                    string add = "INSERT INTO TeacherRegistration(TeacherName, MailAddress, ContactNumber, DateofBirth, TeacherId, Gender, Adress) VALUES (@TeacherName, @MailAddress, @ContactNumber, @DateofBirth, @TeacherId, @Gender,  @Adress)";
                    komut = new SqlCommand(add, baglanti);
                    komut.Parameters.AddWithValue("@TeacherName", txtBxName.Text);
                    komut.Parameters.AddWithValue("@MailAddress", txtBxMail.Text);
                    komut.Parameters.AddWithValue("@ContactNumber", txtBxContact.Text);
                    komut.Parameters.AddWithValue("@TeacherId", txtBxId.Text);
                    komut.Parameters.AddWithValue("@DateOfBirth", dtTimeBirth.Value);
                    komut.Parameters.AddWithValue("@Gender", cmBxGender.Text);
                    komut.Parameters.AddWithValue("@Adress", rchTxAddress.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    gridgetir();
                    MessageBox.Show("Kayıt Başarıyla Eklendi");
                    

                }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new Payment().Show();
            this.Hide();
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            new Assign().Show();
            this.Hide();
        }

        private void btnCourseCreation_Click(object sender, EventArgs e)
        {
            new Course().Show();
            this.Hide();
        }

        private void dtGridTeacher_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBxName.Text = dtGridTeacher.CurrentRow.Cells[1].Value.ToString();
            txtBxMail.Text = dtGridTeacher.CurrentRow.Cells[2].Value.ToString();
            txtBxContact.Text = dtGridTeacher.CurrentRow.Cells[3].Value.ToString();
            dtTimeBirth.Text = dtGridTeacher.CurrentRow.Cells[4].Value.ToString();
            txtBxId.Text = dtGridTeacher.CurrentRow.Cells[0].Value.ToString();
            cmBxGender.Text = dtGridTeacher.CurrentRow.Cells[5].Value.ToString();
            rchTxAddress.Text = dtGridTeacher.CurrentRow.Cells[6].Value.ToString();
        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            gridgetir();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string UPDATE = "Update TeacherRegistration SET TeacherName=@TeacherName, MailAddress=@MailAddress, ContactNumber=@ContactNumber, DateofBirth=@DateofBirth, Gender=@Gender, Adress=@Adress WHERE TeacherId=@TeacherId ";
            komut = new SqlCommand(UPDATE, baglanti);
            komut.Parameters.AddWithValue("@TeacherId", Convert.ToInt32(txtBxId.Text));
            komut.Parameters.AddWithValue("@TeacherName", txtBxName.Text);
            komut.Parameters.AddWithValue("@MailAddress", txtBxMail.Text);
            komut.Parameters.AddWithValue("@ContactNumber", txtBxContact.Text);
            komut.Parameters.AddWithValue("@DateOfBirth", dtTimeBirth.Value);
            komut.Parameters.AddWithValue("@Gender", cmBxGender.Text);
            komut.Parameters.AddWithValue("@Adress", rchTxAddress.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            gridgetir();
            MessageBox.Show("Kayıt Başarıyla Güncellendi");
        }
    }
}
