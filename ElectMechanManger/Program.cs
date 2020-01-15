using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginFrm loginFrm = new LoginFrm();
            if(loginFrm.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new MainForm());

            }
            
        }
    }
}
