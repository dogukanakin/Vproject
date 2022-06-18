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
using Excel = Microsoft.Office.Interop.Excel;


namespace Vproject
{
    public partial class CouOperations : Form
    {
        public CouOperations()
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
            da = new SqlDataAdapter("Select *From CourseCreation", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dtGridOperation.DataSource = tablo;
            baglanti.Close();
        }

       



        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "delete from CourseCreation where CourseId=@CourseId ";
            komut = new SqlCommand(delete, baglanti);
            komut.Parameters.AddWithValue("@CourseId", Convert.ToInt32(txtBxDelete.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            gridgetir();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from CourseCreation where CourseName like '%" + txtBxSearch.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtGridOperation.DataSource = ds.Tables[0];
            baglanti.Close();
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Report().Show();
            this.Hide();
        }

        private void CouOperations_Load(object sender, EventArgs e)
        {
            gridgetir();

            for (int i = 0; i < dtGridOperation.Rows.Count - 1; i++)
            {
                Application.DoEvents();
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dtGridOperation.Rows[i].Cells["Fee"].Value) > 200)
                {
                    renk.BackColor = Color.YellowGreen;
                }
                else if (Convert.ToInt32(dtGridOperation.Rows[i].Cells["Fee"].Value) > 100)
                {
                    renk.BackColor = Color.Orange;
                }
                else if (Convert.ToInt32(dtGridOperation.Rows[i].Cells["Fee"].Value) > 0)
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                dtGridOperation.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBxDelete.Text = dtGridOperation.CurrentRow.Cells[0].Value.ToString();
            txtBxSearch.Text = dtGridOperation.CurrentRow.Cells[1].Value.ToString();

        }



        private void btnExcel_Click(object sender, EventArgs e)
        {
            int sutun = 1;
            int satir = 1;
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Workbooks.Add();
            ExcelApp.Visible = true;
            ExcelApp.Worksheets[1].Activate();

            for (int j = 0; j < dtGridOperation.Columns.Count; j++)
            {
                ExcelApp.Cells[satir, sutun + j].Value = dtGridOperation.Columns[j].HeaderText;
                ExcelApp.Cells[satir, sutun + j].Font.Color = System.Drawing.Color.Blue;
                ExcelApp.Cells[satir, sutun + j].Font.Size = 12;
                ExcelApp.Cells[satir, sutun + j].ColumnWidth = 20;
                ExcelApp.Cells[satir, sutun + j].Font.Bold = true;
                ExcelApp.Cells[satir, sutun + j].Font.Name = "Arial Black";
            }
            satir++;

            for (int i = 0; i < dtGridOperation.Rows.Count; i++)
            {

                for (int j = 0; j < dtGridOperation.Columns.Count; j++)
                {
                    ExcelApp.Cells[satir + i, sutun + j].Value = dtGridOperation[j, i].Value;

                }

            }
        }
    }
}
