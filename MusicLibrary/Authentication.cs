using MusicLibrary_GUI;
using MusicLibrary_GUI.Models;

namespace MusicLibrary
{
    public partial class Authentication : Form
    {
        SignUp SignUpForm;
        UserList _users = UserList.GetInstance();
        public Authentication()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Authentication_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Events
        // Button clicks
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm = new SignUp();
            SignUpForm.ShowDialog();
        }
        #endregion


    }
}
