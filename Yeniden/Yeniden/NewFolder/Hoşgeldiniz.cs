namespace Yeniden
{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giriskayit form2 = new Giriskayit();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminGiriş form2 = new AdminGiriş();
            form2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminGiriş form2 = new AdminGiriş();
            form2.Show();
            this.Hide();
        }
    }
}
