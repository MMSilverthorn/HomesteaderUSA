namespace HomesteaderUSA
{
    partial class Plants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plants));
            label2 = new Label();
            DashboardTab = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            panel6 = new Panel();
            OrchardTab = new Label();
            panel5 = new Panel();
            GreenhouseTab = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            FieldTab = new Label();
            panel2 = new Panel();
            MktGarTab = new Label();
            panel1 = new Panel();
            KitTab = new Label();
            CloseProgram = new Label();
            label1 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SidePanel.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(538, 295);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 34;
            label2.Text = "Coming Soon";
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
            pictureBox1.Location = new Point(33, 72);
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
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel5);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Controls.Add(panel2);
            SidePanel.Controls.Add(panel1);
            SidePanel.Location = new Point(-9, -31);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(200, 740);
            SidePanel.TabIndex = 33;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(OrchardTab);
            panel6.Location = new Point(3, 510);
            panel6.Name = "panel6";
            panel6.Size = new Size(209, 60);
            panel6.TabIndex = 39;
            panel6.Paint += panel6_Paint;
            // 
            // OrchardTab
            // 
            OrchardTab.AutoSize = true;
            OrchardTab.BackColor = Color.Maroon;
            OrchardTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrchardTab.ForeColor = SystemColors.ButtonFace;
            OrchardTab.Location = new Point(54, 17);
            OrchardTab.Name = "OrchardTab";
            OrchardTab.Size = new Size(79, 19);
            OrchardTab.TabIndex = 12;
            OrchardTab.Text = "Orchard";
            OrchardTab.Click += OrchardTab_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(GreenhouseTab);
            panel5.Location = new Point(3, 432);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 60);
            panel5.TabIndex = 38;
            panel5.Paint += panel5_Paint;
            // 
            // GreenhouseTab
            // 
            GreenhouseTab.AutoSize = true;
            GreenhouseTab.BackColor = Color.Maroon;
            GreenhouseTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GreenhouseTab.ForeColor = SystemColors.ButtonFace;
            GreenhouseTab.Location = new Point(38, 19);
            GreenhouseTab.Name = "GreenhouseTab";
            GreenhouseTab.Size = new Size(116, 19);
            GreenhouseTab.TabIndex = 12;
            GreenhouseTab.Text = "Greenhouses";
            GreenhouseTab.Click += GreenhouseTab_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(DashboardTab);
            panel4.Location = new Point(0, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 60);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(FieldTab);
            panel3.Location = new Point(3, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 60);
            panel3.TabIndex = 37;
            panel3.Paint += panel3_Paint;
            // 
            // FieldTab
            // 
            FieldTab.AutoSize = true;
            FieldTab.BackColor = Color.Maroon;
            FieldTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FieldTab.ForeColor = SystemColors.ButtonFace;
            FieldTab.Location = new Point(61, 18);
            FieldTab.Name = "FieldTab";
            FieldTab.Size = new Size(61, 19);
            FieldTab.TabIndex = 12;
            FieldTab.Text = "Fields";
            FieldTab.Click += FieldTab_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(MktGarTab);
            panel2.Location = new Point(3, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 60);
            panel2.TabIndex = 36;
            panel2.Paint += panel2_Paint;
            // 
            // MktGarTab
            // 
            MktGarTab.AutoSize = true;
            MktGarTab.BackColor = Color.Maroon;
            MktGarTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MktGarTab.ForeColor = SystemColors.ButtonFace;
            MktGarTab.Location = new Point(34, 19);
            MktGarTab.Name = "MktGarTab";
            MktGarTab.Size = new Size(140, 19);
            MktGarTab.TabIndex = 12;
            MktGarTab.Text = "MarketGardens";
            MktGarTab.Click += MktGarTab_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(KitTab);
            panel1.Location = new Point(3, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 60);
            panel1.TabIndex = 35;
            panel1.Paint += panel1_Paint;
            // 
            // KitTab
            // 
            KitTab.AutoSize = true;
            KitTab.BackColor = Color.Maroon;
            KitTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KitTab.ForeColor = SystemColors.ButtonFace;
            KitTab.Location = new Point(34, 20);
            KitTab.Name = "KitTab";
            KitTab.Size = new Size(150, 19);
            KitTab.TabIndex = 12;
            KitTab.Text = "Kitchen Gardens";
            KitTab.Click += KitTab_Click;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1108, 9);
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
            label1.Location = new Point(506, 9);
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
            Clear.Location = new Point(993, 248);
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
            Delete.Location = new Point(887, 248);
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
            Edit.Location = new Point(783, 248);
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
            Save.Location = new Point(687, 248);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 40;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // Plants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 698);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Plants";
            Text = "Plants";
            Load += Plants_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label OrchardTab;
        private Panel panel5;
        private Label GreenhouseTab;
        private Panel panel3;
        private Label FieldTab;
        private Panel panel2;
        private Label MktGarTab;
        private Panel panel1;
        private Label KitTab;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
    }
}