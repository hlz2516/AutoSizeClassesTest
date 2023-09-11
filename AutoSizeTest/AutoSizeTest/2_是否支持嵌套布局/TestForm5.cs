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
    public partial class TestForm5 : Form
    {
        AutoAdaptWindowsSize AutoSize;
        Stopwatch stopwatch = new Stopwatch();

        public TestForm5()
        {
            InitializeComponent();
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void TestForm1_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) // 一定加这个判断，电脑缩放布局不是100%的时候，会报错
            {
                stopwatch.Reset();
                stopwatch.Start();
                AutoSize.FormSizeChanged();
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }
        }
    }
}
