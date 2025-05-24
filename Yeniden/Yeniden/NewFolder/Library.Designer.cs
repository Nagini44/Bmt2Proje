namespace Yeniden
{
    partial class Library
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clientsTable = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)clientsTable).BeginInit();
            SuspendLayout();
            // 
            // clientsTable
            // 
            clientsTable.AllowUserToAddRows = false;
            clientsTable.AllowUserToDeleteRows = false;
            clientsTable.AllowUserToResizeRows = false;
            clientsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsTable.Location = new Point(12, 115);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.ReadOnly = true;
            clientsTable.RowHeadersVisible = false;
            clientsTable.RowHeadersWidth = 51;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(791, 360);
            clientsTable.TabIndex = 0;
            clientsTable.CellContentClick += clientsTable_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(709, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 487);
            Controls.Add(clientsTable);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Library";
            Text = "LibraryAdmin";
            Load += Library_Load;
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientsTable;
        private Button btnAdd;
        private Button btnDelete;
    }
}