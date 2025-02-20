namespace TaskManagement
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            Registerbutton = new Button();
            Loginbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            Registerbutton.Location = new Point(45, 63);
            Registerbutton.Name = "Registerbutton";
            Registerbutton.Size = new Size(200, 40);
            Registerbutton.TabIndex = 0;
            Registerbutton.Text = "Register";
            Registerbutton.UseVisualStyleBackColor = false;
            Registerbutton.Click += Registerbutton_Click;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.BlueViolet;
            Loginbutton.Cursor = Cursors.Hand;
            Loginbutton.FlatStyle = FlatStyle.Popup;
            Loginbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Loginbutton.ForeColor = SystemColors.ButtonHighlight;
            Loginbutton.Location = new Point(45, 194);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(200, 40);
            Loginbutton.TabIndex = 1;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(325, 32);
            label1.Name = "label1";
            label1.Size = new Size(337, 21);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the Task Management System ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(357, 71);
            label2.Name = "label2";
            label2.Size = new Size(418, 21);
            label2.TabIndex = 3;
            label2.Text = "Stay organized and get things done efficiently! 😊🚀";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(45, 25);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 5;
            label4.Text = "Create an account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(45, 150);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 6;
            label5.Text = "Have an account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Registerbutton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Loginbutton);
            panel1.Location = new Point(357, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 275);
            panel1.TabIndex = 8;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 457);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registerbutton;
        private Button Loginbutton;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}