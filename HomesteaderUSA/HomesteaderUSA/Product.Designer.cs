namespace HomesteaderUSA
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            CloseProgram = new Label();
            label1 = new Label();
            label4 = new Label();
            SidePanel = new Panel();
            panel3 = new Panel();
            ProductLogTab = new Label();
            panel10 = new Panel();
            HealthTab = new Label();
            panel9 = new Panel();
            AnimalTabLabel = new Label();
            panel7 = new Panel();
            MilkTab = new Label();
            panel1 = new Panel();
            BreedTabLabel = new Label();
            panel4 = new Panel();
            DashboardTab = new Label();
            pictureBox1 = new PictureBox();
            ProductDGV = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            Clear = new Button();
            Delete = new Button();
            Edit = new Button();
            Save = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label15 = new Label();
            comboBox1 = new ComboBox();
            textBox8 = new TextBox();
            label14 = new Label();
            comboBox3 = new ComboBox();
            SidePanel.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            SuspendLayout();
            // 
            // CloseProgram
            // 
            CloseProgram.AutoSize = true;
            CloseProgram.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CloseProgram.Location = new Point(1123, 9);
            CloseProgram.Name = "CloseProgram";
            CloseProgram.Size = new Size(20, 21);
            CloseProgram.TabIndex = 22;
            CloseProgram.Text = "X";
            CloseProgram.Click += CloseProgram_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 30);
            label1.TabIndex = 0;
            label1.Text = "HomesteadUSA";
            label1.Click += label1_Click;
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
            SidePanel.Location = new Point(-6, -5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(209, 708);
            SidePanel.TabIndex = 23;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(ProductLogTab);
            panel3.Location = new Point(0, 345);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 60);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // ProductLogTab
            // 
            ProductLogTab.AutoSize = true;
            ProductLogTab.BackColor = SystemColors.ButtonFace;
            ProductLogTab.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ProductLogTab.ForeColor = Color.Maroon;
            ProductLogTab.Location = new Point(27, 20);
            ProductLogTab.Name = "ProductLogTab";
            ProductLogTab.Size = new Size(145, 25);
            ProductLogTab.TabIndex = 12;
            ProductLogTab.Text = "Product Log";
            ProductLogTab.Click += ProductLogTab_Click;
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
            HealthTab.Location = new Point(51, 23);
            HealthTab.Name = "HealthTab";
            HealthTab.Size = new Size(103, 19);
            HealthTab.TabIndex = 12;
            HealthTab.Text = "Health Log";
            HealthTab.Click += HealthTab_Click;
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
            DashboardTab.Location = new Point(54, 17);
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
            // ProductDGV
            // 
            ProductDGV.BackgroundColor = SystemColors.ButtonFace;
            ProductDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Location = new Point(221, 282);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowTemplate.Height = 25;
            ProductDGV.Size = new Size(922, 414);
            ProductDGV.TabIndex = 26;
            ProductDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(221, 252);
            label3.Name = "label3";
            label3.Size = new Size(176, 23);
            label3.TabIndex = 25;
            label3.Text = " Production  Log";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(221, 50);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 24;
            label2.Text = "Non Milk Animal Production";
            // 
            // Clear
            // 
            Clear.BackColor = Color.Maroon;
            Clear.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = SystemColors.ButtonFace;
            Clear.Location = new Point(1002, 225);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 39);
            Clear.TabIndex = 58;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Maroon;
            Delete.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = SystemColors.ButtonFace;
            Delete.Location = new Point(903, 225);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 39);
            Delete.TabIndex = 57;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Maroon;
            Edit.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Edit.ForeColor = SystemColors.ButtonFace;
            Edit.Location = new Point(803, 225);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 39);
            Edit.TabIndex = 56;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            Save.BackColor = Color.Maroon;
            Save.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = SystemColors.ButtonFace;
            Save.Location = new Point(710, 225);
            Save.Name = "Save";
            Save.Size = new Size(75, 39);
            Save.TabIndex = 55;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(361, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(563, 113);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 52;
            label7.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(374, 110);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 51;
            label6.Text = "Animal Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(228, 113);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 50;
            label5.Text = "Animal Id";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Eggs", "Meat", "Manure", "Wool", "Young" });
            comboBox2.Location = new Point(690, 145);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 61;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(716, 110);
            label15.Name = "label15";
            label15.Size = new Size(78, 19);
            label15.TabIndex = 60;
            label15.Text = "Purpose";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cow", "Chicken", "Pig", "Goat", "Turkey", "Rabbit", "Duck", "Geese", "Quail", "Other" });
            comboBox1.Location = new Point(535, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 59;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(837, 149);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 23);
            textBox8.TabIndex = 63;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(944, 110);
            label14.Name = "label14";
            label14.Size = new Size(56, 19);
            label14.TabIndex = 62;
            label14.Text = "Notes";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.ButtonFace;
            comboBox3.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(228, 145);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(108, 24);
            comboBox3.TabIndex = 64;
            comboBox3.Text = "Choose One";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 701);
            Controls.Add(comboBox3);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(comboBox2);
            Controls.Add(label15);
            Controls.Add(comboBox1);
            Controls.Add(Clear);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Save);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CloseProgram);
            Controls.Add(label1);
            Controls.Add(SidePanel);
            Controls.Add(ProductDGV);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TopPanel;
        private Label CloseProgram;
        private Label label1;
        private Label label4;
        private Panel SidePanel;
        private Panel panel3;
        private Label ProductLogTab;
        private Panel panel10;
        private Label HealthTab;
        private Panel panel9;
        private Label AnimalTabLabel;
        private Panel panel7;
        private Label MilkTab;
        private Panel panel1;
        private Label BreedTabLabel;
        private Panel panel4;
        private Label DashboardTab;
        private PictureBox pictureBox1;
        private DataGridView ProductDGV;
        private Label label3;
        private Label label2;
        private Button Clear;
        private Button Delete;
        private Button Edit;
        private Button Save;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private Label label15;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private Label label14;
        private ComboBox comboBox3;
    }
}