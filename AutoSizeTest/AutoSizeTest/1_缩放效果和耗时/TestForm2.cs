using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoSizeTest._1_缩放效果和耗时
{
    public partial class TestForm2 : Form
    {
        AutoAdaptWindowsSize AutoSize;
        Stopwatch stopwatch = new Stopwatch();

        public TestForm2()
        {
            InitializeComponent();
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void TestForm2_SizeChanged(object sender, EventArgs e)
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
