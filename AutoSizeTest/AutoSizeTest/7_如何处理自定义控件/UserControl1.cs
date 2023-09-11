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
    public partial class UserControl1 : UserControl
    {
        public Image Icon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Content
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
