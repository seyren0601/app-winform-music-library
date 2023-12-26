namespace MusicLibrary
{
    partial class Authentication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblHeader = new Label();
            btnLogIn = new Button();
            btnSignUp = new Button();
            btnExit = new Button();
            lblFooter = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(201, 104);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(201, 157);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(311, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 30);
            textBox2.TabIndex = 3;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BorderStyle = BorderStyle.FixedSingle;
            lblHeader.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Blue;
            lblHeader.Location = new Point(96, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(614, 47);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "MUSIC LIBRARY MANAGEMENT SYSTEM\r\n";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(232, 207);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 32);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(353, 207);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(88, 32);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(494, 207);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 32);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(322, 285);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(153, 69);
            lblFooter.TabIndex = 8;
            lblFooter.Text = "Nguyễn Đức Thịnh\r\n2111111236\r\nTH21DH-CN2";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(788, 358);
            Controls.Add(lblFooter);
            Controls.Add(btnExit);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            Controls.Add(lblHeader);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            Load += Authentication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblHeader;
        private Button btnLogIn;
        private Button btnSignUp;
        private Button btnExit;
        private Label lblFooter;
    }
}
