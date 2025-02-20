namespace TaskManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            EmailtextBox = new TextBox();
            PasswordtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RolecomboBox = new ComboBox();
            label3 = new Label();
            Loginbutton = new Button();
            RegisterFirst = new Label();
            ShowPasswordCheckBox = new CheckBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EmailtextBox
            // 
            EmailtextBox.BackColor = Color.LavenderBlush;
            EmailtextBox.Cursor = Cursors.IBeam;
            EmailtextBox.Location = new Point(133, 46);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(125, 23);
            EmailtextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.LavenderBlush;
            PasswordtextBox.Cursor = Cursors.IBeam;
            PasswordtextBox.Location = new Point(133, 90);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(125, 23);
            PasswordtextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // RolecomboBox
            // 
            RolecomboBox.BackColor = Color.LavenderBlush;
            RolecomboBox.Cursor = Cursors.Hand;
            RolecomboBox.FormattingEnabled = true;
            RolecomboBox.Location = new Point(133, 169);
            RolecomboBox.Name = "RolecomboBox";
            RolecomboBox.Size = new Size(125, 23);
            RolecomboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(29, 172);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 6;
            label3.Text = "UserRole";
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.BlueViolet;
            Loginbutton.Cursor = Cursors.Hand;
            Loginbutton.FlatStyle = FlatStyle.Popup;
            Loginbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.ForeColor = SystemColors.ButtonHighlight;
            Loginbutton.Location = new Point(97, 211);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(75, 39);
            Loginbutton.TabIndex = 7;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // RegisterFirst
            // 
            RegisterFirst.AutoSize = true;
            RegisterFirst.Cursor = Cursors.Hand;
            RegisterFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterFirst.ForeColor = Color.BlueViolet;
            RegisterFirst.Location = new Point(181, 267);
            RegisterFirst.Name = "RegisterFirst";
            RegisterFirst.Size = new Size(85, 15);
            RegisterFirst.TabIndex = 8;
            RegisterFirst.Text = "Register Here";
            RegisterFirst.Click += RegisterFirst_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.BackColor = Color.LavenderBlush;
            ShowPasswordCheckBox.Cursor = Cursors.Hand;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 9.75F);
            ShowPasswordCheckBox.Location = new Point(133, 132);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(118, 21);
            ShowPasswordCheckBox.TabIndex = 9;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            ShowPasswordCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 460);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(EmailtextBox);
            panel1.Controls.Add(PasswordtextBox);
            panel1.Controls.Add(RolecomboBox);
            panel1.Controls.Add(RegisterFirst);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Loginbutton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(410, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 300);
            panel1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(29, 267);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 10;
            label4.Text = "If you haven't an account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(331, 26);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 15;
            label5.Text = "Login Form";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 457);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailtextBox;
        private TextBox PasswordtextBox;
        private Label label1;
        private Label label2;
        private ComboBox RolecomboBox;
        private Label label3;
        private Button Loginbutton;
        private Label RegisterFirst;
        private CheckBox ShowPasswordCheckBox;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
        private Label label5;
    }
}
