namespace MangerClient
{
    partial class LoginFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LabUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labPsw = new System.Windows.Forms.Label();
            this.txtUserPsw = new System.Windows.Forms.TextBox();
            this.LabRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(95, 200);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnLogin_KeyDown);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(253, 200);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "取消";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Location = new System.Drawing.Point(93, 62);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(53, 12);
            this.LabUserName.TabIndex = 1;
            this.LabUserName.Text = "用户名：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(185, 59);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 21);
            this.txtUserName.TabIndex = 2;
            // 
            // labPsw
            // 
            this.labPsw.AutoSize = true;
            this.labPsw.Location = new System.Drawing.Point(93, 105);
            this.labPsw.Name = "labPsw";
            this.labPsw.Size = new System.Drawing.Size(41, 12);
            this.labPsw.TabIndex = 1;
            this.labPsw.Text = "密码：";
            // 
            // txtUserPsw
            // 
            this.txtUserPsw.Location = new System.Drawing.Point(185, 102);
            this.txtUserPsw.Name = "txtUserPsw";
            this.txtUserPsw.PasswordChar = '*';
            this.txtUserPsw.Size = new System.Drawing.Size(143, 21);
            this.txtUserPsw.TabIndex = 2;
            // 
            // LabRegister
            // 
            this.LabRegister.AutoSize = true;
            this.LabRegister.Location = new System.Drawing.Point(12, 260);
            this.LabRegister.Name = "LabRegister";
            this.LabRegister.Size = new System.Drawing.Size(53, 12);
            this.LabRegister.TabIndex = 3;
            this.LabRegister.Text = "用户注册";
            this.LabRegister.Click += new System.EventHandler(this.LabRegister_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::MangerClient.Properties.Resources.gridimpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.LabRegister);
            this.Controls.Add(this.txtUserPsw);
            this.Controls.Add(this.labPsw);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.LabUserName);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginFrm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labPsw;
        private System.Windows.Forms.TextBox txtUserPsw;
        private System.Windows.Forms.Label LabRegister;
    }
}

