using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Yeniden.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Yeniden
{
    public partial class MyBooks : Form
    {
        public MyBooks()
        {
            InitializeComponent();
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {

            VerileriGetir(Oturum.MemberID);
        }
        private void VerileriGetir(int memberId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "SELECT * FROM OduncIslemleri WHERE MemberID = @MemberID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MemberID", memberId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                clientsTable.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                int selectedMemberID = Convert.ToInt32(clientsTable.SelectedRows[0].Cells["OduncID"].Value);
                int BookID = Convert.ToInt32(clientsTable.SelectedRows[0].Cells["BookID"].Value);


            string connectionString = "Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"; // Bağlantı cümleni buraya yaz
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM OduncIslemleri WHERE OduncID = @OduncID " +
                                   "UPDATE Library SET Available = 1 WHERE BookID = @BookID";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OduncID", selectedMemberID);
                        cmd.Parameters.AddWithValue("@BookID", BookID);

                    conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }




            LoadMembers(Oturum.MemberID);

            MessageBox.Show("Başarı ile teslim ettin");
            
        }
        public void LoadMembers(int memberID)
        {
            string connectionString = "Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM OduncIslemleri WHERE MemberID = @MemberID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                clientsTable.DataSource = dt;
            }
        }
    }
}
