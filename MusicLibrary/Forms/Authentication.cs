using MusicLibrary_GUI;
using MusicLibrary_BLL.Models;
using static MusicLibrary_BLL.Services.UserSerivce;
using MusicLibrary_BLL.Services;

namespace MusicLibrary
{
    public partial class Authentication : Form
    {
        SignUp SignUpForm;
        UserList Users = UserList.GetInstance();
        public Authentication()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Authentication_Load(object sender, EventArgs e)
        {
            if (FindUser("seyren") == null)
                AddAdmin();
            Users.UpdateList();
        }
        #endregion

        #region Events
        // Button clicks
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm = new SignUp();
            SignUpForm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (LoginUser(txtUsername.Text, txtPassword.Text))
            {
                var result = MessageBox.Show("Login thành công", "Thông báo");
                if (result != DialogResult.None)
                {
                    Main main = new Main(txtUsername.Text, txtUsername.Text == "seyren" ? Role.admin : Role.user);
                    Hide();
                    main.ShowDialog();
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Login thất bại", "Thông báo");
            }
        }

        // Key presses

        #endregion

        private void Authentication_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogIn_Click(sender, new EventArgs());
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogIn_Click(sender, new EventArgs());
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogIn_Click(sender, new EventArgs());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
