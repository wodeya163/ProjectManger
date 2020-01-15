namespace MangerClient
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labUserName = new System.Windows.Forms.Label();
            this.labUserPsw = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPsw = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.btnRegisterCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Location = new System.Drawing.Point(121, 64);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(53, 12);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "用户名：";
            // 
            // labUserPsw
            // 
            this.labUserPsw.AutoSize = true;
            this.labUserPsw.Location = new System.Drawing.Point(121, 109);
            this.labUserPsw.Name = "labUserPsw";
            this.labUserPsw.Size = new System.Drawing.Size(41, 12);
            this.labUserPsw.TabIndex = 0;
            this.labUserPsw.Text = "密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(227, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // txtUserPsw
            // 
            this.txtUserPsw.Location = new System.Drawing.Point(227, 106);
            this.txtUserPsw.Name = "txtUserPsw";
            this.txtUserPsw.PasswordChar = '*';
            this.txtUserPsw.Size = new System.Drawing.Size(100, 21);
            this.txtUserPsw.TabIndex = 1;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(123, 202);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnRegisterCancle
            // 
            this.btnRegisterCancle.Location = new System.Drawing.Point(252, 202);
            this.btnRegisterCancle.Name = "btnRegisterCancle";
            this.btnRegisterCancle.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterCancle.TabIndex = 2;
            this.btnRegisterCancle.Text = "取消";
            this.btnRegisterCancle.UseVisualStyleBackColor = true;
            this.btnRegisterCancle.Click += new System.EventHandler(this.btnRegisterCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "权限：";
            // 
            // txtPerm
            // 
            this.txtPerm.Location = new System.Drawing.Point(227, 144);
            this.txtPerm.Name = "txtPerm";
            this.txtPerm.PasswordChar = '*';
            this.txtPerm.Size = new System.Drawing.Size(100, 21);
            this.txtPerm.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.btnRegisterCancle);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtPerm);
            this.Controls.Add(this.txtUserPsw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labUserPsw);
            this.Controls.Add(this.labUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labUserPsw;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserPsw;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button btnRegisterCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerm;
    }
}