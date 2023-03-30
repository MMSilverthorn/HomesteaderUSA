namespace HomesteaderUSA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginButton = new Button();
            label1 = new Label();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            ResetButton = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.ForestGreen;
            LoginButton.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(119, 325);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(89, 31);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 23);
            label1.TabIndex = 1;
            label1.Text = "HomesteaderUSA";
            label1.Click += label1_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(35, 202);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(82, 16);
            UserNameLabel.TabIndex = 2;
            UserNameLabel.Text = "User Name";
            UserNameLabel.Click += UserNameLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(35, 244);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(74, 16);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // ResetButton
            // 
            ResetButton.AutoSize = true;
            ResetButton.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.Location = new Point(134, 369);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(54, 16);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "RESET";
            ResetButton.Click += ResetButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.Font = new Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Employee" });
            comboBox1.Location = new Point(106, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 24);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Choose One";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(134, 195);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(121, 23);
            UserNameTextBox.TabIndex = 7;
            UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(134, 237);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(121, 23);
            PasswordTextBox.TabIndex = 8;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(315, 454);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ResetButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Label ResetButton;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
    }
}