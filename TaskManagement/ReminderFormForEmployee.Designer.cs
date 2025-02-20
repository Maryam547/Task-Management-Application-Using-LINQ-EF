namespace TaskManagement
{
    partial class ReminderFormForEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderFormForEmployee));
            ReminderGridView = new DataGridView();
            Markbutton = new Button();
            Backbutton = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ReminderGridView
            // 
            ReminderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReminderGridView.Location = new Point(298, 128);
            ReminderGridView.Name = "ReminderGridView";
            ReminderGridView.Size = new Size(490, 192);
            ReminderGridView.TabIndex = 0;
            ReminderGridView.CellFormatting += ReminderGridView_CellFormatting;
            // 
            // Markbutton
            // 
            Markbutton.BackColor = Color.BlueViolet;
            Markbutton.Cursor = Cursors.Hand;
            Markbutton.FlatStyle = FlatStyle.Popup;
            Markbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Markbutton.ForeColor = SystemColors.ButtonHighlight;
            Markbutton.Location = new Point(298, 399);
            Markbutton.Name = "Markbutton";
            Markbutton.Size = new Size(104, 39);
            Markbutton.TabIndex = 1;
            Markbutton.Text = "Mark as read";
            Markbutton.UseVisualStyleBackColor = false;
            Markbutton.Click += Markbutton_Click;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.BlueViolet;
            Backbutton.Cursor = Cursors.Hand;
            Backbutton.FlatStyle = FlatStyle.Popup;
            Backbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Backbutton.ForeColor = SystemColors.ButtonHighlight;
            Backbutton.Location = new Point(713, 399);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(75, 39);
            Backbutton.TabIndex = 2;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, -3);
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
            label5.Location = new Point(298, 24);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 17;
            label5.Text = "Employee Reminder";
            // 
            // ReminderFormForEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(Backbutton);
            Controls.Add(Markbutton);
            Controls.Add(ReminderGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReminderFormForEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Reminder";
            Load += ReminderFormForEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReminderGridView;
        private Button Markbutton;
        private Button Backbutton;
        private PictureBox pictureBox1;
        private Label label5;
    }
}