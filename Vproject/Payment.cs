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
    public partial class Payment : Form
    {
        public Payment()
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
            da = new SqlDataAdapter("Select *From Stu_Assign", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dtGridPayment.DataSource = tablo;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new RegistrationPanel().Show();
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
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmBxAmount.Text == "" || cmBxId.Text == "" || cmBxCourse.Text == ""  )
            {

                MessageBox.Show("Lütfen verdiğiniz değerleri kontrol ediniz");
            }
            else
            {
                string add = "INSERT INTO Payment(StudentId, StudentName, CourseName, Amount, TaksitSayisi, AylikTutar) VALUES (@StudentId, @StudentName, @CourseName, @Amount, @TaksitSayisi, @AylikTutar)";
                komut = new SqlCommand(add, baglanti);
                komut.Parameters.AddWithValue("@StudentId", cmBxId.Text);
                komut.Parameters.AddWithValue("@StudentName", cmBxStudentName.Text);
                komut.Parameters.AddWithValue("@CourseName", cmBxCourse.Text);
                komut.Parameters.AddWithValue("@Amount", cmBxAmount.Text);
                komut.Parameters.AddWithValue("@TaksitSayisi", cmbTaksit.Text);
                komut.Parameters.AddWithValue("@AylikTutar", txtBxTutar.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                gridgetir();
                MessageBox.Show("Kayıt Başarıyla Eklendi");



            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            gridgetir();
        }

        private void dtGridPayment_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmBxId.Text = dtGridPayment.CurrentRow.Cells[0].Value.ToString();
            cmBxStudentName.Text = dtGridPayment.CurrentRow.Cells[1].Value.ToString();
            cmBxCourse.Text = dtGridPayment.CurrentRow.Cells[2].Value.ToString();
            cmBxAmount.Text = dtGridPayment.CurrentRow.Cells[3].Value.ToString();
        }



        private void btnTaksit_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToDouble(cmBxAmount.Text);
            sayi2 = Convert.ToDouble(cmbTaksit.Text);
            
                sonuc = sayi1 / sayi2;

            txtBxTutar.Text = sonuc.ToString();
        }
    }
  
}