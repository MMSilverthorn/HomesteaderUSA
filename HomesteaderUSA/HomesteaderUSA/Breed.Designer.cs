namespace HomesteaderUSA
{
    partial class Breed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Breed));
            BreedDGV = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            DashboardTab = new Label();
            panel4 = new Panel();
            BreedTabLabel = new Label();
            panel1 = new Panel();
            MilkTab = new Label();
            panel7 = new Panel();
            AnimalTabLabel = new Label();
            panel9 = new Panel();
            HealthTab = new Label();
            panel10 = new Panel();
            ProductLogTab = new Label();
            panel3 = new Panel();
            SidePanel = new Panel();
            label4 = new Label();
            CloseProgram = new Label();
            label1 = new Label();
            label3 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            textBox8 = new TextBox();
            label14 = new Label();
            Date = new DateTimePicker();
            label10 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker5 = new DateTimePicker();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)BreedDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            SidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // BreedDGV
            // 
            BreedDGV.BackgroundColor = SystemColors.ButtonFace;
            BreedDGV.BorderStyle = BorderStyle.Fixed3D;
            BreedDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            BreedDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BreedDGV.Location = new Point(229, 333);
            BreedDGV.Name = "BreedDGV";
            BreedDGV.RowTemplate.Height = 25;
            BreedDGV.Size = new Size(922, 363);
            BreedDGV.TabIndex = 32;
            BreedDGV.CellContentClick += BreedDGV_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(229, 50);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 30;
            label2.Text = "Breed Record";
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
            panel4.Paint += panel4_Paint;
            // 
            // BreedTabLabel
            // 
            BreedTabLabel.AutoSize = true;
            BreedTabLabel.BackColor = Color.Transparent;
            BreedTabLabel.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BreedTabLabel.ForeColor = Color.Maroon;
            BreedTabLabel.Location = new Point(32, 18);
            BreedTabLabel.Name = "BreedTabLabel";
            BreedTabLabel.Size = new Size(156, 25);
            BreedTabLabel.TabIndex = 12;
            BreedTabLabel.Text = "Breeding Log";
            BreedTabLabel.Click += BreedTabLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(BreedTabLabel);
            panel1.Location = new Point(0, 509);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 60);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // MilkTab
            // 
            MilkTab.AutoSize = true;
            MilkTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MilkTab.ForeColor = SystemColors.ButtonFace;
            MilkTab.Location = new Point(40, 20);
            MilkTab.Name = "MilkTab";
            MilkTab.Size = new Size(148, 19);
            MilkTab.TabIndex = 12;
            MilkTab.Text = "Milk Production";
            MilkTab.Click += MilkTab_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Maroon;
            panel7.Controls.Add(MilkTab);
            panel7.Location = new Point(0, 267);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 60);
            panel7.TabIndex = 12;
            panel7.Paint += panel7_Paint;
            // 
            // AnimalTabLabel
            // 
            AnimalTabLabel.AutoSize = true;
            AnimalTabLabel.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AnimalTabLabel.ForeColor = SystemColors.ButtonFace;
            AnimalTabLabel.Location = new Point(63, 20);
            AnimalTabLabel.Name = "AnimalTabLabel";
            AnimalTabLabel.Size = new Size(77, 19);
            AnimalTabLabel.TabIndex = 11;
            AnimalTabLabel.Text = "Animals";
            AnimalTabLabel.Click += AnimalTabLabel_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Maroon;
            panel9.Controls.Add(AnimalTabLabel);
            panel9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panel9.Location = new Point(0, 189);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 60);
            panel9.TabIndex = 13;
            panel9.Paint += panel9_Paint;
            // 
            // HealthTab
            // 
            HealthTab.AutoSize = true;
            HealthTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HealthTab.ForeColor = SystemColors.ButtonFace;
            HealthTab.Location = new Point(51, 23);
            HealthTab.Name = "HealthTab";
            HealthTab.Size = new Size(103, 19);
            HealthTab.TabIndex = 12;
            HealthTab.Text = "Health Log";
            HealthTab.Click += HealthTab_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(HealthTab);
            panel10.Location = new Point(0, 427);
            panel10.Name = "panel10";
            panel10.Size = new Size(209, 60);
            panel10.TabIndex = 9;
            panel10.Paint += panel10_Paint;
            // 
            // ProductLogTab
            // 
            ProductLogTab.AutoSize = true;
            ProductLogTab.BackColor = Color.Transparent;
            ProductLogTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductLogTab.ForeColor = SystemColors.ButtonFace;
            ProductLogTab.Location = new Point(51, 18);
            ProductLogTab.Name = "ProductLogTab";
            ProductLogTab.Size = new Size(114, 19);
            ProductLogTab.TabIndex = 12;
            ProductLogTab.Text = "Product Log";
            ProductLogTab.Click += ProductLogTab_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(ProductLogTab);
            panel3.Location = new Point(0, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 60);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Maroon;
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel10);
            SidePanel.Controls.Add(panel9);
            SidePanel.Controls.Add(panel7);
            SidePanel.Controls.Add(panel1);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(-5, -5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(216, 708);
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
            CloseProgram.Location = new Point(1120, 9);
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
            label1.Location = new Point(539, 9);
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
            label3.Location = new Point(229, 307);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 31;
            label3.Text = "Breeding Log";
            label3.Click += label3_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1020, 271);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 39);
            Clear.TabIndex = 49;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Maroon;
            Delete.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(914, 271);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 48;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Maroon;
            Edit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = SystemColors.ButtonFace;
            Edit.Location = new Point(810, 271);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 39);
            Edit.TabIndex = 47;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            Save.BackColor = Color.Maroon;
            Save.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(714, 271);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 46;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(601, 214);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 23);
            textBox8.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(488, 214);
            label14.Name = "label14";
            label14.Size = new Size(83, 19);
            label14.TabIndex = 42;
            label14.Text = "Remarks";
            // 
            // Date
            // 
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(934, 142);
            Date.Name = "Date";
            Date.Size = new Size(102, 23);
            Date.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(914, 110);
            label10.Name = "label10";
            label10.Size = new Size(141, 19);
            label10.TabIndex = 58;
            label10.Text = "Expected  Date ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(459, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(459, 110);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 55;
            label6.Text = "Animal Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(305, 110);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 54;
            label5.Text = "Animal Id";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1295, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(1318, 93);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 64;
            label7.Text = "Date ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(1149, 214);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(102, 23);
            dateTimePicker2.TabIndex = 71;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(1172, 182);
            label11.Name = "label11";
            label11.Size = new Size(53, 19);
            label11.TabIndex = 70;
            label11.Text = "Date ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(305, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 24);
            comboBox1.TabIndex = 74;
            comboBox1.Text = "Choose One";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(636, 142);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(102, 23);
            dateTimePicker3.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(636, 110);
            label8.Name = "label8";
            label8.Size = new Size(93, 19);
            label8.TabIndex = 75;
            label8.Text = "Heat Date";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(781, 140);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(102, 23);
            dateTimePicker4.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(781, 110);
            label9.Name = "label9";
            label9.Size = new Size(101, 19);
            label9.TabIndex = 77;
            label9.Text = "Breed Datr";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(305, 233);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(102, 23);
            dateTimePicker5.TabIndex = 80;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(305, 204);
            label12.Name = "label12";
            label12.Size = new Size(80, 19);
            label12.TabIndex = 79;
            label12.Text = "Delivery";
            // 
            // Breed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 699);
            Controls.Add(dateTimePicker5);
            Controls.Add(label12);
            Controls.Add(dateTimePicker4);
            Controls.Add(label9);
            Controls.Add(dateTimePicker3);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(Date);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(BreedDGV);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Breed";
            Text = "Breed";
            Load += Breed_Load;
            ((System.ComponentModel.ISupportInitialize)BreedDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BreedDGV;
        private Label label2;
        private PictureBox pictureBox1;
        private Label DashboardTab;
        private Panel panel4;
        private Label BreedTabLabel;
        private Panel panel1;
        private Label MilkTab;
        private Panel panel7;
        private Label AnimalTabLabel;
        private Panel panel9;
        private Label HealthTab;
        private Panel panel10;
        private Label ProductLogTab;
        private Panel panel3;
        private Panel SidePanel;
        private Label label4;
        private Label CloseProgram;
        private Label label1;
        private Label label3;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
        private TextBox textBox8;
        private Label label14;
        private DateTimePicker Date;
        private Label label10;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private DateTimePicker dateTimePicker4;
        private Label label9;
        private DateTimePicker dateTimePicker5;
        private Label label12;
    }
}