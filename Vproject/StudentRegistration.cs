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
    public partial class StudentRegistration : Form
    {
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
            dtGridStudent.DataSource = tablo;
            baglanti.Close();
        }

        public StudentRegistration()
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

        private void btnCourseCreation_Click(object sender, EventArgs e)
        {
            new Course().Show();
            this.Hide();
        }

        private void tnAssignment_Click(object sender, EventArgs e)
        {
            new Assign().Show();
            this.Hide();
        }


   

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBxContact.Text == "" || txtBxId.Text == "" || txtBxMail.Text == "" || txtBxName.Text == "" || rchTxAddress.Text == "" || dtTimeBirth.Text == "" || cmBxGender.Text == "" || txtBxFaculty.Text == "")
            {

                MessageBox.Show("Lütfen verdiğiniz değerleri kontrol ediniz");
            }
            else
            {
                string add = "INSERT INTO StudentRegistration(StudentName, MailAddress, ContactNumber, DateofBirth, StudentId, Gender, Faculty, Adress) VALUES (@StudentName, @MailAddress, @ContactNumber, @DateofBirth, @StudentId, @Gender, @Faculty, @Adress)";
                komut = new SqlCommand(add, baglanti);
                komut.Parameters.AddWithValue("@StudentName", txtBxName.Text);
                komut.Parameters.AddWithValue("@MailAddress", txtBxMail.Text);
                komut.Parameters.AddWithValue("@ContactNumber", txtBxContact.Text);
                komut.Parameters.AddWithValue("@DateOfBirth", dtTimeBirth.Value);
                komut.Parameters.AddWithValue("@StudentId", txtBxId.Text);
                komut.Parameters.AddWithValue("@Gender", cmBxGender.Text);
                komut.Parameters.AddWithValue("@Faculty", txtBxFaculty.Text);
                komut.Parameters.AddWithValue("@Adress", rchTxAddress.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                gridgetir();
                MessageBox.Show("Kayıt Başarıyla Eklendi");

            }

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

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            gridgetir();
        }

        private void dtGridStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBxName.Text = dtGridStudent.CurrentRow.Cells[1].Value.ToString();
            txtBxMail.Text = dtGridStudent.CurrentRow.Cells[2].Value.ToString();
            txtBxContact.Text = dtGridStudent.CurrentRow.Cells[3].Value.ToString();
            dtGridStudent.Text = dtGridStudent.CurrentRow.Cells[4].Value.ToString();
            txtBxId.Text = dtGridStudent.CurrentRow.Cells[0].Value.ToString();
            cmBxGender.Text = dtGridStudent.CurrentRow.Cells[5].Value.ToString();
            txtBxFaculty.Text = dtGridStudent.CurrentRow.Cells[6].Value.ToString();
            rchTxAddress.Text = dtGridStudent.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string UPDATE = "Update StudentRegistration SET StudentName=@StudentName, MailAddress=@MailAddress, ContactNumber=@ContactNumber, DateofBirth=@DateofBirth, Gender=@Gender, Faculty=@Faculty WHERE StudentId=@StudentId ";
            komut = new SqlCommand(UPDATE, baglanti);
            komut.Parameters.AddWithValue("@StudentId", Convert.ToInt32(txtBxId.Text));
            komut.Parameters.AddWithValue("@StudentName", txtBxName.Text);
            komut.Parameters.AddWithValue("@MailAddress", txtBxMail.Text);
            komut.Parameters.AddWithValue("@ContactNumber", txtBxContact.Text);
            komut.Parameters.AddWithValue("@DateOfBirth", dtTimeBirth.Value);
            komut.Parameters.AddWithValue("@Gender", cmBxGender.Text);
            komut.Parameters.AddWithValue("@Faculty", txtBxFaculty.Text);
            komut.Parameters.AddWithValue("@Adress", rchTxAddress.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            gridgetir();
            MessageBox.Show("Kayıt Başarıyla Güncellendi");

        }
    }
}



