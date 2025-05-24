namespace Yeniden
{
    partial class MyBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBooks));
            clientsTable = new DataGridView();
            button1 = new Button();
            button2 = new Button();
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
            clientsTable.Location = new Point(12, 100);
            clientsTable.MultiSelect = false;
            clientsTable.Name = "clientsTable";
            clientsTable.ReadOnly = true;
            clientsTable.RowHeadersVisible = false;
            clientsTable.RowHeadersWidth = 51;
            clientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsTable.Size = new Size(776, 338);
            clientsTable.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(127, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Teslim Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 51);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MyBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(clientsTable);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyBooks";
            Load += MyBooks_Load;
            ((System.ComponentModel.ISupportInitialize)clientsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientsTable;
        private Button button1;
        private Button button2;
    }
}