using System.Data;
using Microsoft.Data.SqlClient;


namespace Yeniden
{

    public partial class Giriskayit : Form
    {
        private readonly string connectionString = "Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Giriskayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = NAGINI\SQLEXPRESS; Initial Catalog = test; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Password, Email;

            Email = txt_Email.Text;
            Password = txt_Password.Text;

            try
            {
                string query = "SELECT * FROM Members WHERE Email = '" + txt_Email.Text + "' AND Password = '" + txt_Password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Oturum.MemberID = Convert.ToInt32(dtable.Rows[0]["MemberID"]);
                    Oturum.FullName = dtable.Rows[0]["FullName"].ToString();


                    Email = txt_Email.Text;
                    Password = txt_Password.Text;


                    Form2 form2 = new Form2();
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


        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Members (FullName, Email, Phone, Password) VALUES (@p1, @p2, @p3, @p4)", conn);


                conn.Open();

                komut.Parameters.AddWithValue("@p1", fullname.Text);
                komut.Parameters.AddWithValue("@p2", email.Text);
                komut.Parameters.AddWithValue("@p3", phone1.Text);
                komut.Parameters.AddWithValue("@p4", sifre.Text);

                try
                {
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayýt baþarýyla eklendi.");
                    fullname.Clear();
                    phone1.Clear();
                    sifre.Clear();
                    email.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    fullname.Clear();
                    phone1.Clear();
                    sifre.Clear();
                    email.Clear();
                }

                conn.Close();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Hoþgeldiniz form2 = new Hoþgeldiniz();
            form2.Show();
            this.Hide();

        }
    }
}
