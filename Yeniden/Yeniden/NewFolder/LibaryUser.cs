using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Yeniden.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yeniden.NewFolder
{
    public partial class LibaryUser : Form
    {
        public LibaryUser()
        {
            InitializeComponent();

            ReadClients();

        }

        sqlbaglantisi baglan = new sqlbaglantisi();
        DataTable tablo = new DataTable();

        private void ReadClients()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("BookName");
            dataTable.Columns.Add("Yazar");
            dataTable.Columns.Add("Kategori");
            dataTable.Columns.Add("Yayıncı");
            dataTable.Columns.Add("ISBN");
            dataTable.Columns.Add("Available");

            var repo = new Repos();
            var clients = repo.GetClients();

            foreach (var client in clients)
            {
                var row = dataTable.NewRow();

                row["BookID"] = client.BookID;
                row["BookName"] = client.BookName;
                row["Yazar"] = client.Yazar;
                row["Kategori"] = client.Kategori;
                row["Yayıncı"] = client.Yayıncı;
                row["ISBN"] = client.ISBN;
                row["Available"] = client.Available;

                dataTable.Rows.Add(row);
            }

            this.dataGridView1.DataSource = dataTable;

        }
 

        private void btn_odunc_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool Available = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Available"].Value);

                if (Available == true)
                {
                    int MemberID = Oturum.MemberID;
                    int BookID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value);
                    string BookName = Convert.ToString(dataGridView1.SelectedRows[0].Cells["BookName"].Value);
                    DateTime oduncTarihi = DateTime.Now;


                    string query = "INSERT INTO OduncIslemleri (MemberID,BookName, BookID, OduncTarihi) " +
                           "VALUES (@MemberID,@BookName, @BookID, @oduncTarihi)" +
                           "UPDATE Library SET Available = 0 WHERE BookID = @BookID";



                    using (SqlConnection conn = new SqlConnection("Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", MemberID);
                        cmd.Parameters.AddWithValue("@BookName", BookName);
                        cmd.Parameters.AddWithValue("@BookID", BookID);
                        cmd.Parameters.AddWithValue("@oduncTarihi", oduncTarihi);
                        cmd.Parameters.AddWithValue("@Available", Available);


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("Başarı ile ödünç aldın");

                    //LoadMembers();


                }
                else
                {
                    MessageBox.Show("Bu kitap şuan müstakil değil", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void LibaryUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Library where BookName like'" + textBox1.Text + "'", baglan.baglanti());
            adtr.Fill(tablo);  
            SqlDataAdapter adtr1 = new SqlDataAdapter("select * from Library where Yazar like'" + textBox1.Text + "'", baglan.baglanti());
            adtr1.Fill(tablo);
            SqlDataAdapter adtr2 = new SqlDataAdapter("select * from Library where YAYINCI like'" + textBox1.Text + "'", baglan.baglanti());
            adtr2.Fill(tablo);
            SqlDataAdapter adtr3 = new SqlDataAdapter("select * from Library where KATEGORİ like'" + textBox1.Text + "'", baglan.baglanti());
            adtr3.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.baglanti().Close();
        }
        /*public void LoadMembers()
        {
            string connectionString = "Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Library ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int MemberID = Oturum.MemberID;
                    int BookID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BookID"].Value);
                    string BookName = Convert.ToString(dataGridView1.SelectedRows[0].Cells["BookName"].Value);
                    DateTime oduncTarihi = DateTime.Now;
                    bool Available = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Available"].Value);



                    cmd.Parameters.AddWithValue("@MemberID", MemberID);
                    cmd.Parameters.AddWithValue("@BookName", BookName);
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.Parameters.AddWithValue("@oduncTarihi", oduncTarihi);
                    cmd.Parameters.AddWithValue("@Available", Available);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

            }




        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
