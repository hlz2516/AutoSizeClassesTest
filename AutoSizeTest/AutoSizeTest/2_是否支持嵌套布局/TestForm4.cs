using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest._2_是否支持嵌套布局
{
    public partial class TestForm4 : Form
    {
        ControlChange cc = new ControlChange();
        Stopwatch stopwatch = new Stopwatch();

        public TestForm4()
        {
            InitializeComponent();
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {
            //窗体自适应
            cc.x = this.Width;
            cc.y = this.Height;
            cc.setTag(this);
        }

        private void TestForm1_SizeChanged(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            //控件随着窗体改变大小
            float newx = this.Width / cc.x;
            float newy = this.Height / cc.y;
            cc.setControls(newx, newy, this);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
