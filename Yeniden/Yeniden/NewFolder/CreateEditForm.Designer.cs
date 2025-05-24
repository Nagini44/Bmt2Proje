namespace Yeniden
{
    partial class CreateEditForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbBookName = new TextBox();
            tbYazar = new TextBox();
            tbKategori = new TextBox();
            tbYayıncı = new TextBox();
            label4 = new Label();
            tbISBN = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lbTitle = new Label();
            lbBookID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 106);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 139);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Yazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 172);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Kategori";
            // 
            // tbBookName
            // 
            tbBookName.Location = new Point(188, 106);
            tbBookName.Name = "tbBookName";
            tbBookName.Size = new Size(290, 27);
            tbBookName.TabIndex = 3;
            // 
            // tbYazar
            // 
            tbYazar.Location = new Point(188, 139);
            tbYazar.Name = "tbYazar";
            tbYazar.Size = new Size(290, 27);
            tbYazar.TabIndex = 4;
            // 
            // tbKategori
            // 
            tbKategori.Location = new Point(188, 172);
            tbKategori.Name = "tbKategori";
            tbKategori.Size = new Size(290, 27);
            tbKategori.TabIndex = 5;
            // 
            // tbYayıncı
            // 
            tbYayıncı.Location = new Point(188, 205);
            tbYayıncı.Name = "tbYayıncı";
            tbYayıncı.Size = new Size(290, 27);
            tbYayıncı.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 205);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Yayıncı";
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(188, 238);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(290, 27);
            tbISBN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 238);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 9;
            label5.Text = "ISBN";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 298);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 298);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbTitle.Location = new Point(226, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(196, 54);
            lbTitle.TabIndex = 12;
            lbTitle.Text = "Kitap Ekle";
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Location = new Point(76, 70);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(59, 20);
            lbBookID.TabIndex = 13;
            lbBookID.Text = "KitapID";
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbBookID);
            Controls.Add(lbTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(tbISBN);
            Controls.Add(label4);
            Controls.Add(tbYayıncı);
            Controls.Add(tbKategori);
            Controls.Add(tbYazar);
            Controls.Add(tbBookName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbBookName;
        private TextBox tbYazar;
        private TextBox tbKategori;
        private TextBox tbYayıncı;
        private Label label4;
        private TextBox tbISBN;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private Label lbTitle;
        private Label lbBookID;
    }
}