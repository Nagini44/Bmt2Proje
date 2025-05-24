using System.Data;
using Yeniden.Repositories;


namespace Yeniden
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();

            ReadClients();
        }


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

            this.clientsTable.DataSource = dataTable;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadClients();


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }
        /*
            ÇALIŞMAYAN EDIT KOMUTU
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientID = int.Parse(val);

            var repo = new Repos();
            var client = repo.GetClient(clientID);

            if (client == null) return;

            CreateEditForm form = new CreateEditForm(1);
            form.EditClient(client);
            if (form.ShowDialog() == DialogResult.OK)
            {


                ReadClients();

            }*/

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var val = this.clientsTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int clientID = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?"
                , "Delete Client", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new Repos();
            repo.DeleteClient(clientID);

            ReadClients();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }

        private void clientsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
