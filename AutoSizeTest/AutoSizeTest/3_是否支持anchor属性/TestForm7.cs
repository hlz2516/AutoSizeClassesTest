using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest._3_是否支持anchor属性
{
    public partial class TestForm7 : Form
    {
        ControlChange cc = new ControlChange();
        public TestForm7()
        {
            InitializeComponent();
        }

        private void TestForm7_Load(object sender, EventArgs e)
        {
            //窗体自适应
            cc.x = this.Width;
            cc.y = this.Height;
            cc.setTag(this);
        }

        private void TestForm7_SizeChanged(object sender, EventArgs e)
        {
            //控件随着窗体改变大小
            float newx = this.Width / cc.x;
            float newy = this.Height / cc.y;
            cc.setControls(newx, newy, this);
        }
    }
}
