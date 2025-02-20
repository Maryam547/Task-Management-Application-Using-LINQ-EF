namespace TaskManagement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            Registerbutton = new Button();
            UserNametextBox = new TextBox();
            EmailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            RolecomboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LoginFirst = new Label();
            ShowPasswordCheckBox = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Registerbutton
            // 
            Registerbutton.BackColor = Color.BlueViolet;
            Registerbutton.Cursor = Cursors.Hand;
            Registerbutton.FlatStyle = FlatStyle.Popup;
            Registerbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Registerbutton.ForeColor = SystemColors.ButtonHighlight;
            Registerbutton.Location = new Point(96, 238);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(75, 39);
            Registerbutton.TabIndex = 0;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // UserNametextBox
            // 
            UserNametextBox.BackColor = Color.LavenderBlush;
            UserNametextBox.CharacterCasing = CharacterCasing.Upper;
            UserNametextBox.Cursor = Cursors.IBeam;
            UserNametextBox.Location = new Point(138, 42);
            UserNametextBox.Multiline = true;
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(125, 23);
            UserNametextBox.TabIndex = 1;
            // 
            // EmailtextBox
            // 
            EmailtextBox.BackColor = Color.LavenderBlush;
            EmailtextBox.Cursor = Cursors.IBeam;
            EmailtextBox.Location = new Point(138, 84);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(125, 23);
            EmailtextBox.TabIndex = 2;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.LavenderBlush;
            PasswordtextBox.Cursor = Cursors.IBeam;
            PasswordtextBox.Location = new Point(138, 124);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(125, 23);
            PasswordtextBox.TabIndex = 3;
            // 
            // RolecomboBox
            // 
            RolecomboBox.BackColor = Color.LavenderBlush;
            RolecomboBox.Cursor = Cursors.Hand;
            RolecomboBox.FormattingEnabled = true;
            RolecomboBox.Location = new Point(138, 194);
            RolecomboBox.Name = "RolecomboBox";
            RolecomboBox.Size = new Size(125, 23);
            RolecomboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(10, 43);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(11, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(11, 195);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 8;
            label4.Text = "User Role";
            // 
            // LoginFirst
            // 
            LoginFirst.AutoSize = true;
            LoginFirst.Cursor = Cursors.Hand;
            LoginFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginFirst.ForeColor = Color.BlueViolet;
            LoginFirst.Location = new Point(188, 304);
            LoginFirst.Name = "LoginFirst";
            LoginFirst.Size = new Size(68, 15);
            LoginFirst.TabIndex = 9;
            LoginFirst.Text = "Login Here";
            LoginFirst.Click += LoginFirst_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.BackColor = Color.LavenderBlush;
            ShowPasswordCheckBox.Cursor = Cursors.Hand;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 9.75F);
            ShowPasswordCheckBox.Location = new Point(138, 153);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(118, 21);
            ShowPasswordCheckBox.TabIndex = 10;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            ShowPasswordCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LoginFirst);
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(RolecomboBox);
            panel1.Controls.Add(UserNametextBox);
            panel1.Controls.Add(PasswordtextBox);
            panel1.Controls.Add(EmailtextBox);
            panel1.Location = new Point(398, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 342);
            panel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(11, 304);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 11;
            label5.Text = "If you have an account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(330, 25);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 16;
            label6.Text = "Register Form";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registerbutton;
        private TextBox UserNametextBox;
        private TextBox EmailtextBox;
        private TextBox PasswordtextBox;
        private ComboBox RolecomboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LoginFirst;
        private CheckBox ShowPasswordCheckBox;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}