using MangerClient;
using MangerClient.UserLogin;
using System;
using System.Windows.Forms;

namespace MangerClient
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
         
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            Login();
        }
        private void Login()
        {
            string userName = txtUserName.Text.Trim();
            string userPsw = txtUserPsw.Text.Trim();
            UserLoginSoapClient userLogin = new UserLoginSoapClient();
            bool result = userLogin.Login(userName, userPsw);
            if (userName == null || userPsw == null)
            {
                MessageBox.Show("登录提示", "没有输入用户名或密码，请重新输入", MessageBoxButtons.OKCancel);
            }
            else if (result == true)
            {
                MainForm.userName = userName;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }

        }
    }
}
