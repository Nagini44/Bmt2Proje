namespace Yeniden
{
    partial class Giriskayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriskayit));
            txt_Email = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            label1 = new Label();
            txt_Password = new TextBox();
            button4 = new Button();
            sifre = new TextBox();
            email = new TextBox();
            fullname = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            phone1 = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(74, 107);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(222, 27);
            txt_Email.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 114);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(137, 253);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(137, 59);
            label4.Name = "label4";
            label4.Size = new Size(161, 41);
            label4.TabIndex = 8;
            label4.Text = "Giriş Menü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 181);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 10;
            label1.Text = "Şifre";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(74, 174);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(222, 27);
            txt_Password.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(487, 365);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 20;
            button4.Text = "Kaydol";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // sifre
            // 
            sifre.Location = new Point(487, 315);
            sifre.Name = "sifre";
            sifre.Size = new Size(216, 27);
            sifre.TabIndex = 19;
            // 
            // email
            // 
            email.Location = new Point(487, 246);
            email.Name = "email";
            email.Size = new Size(216, 27);
            email.TabIndex = 17;
            // 
            // fullname
            // 
            fullname.Location = new Point(487, 107);
            fullname.Name = "fullname";
            fullname.Size = new Size(216, 27);
            fullname.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 292);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 15;
            label3.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 151);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 223);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 84);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 12;
            label7.Text = "Ad Soyad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(487, 29);
            label8.Name = "label8";
            label8.Size = new Size(167, 41);
            label8.TabIndex = 22;
            label8.Text = "Kayıt Menü";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-63, -30);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 525);
            panel1.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(61, 29);
            button2.Name = "button2";
            button2.Size = new Size(35, 28);
            button2.TabIndex = 24;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // phone1
            // 
            phone1.Location = new Point(487, 174);
            phone1.Mask = "(999) 000-0000";
            phone1.Name = "phone1";
            phone1.Size = new Size(219, 27);
            phone1.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(phone1);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(sifre);
            Controls.Add(email);
            Controls.Add(fullname);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Email;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label1;
        private TextBox txt_Password;
        private Button button4;
        private TextBox sifre;
        private TextBox email;
        private TextBox fullname;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Button button2;
        private MaskedTextBox phone1;
    }
}
