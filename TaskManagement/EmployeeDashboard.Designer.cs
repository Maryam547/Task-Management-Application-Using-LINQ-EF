namespace TaskManagement
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            TasksdataGridView = new DataGridView();
            Reminderbutton = new Button();
            Logoutbutton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)TasksdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TasksdataGridView
            // 
            TasksdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TasksdataGridView.Location = new Point(298, 128);
            TasksdataGridView.Name = "TasksdataGridView";
            TasksdataGridView.Size = new Size(490, 192);
            TasksdataGridView.TabIndex = 0;
            // 
            // Reminderbutton
            // 
            Reminderbutton.BackColor = Color.BlueViolet;
            Reminderbutton.Cursor = Cursors.Hand;
            Reminderbutton.FlatStyle = FlatStyle.Popup;
            Reminderbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Reminderbutton.ForeColor = SystemColors.ButtonHighlight;
            Reminderbutton.Location = new Point(298, 406);
            Reminderbutton.Name = "Reminderbutton";
            Reminderbutton.Size = new Size(75, 39);
            Reminderbutton.TabIndex = 1;
            Reminderbutton.Text = "Reminder";
            Reminderbutton.UseVisualStyleBackColor = false;
            Reminderbutton.Click += Reminderbutton_Click;
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
            Logoutbutton.TabIndex = 2;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(298, 32);
            label5.Name = "label5";
            label5.Size = new Size(173, 21);
            label5.TabIndex = 16;
            label5.Text = "Employee Dashboard";
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 457);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(Logoutbutton);
            Controls.Add(Reminderbutton);
            Controls.Add(TasksdataGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            Load += EmployeeDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)TasksdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TasksdataGridView;
        private Button Reminderbutton;
        private Button Logoutbutton;
        private PictureBox pictureBox1;
        private Label label5;
    }
}