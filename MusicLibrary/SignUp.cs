using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary_GUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát khỏi form đăng ký?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) Close();
        }
        #endregion
    }
}
