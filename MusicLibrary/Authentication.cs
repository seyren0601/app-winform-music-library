using MusicLibrary_GUI;
using MusicLibrary_BLL.Models;
using static MusicLibrary_BLL.Services.UserSerivce;

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
            if(LoginUser(txtUsername.Text, txtPassword.Text))
            {
                var result = MessageBox.Show("Login thành công", "Thông báo");
                if (result != DialogResult.None)
                {
                    Main main = new Main();
                    Hide();
                    main.ShowDialog();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Login thất bại", "Thông báo");
            }
        }
        #endregion



    }
}
