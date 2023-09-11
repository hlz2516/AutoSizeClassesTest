namespace AutoSizeTest._7_如何处理自定义控件
{
    partial class Form16
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
            this.userControl12 = new AutoSizeTest._7_如何处理自定义控件.UserControl1();
            this.userControl11 = new AutoSizeTest._7_如何处理自定义控件.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl12.Content = "测试";
            this.userControl12.Icon = global::AutoSizeTest.Properties.Resources.二哈;
            this.userControl12.Location = new System.Drawing.Point(203, 154);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(98, 113);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Content = "测试";
            this.userControl11.Icon = global::AutoSizeTest.Properties.Resources.二哈;
            this.userControl11.Location = new System.Drawing.Point(484, 154);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(98, 113);
            this.userControl11.TabIndex = 0;
            // 
            // Form16
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.SizeChanged += new System.EventHandler(this.Form16_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}