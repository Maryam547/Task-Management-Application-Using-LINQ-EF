namespace TaskManagement
{
    partial class ReminderFormForManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderFormForManager));
            ReminderGridView = new DataGridView();
            Backbutton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            // 
            // Backbutton
            // 
            Backbutton.BackColor = Color.BlueViolet;
            Backbutton.Cursor = Cursors.Hand;
            Backbutton.FlatStyle = FlatStyle.Popup;
            Backbutton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Backbutton.ForeColor = SystemColors.ButtonHighlight;
            Backbutton.Location = new Point(713, 406);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(75, 39);
            Backbutton.TabIndex = 2;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(298, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 18;
            label1.Text = "Manager Reminder";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-15, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // ReminderFormForManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 457);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Backbutton);
            Controls.Add(ReminderGridView);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReminderFormForManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reminder Form";
            Load += ReminderForm_Load;
            ((System.ComponentModel.ISupportInitialize)ReminderGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReminderGridView;
        private Button Backbutton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}