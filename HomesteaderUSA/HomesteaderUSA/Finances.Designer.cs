namespace HomesteaderUSA
{
    partial class Finances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finances));
            label2 = new Label();
            DashboardTab = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            panel6 = new Panel();
            UpcomingTab = new Label();
            panel5 = new Panel();
            BalanceTab = new Label();
            panel2 = new Panel();
            ExpensesTab = new Label();
            panel3 = new Panel();
            IncomeTab = new Label();
            panel1 = new Panel();
            SalesTab = new Label();
            panel4 = new Panel();
            CloseProgram = new Label();
            label1 = new Label();
            label9 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SidePanel.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 56);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 38;
            label2.Text = "Finances";
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
            SidePanel.Controls.Add(panel6);
            SidePanel.Controls.Add(panel5);
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel2);
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(panel1);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(-4, -5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(216, 708);
            SidePanel.TabIndex = 37;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(UpcomingTab);
            panel6.Location = new Point(7, 508);
            panel6.Name = "panel6";
            panel6.Size = new Size(209, 60);
            panel6.TabIndex = 39;
            panel6.Paint += panel6_Paint;
            // 
            // UpcomingTab
            // 
            UpcomingTab.AutoSize = true;
            UpcomingTab.BackColor = Color.Maroon;
            UpcomingTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpcomingTab.ForeColor = SystemColors.ButtonFace;
            UpcomingTab.Location = new Point(54, 17);
            UpcomingTab.Name = "UpcomingTab";
            UpcomingTab.Size = new Size(94, 19);
            UpcomingTab.TabIndex = 12;
            UpcomingTab.Text = "Upcoming";
            UpcomingTab.Click += UpcomingTab_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(BalanceTab);
            panel5.Location = new Point(7, 430);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 60);
            panel5.TabIndex = 42;
            panel5.Paint += panel5_Paint;
            // 
            // BalanceTab
            // 
            BalanceTab.AutoSize = true;
            BalanceTab.BackColor = Color.Maroon;
            BalanceTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceTab.ForeColor = SystemColors.ButtonFace;
            BalanceTab.Location = new Point(54, 17);
            BalanceTab.Name = "BalanceTab";
            BalanceTab.Size = new Size(84, 19);
            BalanceTab.TabIndex = 12;
            BalanceTab.Text = "Balances";
            BalanceTab.Click += BalanceTab_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ExpensesTab);
            panel2.Location = new Point(7, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 60);
            panel2.TabIndex = 40;
            panel2.Paint += panel2_Paint;
            // 
            // ExpensesTab
            // 
            ExpensesTab.AutoSize = true;
            ExpensesTab.BackColor = Color.Maroon;
            ExpensesTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpensesTab.ForeColor = SystemColors.ButtonFace;
            ExpensesTab.Location = new Point(54, 17);
            ExpensesTab.Name = "ExpensesTab";
            ExpensesTab.Size = new Size(87, 19);
            ExpensesTab.TabIndex = 12;
            ExpensesTab.Text = "Expenses";
            ExpensesTab.Click += ExpensesTab_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(IncomeTab);
            panel3.Location = new Point(7, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 60);
            panel3.TabIndex = 41;
            panel3.Paint += panel3_Paint;
            // 
            // IncomeTab
            // 
            IncomeTab.AutoSize = true;
            IncomeTab.BackColor = Color.Maroon;
            IncomeTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IncomeTab.ForeColor = SystemColors.ButtonFace;
            IncomeTab.Location = new Point(65, 18);
            IncomeTab.Name = "IncomeTab";
            IncomeTab.Size = new Size(70, 19);
            IncomeTab.TabIndex = 12;
            IncomeTab.Text = "Income";
            IncomeTab.Click += IncomeTab_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(SalesTab);
            panel1.Location = new Point(7, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 60);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // SalesTab
            // 
            SalesTab.AutoSize = true;
            SalesTab.BackColor = Color.Maroon;
            SalesTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SalesTab.ForeColor = SystemColors.ButtonFace;
            SalesTab.Location = new Point(65, 18);
            SalesTab.Name = "SalesTab";
            SalesTab.Size = new Size(53, 19);
            SalesTab.TabIndex = 12;
            SalesTab.Text = "Sales";
            SalesTab.Click += SalesTab_Click;
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
            CloseProgram.Location = new Point(1116, 9);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 36;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(508, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 35;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(549, 329);
            label9.Name = "label9";
            label9.Size = new Size(138, 30);
            label9.TabIndex = 39;
            label9.Text = "Coming Soon";
            label9.Click += label9_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(996, 266);
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
            Delete.Location = new Point(890, 266);
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
            Edit.Location = new Point(786, 266);
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
            Save.Location = new Point(690, 266);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 40;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 698);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finances";
            Text = "Finances";
            Load += Finances_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel6;
        private Label UpcomingTab;
        private Panel panel5;
        private Label BalanceTab;
        private Panel panel2;
        private Label ExpensesTab;
        private Panel panel3;
        private Label IncomeTab;
        private Panel panel1;
        private Label SalesTab;
        private Label label9;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
    }
}