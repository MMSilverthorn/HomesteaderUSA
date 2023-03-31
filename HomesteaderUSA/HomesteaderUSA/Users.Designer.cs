namespace HomesteaderUSA
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            label2 = new Label();
            DashboardTab = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            panel4 = new Panel();
            CloseProgram = new Label();
            label1 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            ProductDGV = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SidePanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(229, 56);
            label2.Name = "label2";
            label2.Size = new Size(151, 23);
            label2.TabIndex = 34;
            label2.Text = "Manage Users";
            label2.Click += label2_Click;
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
            // SidePanel
            // 
            SidePanel.BackColor = Color.Maroon;
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(-5, -5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(216, 708);
            SidePanel.TabIndex = 33;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardTab);
            panel4.Location = new Point(0, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 60);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1131, 9);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 32;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(507, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 31;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1031, 218);
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
            Delete.Location = new Point(925, 218);
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
            Edit.Location = new Point(821, 218);
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
            Save.Location = new Point(725, 218);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 40;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // ProductDGV
            // 
            ProductDGV.BackgroundColor = SystemColors.ButtonFace;
            ProductDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Location = new Point(217, 264);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowTemplate.Height = 25;
            ProductDGV.Size = new Size(922, 414);
            ProductDGV.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 234);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 45;
            label3.Text = " User List";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 698);
            Controls.Add(ProductDGV);
            Controls.Add(label3);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label DashboardTab;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel SidePanel;
        private Panel panel4;
        private Label CloseProgram;
        private Label label1;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
        private DataGridView ProductDGV;
        private Label label3;
    }
}