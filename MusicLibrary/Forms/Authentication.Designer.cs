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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
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
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = Color.Silver;
            lblUsername.Location = new Point(337, 104);
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
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.Silver;
            lblPassword.Location = new Point(337, 157);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(457, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(185, 30);
            txtUsername.TabIndex = 2;
            txtUsername.KeyUp += txtUsername_KeyUp;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(457, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(185, 30);
            txtPassword.TabIndex = 3;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.BorderStyle = BorderStyle.Fixed3D;
            lblHeader.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(186, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(418, 47);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "MUSIC LIBRARY MANAGER\r\n";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(170, 240, 240, 240);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.ForeColor = Color.Black;
            btnLogIn.Location = new Point(349, 207);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 32);
            btnLogIn.TabIndex = 5;
            btnLogIn.TabStop = false;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(170, 240, 240, 240);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(505, 207);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(88, 32);
            btnSignUp.TabIndex = 6;
            btnSignUp.TabStop = false;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(170, 240, 240, 240);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(675, 207);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 32);
            btnExit.TabIndex = 7;
            btnExit.TabStop = false;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.BackColor = Color.Transparent;
            lblFooter.ForeColor = Color.Silver;
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 366);
            Controls.Add(lblFooter);
            Controls.Add(btnExit);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogIn);
            Controls.Add(lblHeader);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Authentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            Load += Authentication_Load;
            KeyUp += Authentication_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblHeader;
        private Button btnLogIn;
        private Button btnSignUp;
        private Button btnExit;
        private Label lblFooter;
    }
}
