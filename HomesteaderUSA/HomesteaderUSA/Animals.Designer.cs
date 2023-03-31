namespace HomesteaderUSA
{
    partial class Animals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animals));
            TopPanel = new Panel();
            CloseProgram = new Label();
            label1 = new Label();
            SidePanel = new Panel();
            label4 = new Label();
            panel10 = new Panel();
            HealthTab = new Label();
            panel9 = new Panel();
            AnimalTabLabel = new Label();
            panel7 = new Panel();
            MilkTab = new Label();
            panel3 = new Panel();
            ProductLogTab = new Label();
            panel1 = new Panel();
            BreedTabLabel = new Label();
            panel4 = new Panel();
            DashboardTab = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            label3 = new Label();
            AnimalsDGV = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            DOBTb = new DateTimePicker();
            comboBox1 = new ComboBox();
            label15 = new Label();
            comboBox2 = new ComboBox();
            Save = new Button();
            Edit = new Button();
            Delete = new Button();
            Clear = new Button();
            TopPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalsDGV).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(CloseProgram);
            TopPanel.Controls.Add(label1);
            TopPanel.Location = new Point(2, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1159, 44);
            TopPanel.TabIndex = 1;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1126, 0);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 2;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(503, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 0;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Maroon;
            SidePanel.Controls.Add(label4);
            SidePanel.Controls.Add(panel10);
            SidePanel.Controls.Add(panel9);
            SidePanel.Controls.Add(panel7);
            SidePanel.Controls.Add(panel3);
            SidePanel.Controls.Add(panel1);
            SidePanel.Controls.Add(panel4);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(-7, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(209, 700);
            SidePanel.TabIndex = 2;
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
            // panel10
            // 
            panel10.Controls.Add(HealthTab);
            panel10.Location = new Point(0, 427);
            panel10.Name = "panel10";
            panel10.Size = new Size(209, 60);
            panel10.TabIndex = 9;
            panel10.Paint += panel10_Paint;
            // 
            // HealthTab
            // 
            HealthTab.AutoSize = true;
            HealthTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HealthTab.ForeColor = SystemColors.ButtonFace;
            HealthTab.Location = new Point(49, 23);
            HealthTab.Name = "HealthTab";
            HealthTab.Size = new Size(103, 19);
            HealthTab.TabIndex = 12;
            HealthTab.Text = "Health Log";
            HealthTab.Click += HealthTab_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Control;
            panel9.Controls.Add(AnimalTabLabel);
            panel9.Location = new Point(0, 189);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 60);
            panel9.TabIndex = 13;
            panel9.Paint += panel9_Paint;
            // 
            // AnimalTabLabel
            // 
            AnimalTabLabel.AutoSize = true;
            AnimalTabLabel.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AnimalTabLabel.ForeColor = Color.Maroon;
            AnimalTabLabel.Location = new Point(52, 20);
            AnimalTabLabel.Name = "AnimalTabLabel";
            AnimalTabLabel.Size = new Size(102, 25);
            AnimalTabLabel.TabIndex = 11;
            AnimalTabLabel.Text = "Animals";
            AnimalTabLabel.Click += AnimalTabLabel_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(MilkTab);
            panel7.Location = new Point(0, 267);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 60);
            panel7.TabIndex = 12;
            panel7.Paint += panel7_Paint;
            // 
            // MilkTab
            // 
            MilkTab.AutoSize = true;
            MilkTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MilkTab.ForeColor = SystemColors.ButtonFace;
            MilkTab.Location = new Point(31, 20);
            MilkTab.Name = "MilkTab";
            MilkTab.Size = new Size(148, 19);
            MilkTab.TabIndex = 12;
            MilkTab.Text = "Milk Production";
            MilkTab.Click += MilkTab_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ProductLogTab);
            panel3.Location = new Point(0, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 60);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // ProductLogTab
            // 
            ProductLogTab.AutoSize = true;
            ProductLogTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductLogTab.ForeColor = SystemColors.ButtonFace;
            ProductLogTab.Location = new Point(40, 20);
            ProductLogTab.Name = "ProductLogTab";
            ProductLogTab.Size = new Size(114, 19);
            ProductLogTab.TabIndex = 12;
            ProductLogTab.Text = "Product Log";
            ProductLogTab.Click += ProductLogTab_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BreedTabLabel);
            panel1.Location = new Point(0, 509);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 60);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // BreedTabLabel
            // 
            BreedTabLabel.AutoSize = true;
            BreedTabLabel.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BreedTabLabel.ForeColor = SystemColors.ButtonFace;
            BreedTabLabel.Location = new Point(40, 18);
            BreedTabLabel.Name = "BreedTabLabel";
            BreedTabLabel.Size = new Size(122, 19);
            BreedTabLabel.TabIndex = 12;
            BreedTabLabel.Text = "Breeding Log";
            BreedTabLabel.Click += BreedTabLabel_Click;
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
            // DashboardTab
            // 
            DashboardTab.AutoSize = true;
            DashboardTab.BackColor = Color.Maroon;
            DashboardTab.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DashboardTab.ForeColor = SystemColors.ButtonFace;
            DashboardTab.Location = new Point(52, 19);
            DashboardTab.Name = "DashboardTab";
            DashboardTab.Size = new Size(100, 19);
            DashboardTab.TabIndex = 12;
            DashboardTab.Text = "Dashboard";
            DashboardTab.Click += DashboardTab_Click;
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
            // panel5
            // 
            panel5.Controls.Add(panel2);
            panel5.Location = new Point(-1, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 60);
            panel5.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 60);
            panel2.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Location = new Point(-1, 255);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 60);
            panel6.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Location = new Point(2, 372);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 60);
            panel8.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(220, 47);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 11;
            label2.Text = "Manage Animals";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 304);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 12;
            label3.Text = "Animal List";
            // 
            // AnimalsDGV
            // 
            AnimalsDGV.BackgroundColor = SystemColors.ButtonFace;
            AnimalsDGV.BorderStyle = BorderStyle.Fixed3D;
            AnimalsDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            AnimalsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalsDGV.Location = new Point(208, 330);
            AnimalsDGV.Name = "AnimalsDGV";
            AnimalsDGV.RowTemplate.Height = 25;
            AnimalsDGV.Size = new Size(906, 350);
            AnimalsDGV.TabIndex = 13;
            AnimalsDGV.CellContentClick += AnimalsDGV_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(232, 96);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 14;
            label5.Text = "Animal Name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(401, 96);
            label6.Name = "label6";
            label6.Size = new Size(76, 19);
            label6.TabIndex = 15;
            label6.Text = "Ear Tag";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(567, 96);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 16;
            label7.Text = "Type";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(1021, 96);
            label8.Name = "label8";
            label8.Size = new Size(107, 19);
            label8.TabIndex = 17;
            label8.Text = "Description";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(884, 96);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 18;
            label9.Text = "Breed";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(267, 178);
            label10.Name = "label10";
            label10.Size = new Size(118, 19);
            label10.TabIndex = 19;
            label10.Text = "Date of Birth";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(461, 178);
            label11.Name = "label11";
            label11.Size = new Size(40, 19);
            label11.TabIndex = 20;
            label11.Text = "Age";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(551, 178);
            label12.Name = "label12";
            label12.Size = new Size(101, 19);
            label12.TabIndex = 21;
            label12.Text = "Wt at birth";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Maroon;
            label13.Location = new Point(696, 178);
            label13.Name = "label13";
            label13.Size = new Size(84, 19);
            label13.TabIndex = 22;
            label13.Text = "Location";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(952, 178);
            label14.Name = "label14";
            label14.Size = new Size(56, 19);
            label14.TabIndex = 23;
            label14.Text = "Notes";
            label14.Click += label14_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 23);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(365, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1004, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(845, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 23);
            textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(439, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(75, 23);
            textBox5.TabIndex = 28;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(556, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(79, 23);
            textBox6.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(673, 217);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(134, 23);
            textBox7.TabIndex = 30;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(845, 217);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 23);
            textBox8.TabIndex = 31;
            // 
            // DOBTb
            // 
            DOBTb.Location = new Point(220, 214);
            DOBTb.Name = "DOBTb";
            DOBTb.Size = new Size(190, 23);
            DOBTb.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cow", "Chicken", "Pig", "Goat", "Turkey", "Rabbit", "Dog", "Cat", "Horse", "Duck", "Geese", "Quail", "Other", "" });
            comboBox1.Location = new Point(531, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(712, 96);
            label15.Name = "label15";
            label15.Size = new Size(78, 19);
            label15.TabIndex = 34;
            label15.Text = "Purpose";
            label15.Click += label15_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Milk", "Meat", "Eggs", "Breeding", "Sales", "Breeding/Milk", "Wool", "Working Animal", "Pet", "Other" });
            comboBox2.Location = new Point(686, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 35;
            // 
            // Save
            // 
            Save.BackColor = Color.Maroon;
            Save.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(713, 267);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 36;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Maroon;
            Edit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = SystemColors.ButtonFace;
            Edit.Location = new Point(809, 267);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 39);
            Edit.TabIndex = 37;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Maroon;
            Delete.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(913, 267);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 38;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1019, 267);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 39);
            Clear.TabIndex = 39;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 702);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(comboBox2);
            Controls.Add(label15);
            Controls.Add(comboBox1);
            Controls.Add(DOBTb);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AnimalsDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SidePanel);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Animals";
            Text = "Animals";
            Load += Animals_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnimalsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label label1;
        private Panel SidePanel;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel7;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel10;
        private Label HealthTab;
        private Label AnimalTabLabel;
        private Label MilkTab;
        private Label ProductLogTab;
        private Label BreedTabLabel;
        private Label DashboardTab;
        private Label label4;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridView AnimalsDGV;
        private Label CloseProgram;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker DOBTb;
        private ComboBox comboBox1;
        private Label label15;
        private ComboBox comboBox2;
        private Button Save;
        private Button Edit;
        private Button Delete;
        private Button Clear;
    }
}