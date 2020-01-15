using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangerClient
{
    public partial class MainForm : Form
    {
        public static string userName;
        public static string userPerm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUserInfos.Text = "登录用户: "+userName;
        }

        
    }
}
