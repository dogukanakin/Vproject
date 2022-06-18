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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            baglanti.ConnectionString = @"Data Source=DESKTOP-C4GRDAP;Initial Catalog=viusalProject;Integrated Security=True";
        }

        SqlConnection baglanti = new SqlConnection();
        SqlCommand komut = new SqlCommand();
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection =baglanti;
            komut.CommandText = "select * from login";
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                if(txtBxUsername.Text.Equals(dr["Admin"].ToString()) && txtBxPassword.Text.Equals(dr["Password"].ToString ()))
                {
                    MessageBox.Show("Giriş Başarılı", " Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new RegistrationPanel().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız", " Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            baglanti.Close();
        }
            

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
