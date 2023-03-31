namespace HomesteaderUSA
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            JournalDGV = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            DashboardTab = new Label();
            panel4 = new Panel();
            SidePanel = new Panel();
            label4 = new Label();
            CloseProgram = new Label();
            label1 = new Label();
            label3 = new Label();
            Date = new DateTimePicker();
            EntryTb = new TextBox();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)JournalDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // JournalDGV
            // 
            JournalDGV.BackgroundColor = Color.White;
            JournalDGV.BorderStyle = BorderStyle.Fixed3D;
            JournalDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            JournalDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JournalDGV.DataMember = "DateTb";
            JournalDGV.Location = new Point(214, 333);
            JournalDGV.Name = "JournalDGV";
            JournalDGV.RowTemplate.Height = 25;
            JournalDGV.Size = new Size(922, 363);
            JournalDGV.TabIndex = 32;
            JournalDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(214, 50);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 30;
            label2.Text = "Journal Entry";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DashboardTab
            // 
            DashboardTab.AutoSize = true;
            DashboardTab.BackColor = Color.Maroon;
            DashboardTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardTab.ForeColor = SystemColors.ButtonFace;
            DashboardTab.Location = new Point(54, 17);
            DashboardTab.Name = "DashboardTab";
            DashboardTab.Size = new Size(100, 19);
            DashboardTab.TabIndex = 12;
            DashboardTab.Text = "Dashboard";
            DashboardTab.Click += DashboardTab_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardTab);
            panel4.Location = new Point(0, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 60);
            panel4.TabIndex = 8;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Maroon;
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(-13, -5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(209, 708);
            SidePanel.TabIndex = 29;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(84, 665);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "Ver 1.0";
            label4.Click += label4_Click;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1116, 9);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 28;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(492, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 27;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(214, 307);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 31;
            label3.Text = " Journal log";
            label3.Click += label3_Click;
            // 
            // Date
            // 
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(234, 106);
            Date.Name = "Date";
            Date.Size = new Size(110, 23);
            Date.TabIndex = 33;
            Date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // EntryTb
            // 
            EntryTb.Location = new Point(403, 106);
            EntryTb.Multiline = true;
            EntryTb.Name = "EntryTb";
            EntryTb.Size = new Size(659, 118);
            EntryTb.TabIndex = 34;
            EntryTb.TextChanged += textBox1_TextChanged;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1007, 282);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 39);
            Clear.TabIndex = 43;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Maroon;
            Delete.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(901, 282);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 42;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Maroon;
            Edit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = SystemColors.ButtonFace;
            Edit.Location = new Point(797, 282);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 39);
            Edit.TabIndex = 41;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            Save.BackColor = Color.Maroon;
            Save.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(701, 282);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 40;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // Journal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 696);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(EntryTb);
            Controls.Add(Date);
            Controls.Add(JournalDGV);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Journal";
            Text = "Journal";
            Load += Journal_Load;
            ((System.ComponentModel.ISupportInitialize)JournalDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView JournalDGV;
        private Label label2;
        private PictureBox pictureBox1;
        private Label DashboardTab;
        private Panel panel4;
        private Panel SidePanel;
        private Label label4;
        private Label CloseProgram;
        private Label label1;
        private Label label3;
        private DateTimePicker Date;
        private TextBox EntryTb;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
    }
}