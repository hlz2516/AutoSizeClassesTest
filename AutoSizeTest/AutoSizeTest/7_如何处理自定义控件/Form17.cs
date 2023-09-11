using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest._7_如何处理自定义控件
{
    public partial class Form17 : Form
    {
        AutoAdaptWindowsSize AutoSize;
        public Form17()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void Form16_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) // 一定加这个判断，电脑缩放布局不是100%的时候，会报错
            {
                AutoSize.FormSizeChanged();
            }
        }
    }
}
