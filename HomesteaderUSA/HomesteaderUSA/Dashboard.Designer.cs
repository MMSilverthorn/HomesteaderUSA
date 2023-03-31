namespace HomesteaderUSA
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BottomPanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            DashboardLabel = new Label();
            label1 = new Label();
            TopPanel = new Panel();
            CloseProgram = new Label();
            label2 = new Label();
            BottomPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.Maroon;
            BottomPanel.Controls.Add(label6);
            BottomPanel.Controls.Add(label5);
            BottomPanel.Controls.Add(label4);
            BottomPanel.Controls.Add(label3);
            BottomPanel.Location = new Point(0, 556);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(1159, 108);
            BottomPanel.TabIndex = 1;
            BottomPanel.Paint += BottomPanel_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(976, 40);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 4;
            label6.Text = "Journal";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(662, 40);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 3;
            label5.Text = "Finances";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(385, 40);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 2;
            label4.Text = "Plants";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(117, 40);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 1;
            label3.Text = "Animals";
            label3.Click += label3_Click;
            // 
            // DashboardLabel
            // 
            DashboardLabel.AutoSize = true;
            DashboardLabel.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardLabel.Location = new Point(523, 513);
            DashboardLabel.Name = "DashboardLabel";
            DashboardLabel.Size = new Size(150, 30);
            DashboardLabel.TabIndex = 2;
            DashboardLabel.Text = "Dashboard";
            DashboardLabel.Click += DashboardLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(316, 38);
            label1.Name = "label1";
            label1.Size = new Size(549, 76);
            label1.TabIndex = 0;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(CloseProgram);
            TopPanel.Controls.Add(label1);
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1159, 145);
            TopPanel.TabIndex = 0;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1127, 9);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 1;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(719, 432);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 6;
            label2.Text = "Ver 1.0  ";
            label2.Click += label2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1159, 658);
            Controls.Add(label2);
            Controls.Add(DashboardLabel);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel BottomPanel;
        private Label label4;
        private Label label3;
        private Label DashboardLabel;
        private Label label6;
        private Label label5;
        private Label label1;
        private Panel TopPanel;
        private Label label2;
        private Label CloseProgram;
    }
}