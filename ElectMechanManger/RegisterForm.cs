using MangerClient.UserLogin;
using System;
using System.Windows.Forms;
namespace MangerClient
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegisterCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 注册按钮操作方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string userPsw = txtUserPsw.Text.Trim();
            string userPerm = txtPerm.Text.Trim();
            
    
            UserLoginSoapClient soapClient = new UserLoginSoapClient();
            string message= soapClient.Register(userName, userPsw, userPerm);
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//提示注册是否成功
        }
    }
}
