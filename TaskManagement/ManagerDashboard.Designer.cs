namespace TaskManagement
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TitletextBox = new TextBox();
            DescriptionrichTextBox = new RichTextBox();
            DuedateTimePicker = new DateTimePicker();
            StatuscomboBox = new ComboBox();
            AssignedUsercomboBox = new ComboBox();
            PrioritycomboBox = new ComboBox();
            ComplexitycomboBox = new ComboBox();
            CategorycomboBox = new ComboBox();
            RemindercheckBox = new CheckBox();
            Savebutton = new Button();
            TaskdataGridView = new DataGridView();
            Updatebutton = new Button();
            Deletebutton = new Button();
            CreatedAtdateTimePicker = new DateTimePicker();
            label10 = new Label();
            OpenRemindersbutton = new Button();
            Logoutbutton = new Button();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(18, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(18, 92);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 1;
            label2.Text = "Task Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(18, 165);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 2;
            label3.Text = "Due Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(18, 191);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "TaskStatus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(18, 223);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 4;
            label5.Text = "Assigned User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(18, 252);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 5;
            label6.Text = "Priority";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(18, 281);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 6;
            label7.Text = "Complexity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(18, 310);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 7;
            label8.Text = "Category";
            // 
            // TitletextBox
            // 
            TitletextBox.BackColor = Color.LavenderBlush;
            TitletextBox.Cursor = Cursors.IBeam;
            TitletextBox.Location = new Point(140, 49);
            TitletextBox.Multiline = true;
            TitletextBox.Name = "TitletextBox";
            TitletextBox.Size = new Size(125, 23);
            TitletextBox.TabIndex = 9;
            // 
            // DescriptionrichTextBox
            // 
            DescriptionrichTextBox.BackColor = Color.LavenderBlush;
            DescriptionrichTextBox.Cursor = Cursors.IBeam;
            DescriptionrichTextBox.Location = new Point(140, 78);
            DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            DescriptionrichTextBox.Size = new Size(125, 48);
            DescriptionrichTextBox.TabIndex = 10;
            DescriptionrichTextBox.Text = "";
            // 
            // DuedateTimePicker
            // 
            DuedateTimePicker.CalendarMonthBackground = Color.LavenderBlush;
            DuedateTimePicker.CalendarTitleBackColor = Color.LavenderBlush;
            DuedateTimePicker.CalendarTrailingForeColor = SystemColors.WindowText;
            DuedateTimePicker.Cursor = Cursors.Hand;
            DuedateTimePicker.Location = new Point(140, 161);
            DuedateTimePicker.Name = "DuedateTimePicker";
            DuedateTimePicker.Size = new Size(125, 23);
            DuedateTimePicker.TabIndex = 11;
            // 
            // StatuscomboBox
            // 
            StatuscomboBox.BackColor = Color.LavenderBlush;
            StatuscomboBox.Cursor = Cursors.Hand;
            StatuscomboBox.FormattingEnabled = true;
            StatuscomboBox.Location = new Point(140, 190);
            StatuscomboBox.Name = "StatuscomboBox";
            StatuscomboBox.Size = new Size(125, 23);
            StatuscomboBox.TabIndex = 12;
            // 
            // AssignedUsercomboBox
            // 
            AssignedUsercomboBox.BackColor = Color.LavenderBlush;
            AssignedUsercomboBox.Cursor = Cursors.Hand;
            AssignedUsercomboBox.FormattingEnabled = true;
            AssignedUsercomboBox.Location = new Point(140, 222);
            AssignedUsercomboBox.Name = "AssignedUsercomboBox";
            AssignedUsercomboBox.Size = new Size(125, 23);
            AssignedUsercomboBox.TabIndex = 13;
            // 
            // PrioritycomboBox
            // 
            PrioritycomboBox.BackColor = Color.LavenderBlush;
            PrioritycomboBox.Cursor = Cursors.Hand;
            PrioritycomboBox.FormattingEnabled = true;
            PrioritycomboBox.Location = new Point(140, 251);
            PrioritycomboBox.Name = "PrioritycomboBox";
            PrioritycomboBox.Size = new Size(125, 23);
            PrioritycomboBox.TabIndex = 14;
            // 
            // ComplexitycomboBox
            // 
            ComplexitycomboBox.BackColor = Color.LavenderBlush;
            ComplexitycomboBox.Cursor = Cursors.Hand;
            ComplexitycomboBox.FormattingEnabled = true;
            ComplexitycomboBox.Location = new Point(140, 280);
            ComplexitycomboBox.Name = "ComplexitycomboBox";
            ComplexitycomboBox.Size = new Size(125, 23);
            ComplexitycomboBox.TabIndex = 15;
            // 
            // CategorycomboBox
            // 
            CategorycomboBox.BackColor = Color.LavenderBlush;
            CategorycomboBox.Cursor = Cursors.Hand;
            CategorycomboBox.FormattingEnabled = true;
            CategorycomboBox.Location = new Point(140, 309);
            CategorycomboBox.Name = "CategorycomboBox";
            CategorycomboBox.Size = new Size(125, 23);
            CategorycomboBox.TabIndex = 16;
            // 
            // RemindercheckBox
            // 
            RemindercheckBox.AutoSize = true;
            RemindercheckBox.BackColor = Color.LavenderBlush;
            RemindercheckBox.Cursor = Cursors.Hand;
            RemindercheckBox.Font = new Font("Segoe UI", 9.75F);
            RemindercheckBox.Location = new Point(582, 234);
            RemindercheckBox.Name = "RemindercheckBox";
            RemindercheckBox.Size = new Size(184, 21);
            RemindercheckBox.TabIndex = 17;
            RemindercheckBox.Text = "Check me For Remindering";
            RemindercheckBox.UseVisualStyleBackColor = false;
            RemindercheckBox.CheckedChanged += RemindercheckBox_CheckedChanged;
            // 
            // Savebutton
            // 
            Savebutton.BackColor = Color.BlueViolet;
            Savebutton.Cursor = Cursors.Hand;
            Savebutton.FlatStyle = FlatStyle.Popup;
            Savebutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Savebutton.ForeColor = SystemColors.ButtonHighlight;
            Savebutton.Location = new Point(639, 269);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(75, 33);
            Savebutton.TabIndex = 18;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // TaskdataGridView
            // 
            TaskdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskdataGridView.Location = new Point(566, 63);
            TaskdataGridView.Name = "TaskdataGridView";
            TaskdataGridView.Size = new Size(222, 150);
            TaskdataGridView.TabIndex = 19;
            TaskdataGridView.CellClick += TaskdataGridView_CellClick;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.BlueViolet;
            Updatebutton.Cursor = Cursors.Hand;
            Updatebutton.FlatStyle = FlatStyle.Popup;
            Updatebutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Updatebutton.ForeColor = SystemColors.ButtonHighlight;
            Updatebutton.Location = new Point(639, 312);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(75, 33);
            Updatebutton.TabIndex = 20;
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
            Deletebutton.Location = new Point(639, 357);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(75, 33);
            Deletebutton.TabIndex = 21;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // CreatedAtdateTimePicker
            // 
            CreatedAtdateTimePicker.CalendarMonthBackground = Color.LavenderBlush;
            CreatedAtdateTimePicker.CalendarTitleBackColor = Color.LavenderBlush;
            CreatedAtdateTimePicker.CalendarTrailingForeColor = SystemColors.WindowText;
            CreatedAtdateTimePicker.Cursor = Cursors.Hand;
            CreatedAtdateTimePicker.Location = new Point(140, 132);
            CreatedAtdateTimePicker.Name = "CreatedAtdateTimePicker";
            CreatedAtdateTimePicker.Size = new Size(125, 23);
            CreatedAtdateTimePicker.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(18, 136);
            label10.Name = "label10";
            label10.Size = new Size(70, 17);
            label10.TabIndex = 23;
            label10.Text = "Created At";
            // 
            // OpenRemindersbutton
            // 
            OpenRemindersbutton.BackColor = Color.BlueViolet;
            OpenRemindersbutton.Cursor = Cursors.Hand;
            OpenRemindersbutton.FlatStyle = FlatStyle.Popup;
            OpenRemindersbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            OpenRemindersbutton.ForeColor = SystemColors.ButtonHighlight;
            OpenRemindersbutton.Location = new Point(566, 414);
            OpenRemindersbutton.Name = "OpenRemindersbutton";
            OpenRemindersbutton.Size = new Size(124, 33);
            OpenRemindersbutton.TabIndex = 25;
            OpenRemindersbutton.Text = "Open Reminders";
            OpenRemindersbutton.UseVisualStyleBackColor = false;
            OpenRemindersbutton.Click += OpenRemindersbutton_Click;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = Color.BlueViolet;
            Logoutbutton.Cursor = Cursors.Hand;
            Logoutbutton.FlatStyle = FlatStyle.Popup;
            Logoutbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Logoutbutton.ForeColor = SystemColors.ButtonHighlight;
            Logoutbutton.Location = new Point(713, 414);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Size = new Size(75, 33);
            Logoutbutton.TabIndex = 26;
            Logoutbutton.Text = "Logout";
            Logoutbutton.UseVisualStyleBackColor = false;
            Logoutbutton.Click += Logoutbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(278, 18);
            label11.Name = "label11";
            label11.Size = new Size(165, 21);
            label11.TabIndex = 28;
            label11.Text = "Manager Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(TitletextBox);
            panel1.Controls.Add(DescriptionrichTextBox);
            panel1.Controls.Add(CreatedAtdateTimePicker);
            panel1.Controls.Add(DuedateTimePicker);
            panel1.Controls.Add(StatuscomboBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(AssignedUsercomboBox);
            panel1.Controls.Add(PrioritycomboBox);
            panel1.Controls.Add(ComplexitycomboBox);
            panel1.Controls.Add(CategorycomboBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(278, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 384);
            panel1.TabIndex = 29;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 457);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(Logoutbutton);
            Controls.Add(OpenRemindersbutton);
            Controls.Add(Deletebutton);
            Controls.Add(Updatebutton);
            Controls.Add(TaskdataGridView);
            Controls.Add(Savebutton);
            Controls.Add(RemindercheckBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Dashboard";
            ((System.ComponentModel.ISupportInitialize)TaskdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TitletextBox;
        private RichTextBox DescriptionrichTextBox;
        private DateTimePicker DuedateTimePicker;
        private ComboBox StatuscomboBox;
        private ComboBox AssignedUsercomboBox;
        private ComboBox PrioritycomboBox;
        private ComboBox ComplexitycomboBox;
        private ComboBox CategorycomboBox;
        private CheckBox RemindercheckBox;
        private Button Savebutton;
        private DataGridView TaskdataGridView;
        private Button Updatebutton;
        private Button Deletebutton;
        private DateTimePicker CreatedAtdateTimePicker;
        private Label label10;
        private Button OpenRemindersbutton;
        private Button Logoutbutton;
        private PictureBox pictureBox1;
        private Label label11;
        private Panel panel1;
    }
}