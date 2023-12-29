using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MusicLibrary_BLL.Services.UserSerivce;
using MusicLibrary_BLL.Models;

namespace MusicLibrary_GUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        #region Form Load

        #endregion

        #region Events
        // Buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát khỏi form đăng ký?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            User? user = FindUser(txtUsername.Text);
            if (user != null)
            {
                MessageBox.Show("Username đã được đăng ký", "Thông báo");
            }
            else if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password không trùng khớp", "Thông báo");
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "" && txtRePassword.Text != "")
            {
                btnSignUp.Enabled = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool addSuccess = AddUser(new User(txtUsername.Text, txtPassword.Text));
            if (addSuccess)
            {
                var result = MessageBox.Show("Đăng ký thành công!", "Thông báo");
                if (result != DialogResult.None)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Thông báo");
                Close();
            }
        }

        // Text changed
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
        }
        #endregion
    }
}
