namespace MangerClient
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.labProjectSearch = new System.Windows.Forms.Label();
            this.labProjectManger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labProjectSearch
            // 
            this.labProjectSearch.Image = ((System.Drawing.Image)(resources.GetObject("labProjectSearch.Image")));
            this.labProjectSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labProjectSearch.Location = new System.Drawing.Point(113, 29);
            this.labProjectSearch.Name = "labProjectSearch";
            this.labProjectSearch.Size = new System.Drawing.Size(80, 80);
            this.labProjectSearch.TabIndex = 0;
            this.labProjectSearch.Text = "项目信息查询";
            this.labProjectSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labProjectManger
            // 
            this.labProjectManger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labProjectManger.Image = ((System.Drawing.Image)(resources.GetObject("labProjectManger.Image")));
            this.labProjectManger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labProjectManger.Location = new System.Drawing.Point(12, 29);
            this.labProjectManger.Name = "labProjectManger";
            this.labProjectManger.Size = new System.Drawing.Size(80, 80);
            this.labProjectManger.TabIndex = 0;
            this.labProjectManger.Text = "项目信息管理";
            this.labProjectManger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 647);
            this.Controls.Add(this.labProjectSearch);
            this.Controls.Add(this.labProjectManger);
            this.Name = "MenuForm";
            this.Text = "菜单栏";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labProjectManger;
        private System.Windows.Forms.Label labProjectSearch;
    }
}