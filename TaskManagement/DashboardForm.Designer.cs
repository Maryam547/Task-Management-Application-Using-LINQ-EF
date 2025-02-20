namespace TaskManagement
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            Welcomelabel = new Label();
            ManageUserbutton = new Button();
            ManageTasksbutton = new Button();
            ViewTasksbutton = new Button();
            Logoutbutton = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Welcomelabel
            // 
            Welcomelabel.AutoSize = true;
            Welcomelabel.BackColor = Color.Thistle;
            Welcomelabel.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcomelabel.ForeColor = SystemColors.WindowText;
            Welcomelabel.Location = new Point(325, 22);
            Welcomelabel.Name = "Welcomelabel";
            Welcomelabel.Size = new Size(121, 20);
            Welcomelabel.TabIndex = 0;
            Welcomelabel.Text = "Welcome, User";
            // 
            // ManageUserbutton
            // 
            ManageUserbutton.BackColor = Color.BlueViolet;
            ManageUserbutton.Cursor = Cursors.Hand;
            ManageUserbutton.FlatStyle = FlatStyle.Popup;
            ManageUserbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ManageUserbutton.ForeColor = SystemColors.ButtonHighlight;
            ManageUserbutton.Location = new Point(55, 38);
            ManageUserbutton.Name = "ManageUserbutton";
            ManageUserbutton.Size = new Size(173, 39);
            ManageUserbutton.TabIndex = 1;
            ManageUserbutton.Text = "Manage User";
            ManageUserbutton.UseVisualStyleBackColor = false;
            ManageUserbutton.Click += ManageUserbutton_Click;
            // 
            // ManageTasksbutton
            // 
            ManageTasksbutton.BackColor = Color.BlueViolet;
            ManageTasksbutton.Cursor = Cursors.Hand;
            ManageTasksbutton.FlatStyle = FlatStyle.Popup;
            ManageTasksbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ManageTasksbutton.ForeColor = SystemColors.ButtonHighlight;
            ManageTasksbutton.Location = new Point(55, 129);
            ManageTasksbutton.Name = "ManageTasksbutton";
            ManageTasksbutton.Size = new Size(173, 39);
            ManageTasksbutton.TabIndex = 2;
            ManageTasksbutton.Text = "Manage Tasks";
            ManageTasksbutton.UseVisualStyleBackColor = false;
            ManageTasksbutton.Click += ManageTasksbutton_Click;
            // 
            // ViewTasksbutton
            // 
            ViewTasksbutton.BackColor = Color.BlueViolet;
            ViewTasksbutton.Cursor = Cursors.Hand;
            ViewTasksbutton.FlatStyle = FlatStyle.Popup;
            ViewTasksbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ViewTasksbutton.ForeColor = SystemColors.ButtonHighlight;
            ViewTasksbutton.Location = new Point(55, 219);
            ViewTasksbutton.Name = "ViewTasksbutton";
            ViewTasksbutton.Size = new Size(173, 39);
            ViewTasksbutton.TabIndex = 3;
            ViewTasksbutton.Text = "View Tasks";
            ViewTasksbutton.UseVisualStyleBackColor = false;
            ViewTasksbutton.Click += ViewTasksbutton_Click;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = Color.BlueViolet;
            Logoutbutton.Cursor = Cursors.Hand;
            Logoutbutton.FlatStyle = FlatStyle.Popup;
            Logoutbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Logoutbutton.ForeColor = SystemColors.ButtonHighlight;
            Logoutbutton.Location = new Point(713, 406);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(75, 39);
            Logoutbutton.TabIndex = 4;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(ManageUserbutton);
            panel1.Controls.Add(ManageTasksbutton);
            panel1.Controls.Add(ViewTasksbutton);
            panel1.Location = new Point(399, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 300);
            panel1.TabIndex = 6;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 457);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(Logoutbutton);
            Controls.Add(Welcomelabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcomelabel;
        private Button ManageUserbutton;
        private Button ManageTasksbutton;
        private Button ViewTasksbutton;
        private Button Logoutbutton;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}