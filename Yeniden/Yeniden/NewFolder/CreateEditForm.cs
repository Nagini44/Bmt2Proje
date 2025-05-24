using Yeniden.Models;
using Yeniden.Repositories;


namespace Yeniden
{
    public partial class CreateEditForm : Form
    {
        int abd;
        public CreateEditForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private int clientId = 0;

        /*public void EditClient(Client client)
        {
           

            this.lbBookID.Text = "" + client.BookID;
            this.tbBookName.Text = client.BookName;
            this.tbYazar.Text = client.Yazar;
            this.tbKategori.Text = client.Kategori;
            this.tbYayıncı.Text = client.Yayıncı;
            this.tbISBN.Text = client.ISBN;

            this.clientId = client.BookID;
        }*/


        private void btnSave_Click(object sender, EventArgs e)
        {

            Client client = new Client();

            client.BookID = this.clientId;
            client.BookName = this.tbBookName.Text;
            client.Yazar = this.tbYazar.Text;
            client.Kategori = this.tbKategori.Text;
            client.Yayıncı = this.tbYayıncı.Text;
            client.ISBN = this.tbISBN.Text;

            var repo = new Repos();         
            repo.CreateClient(client);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
