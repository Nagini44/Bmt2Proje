using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeniden
{
    public partial class AdminGiriş : Form
    {
        public AdminGiriş()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = NAGINI\SQLEXPRESS; Initial Catalog = test; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String Password, Email;

            Email = txt_Email.Text;
            Password = txt_Password.Text;

            try
            {
                string query = "SELECT * FROM Admins WHERE Admin = '" + txt_Email.Text + "' AND Password = '" + txt_Password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    /*Oturum.MemberID = Convert.ToInt32(dtable.Rows[0]["MemberID"]); // ID alanının adı senin tablona göre değişebilir
                    Oturum.FullName = dtable.Rows[0]["FullName"].ToString();*/


                    Email = txt_Email.Text;
                    Password = txt_Password.Text;


                    Library form2 = new Library();
                    form2.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Gecersiz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Email.Clear();
                    txt_Password.Clear();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoşgeldiniz form2 = new Hoşgeldiniz();
            form2.Show();
            this.Hide();
        }
    }
}

