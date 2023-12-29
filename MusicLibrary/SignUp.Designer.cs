namespace MusicLibrary_GUI
{
    partial class SignUp
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
            lblUsername = new Label();
            lblPassword = new Label();
            lblRePassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            lblHeader = new Label();
            btnSignUp = new Button();
            btnCheck = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(32, 70);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(32, 124);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblRePassword
            // 
            lblRePassword.AutoSize = true;
            lblRePassword.Location = new Point(32, 184);
            lblRePassword.Name = "lblRePassword";
            lblRePassword.Size = new Size(81, 46);
            lblRePassword.TabIndex = 2;
            lblRePassword.Text = "Re-enter \r\nPassword";
            lblRePassword.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(126, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 30);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(126, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 30);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(126, 184);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.Size = new Size(244, 30);
            txtRePassword.TabIndex = 5;
            txtRePassword.TextChanged += txtRePassword_TextChanged;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Red;
            lblHeader.Location = new Point(167, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(111, 37);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Sign Up";
            // 
            // btnSignUp
            // 
            btnSignUp.Enabled = false;
            btnSignUp.Location = new Point(182, 242);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(96, 42);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(41, 242);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(102, 42);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(311, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(103, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 316);
            Controls.Add(btnCancel);
            Controls.Add(btnCheck);
            Controls.Add(btnSignUp);
            Controls.Add(lblHeader);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblRePassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblRePassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private Label lblHeader;
        private Button btnSignUp;
        private Button btnCheck;
        private Button btnCancel;
    }
}