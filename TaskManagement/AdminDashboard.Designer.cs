namespace TaskManagement
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            UserdataGridView = new DataGridView();
            Updatebutton = new Button();
            Deletebutton = new Button();
            SearchUsertextBox = new TextBox();
            NametextBox = new TextBox();
            EmailtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            RolecomboBox = new ComboBox();
            label3 = new Label();
            Logoutbutton = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)UserdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserdataGridView
            // 
            UserdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserdataGridView.Location = new Point(360, 54);
            UserdataGridView.Name = "UserdataGridView";
            UserdataGridView.Size = new Size(303, 150);
            UserdataGridView.TabIndex = 2;
            UserdataGridView.CellClick += UserdataGridView_CellContentClick;
            UserdataGridView.CellContentClick += UserdataGridView_CellContentClick;
            UserdataGridView.CellFormatting += UserdataGridView_CellFormatting;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.BlueViolet;
            Updatebutton.Cursor = Cursors.Hand;
            Updatebutton.FlatStyle = FlatStyle.Popup;
            Updatebutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Updatebutton.ForeColor = SystemColors.ButtonHighlight;
            Updatebutton.Location = new Point(32, 146);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(75, 39);
            Updatebutton.TabIndex = 4;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.BlueViolet;
            Deletebutton.Cursor = Cursors.Hand;
            Deletebutton.FlatStyle = FlatStyle.Popup;
            Deletebutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Deletebutton.ForeColor = SystemColors.ButtonHighlight;
            Deletebutton.Location = new Point(184, 146);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(75, 39);
            Deletebutton.TabIndex = 5;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // SearchUsertextBox
            // 
            SearchUsertextBox.BackColor = Color.LavenderBlush;
            SearchUsertextBox.Cursor = Cursors.IBeam;
            SearchUsertextBox.Location = new Point(643, 25);
            SearchUsertextBox.Multiline = true;
            SearchUsertextBox.Name = "SearchUsertextBox";
            SearchUsertextBox.PlaceholderText = "Search...";
            SearchUsertextBox.Size = new Size(125, 23);
            SearchUsertextBox.TabIndex = 6;
            SearchUsertextBox.TextChanged += SearchUsertextBox_TextChanged;
            SearchUsertextBox.Enter += SearchUsertextBox_Enter;
            SearchUsertextBox.Leave += SearchUsertextBox_Leave;
            // 
            // NametextBox
            // 
            NametextBox.BackColor = Color.LavenderBlush;
            NametextBox.Cursor = Cursors.IBeam;
            NametextBox.Location = new Point(134, 25);
            NametextBox.Multiline = true;
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(125, 23);
            NametextBox.TabIndex = 7;
            // 
            // EmailtextBox
            // 
            EmailtextBox.BackColor = Color.LavenderBlush;
            EmailtextBox.Cursor = Cursors.IBeam;
            EmailtextBox.Location = new Point(134, 62);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(125, 23);
            EmailtextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // RolecomboBox
            // 
            RolecomboBox.BackColor = Color.LavenderBlush;
            RolecomboBox.Cursor = Cursors.Hand;
            RolecomboBox.ForeColor = SystemColors.WindowText;
            RolecomboBox.FormattingEnabled = true;
            RolecomboBox.Location = new Point(134, 99);
            RolecomboBox.Name = "RolecomboBox";
            RolecomboBox.Size = new Size(125, 23);
            RolecomboBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(32, 100);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 12;
            label3.Text = "Role";
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
            Logoutbutton.TabIndex = 13;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(300, 23);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 17;
            label4.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NametextBox);
            panel1.Controls.Add(RolecomboBox);
            panel1.Controls.Add(Deletebutton);
            panel1.Controls.Add(EmailtextBox);
            panel1.Controls.Add(Updatebutton);
            panel1.Location = new Point(372, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 206);
            panel1.TabIndex = 19;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Logoutbutton);
            Controls.Add(SearchUsertextBox);
            Controls.Add(UserdataGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)UserdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView UserdataGridView;
        private Button Updatebutton;
        private Button Deletebutton;
        private TextBox SearchUsertextBox;
        private TextBox NametextBox;
        private TextBox EmailtextBox;
        private Label label1;
        private Label label2;
        private ComboBox RolecomboBox;
        private Label label3;
        private Button Logoutbutton;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}