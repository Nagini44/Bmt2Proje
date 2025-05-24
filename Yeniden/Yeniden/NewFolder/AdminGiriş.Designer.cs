namespace Yeniden
{
    partial class AdminGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiriş));
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Password = new TextBox();
            txt_Email = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(151, 233);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 12;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(29, 28);
            label4.Name = "label4";
            label4.Size = new Size(256, 41);
            label4.TabIndex = 13;
            label4.Text = "Admin Giriş Menü";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 89);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 11;
            label2.Text = "Admin";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 156);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 14;
            label1.Text = "Şifre";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(48, 179);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(222, 27);
            txt_Password.TabIndex = 16;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(48, 112);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(222, 27);
            txt_Email.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-1, 0);
            button2.Name = "button2";
            button2.Size = new Size(35, 28);
            button2.TabIndex = 25;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(430, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 313);
            panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-101, -12);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 474);
            panel2.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminGiriş
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminGiriş";
            Text = "AdminGiriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txt_Password;
        private TextBox txt_Email;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}