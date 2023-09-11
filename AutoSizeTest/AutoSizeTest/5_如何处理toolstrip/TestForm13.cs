using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest._5_如何处理toolstrip
{
    public partial class TestForm13 : Form
    {
        ControlChange cc = new ControlChange();

        public TestForm13()
        {
            InitializeComponent();
        }

        private void TestForm13_Load(object sender, EventArgs e)
        {
            //窗体自适应
            cc.x = this.Width;
            cc.y = this.Height;
            cc.setTag(this);
        }

        private void TestForm13_SizeChanged(object sender, EventArgs e)
        {
            //控件随着窗体改变大小
            float newx = this.Width / cc.x;
            float newy = this.Height / cc.y;
            cc.setControls(newx, newy, this);
        }
    }
}
