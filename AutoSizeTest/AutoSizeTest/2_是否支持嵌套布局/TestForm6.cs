using AutoScaleHelper;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AutoSizeTest._2_是否支持嵌套布局
{
    public partial class TestForm6 : Form
    {
        AutoScale autoScale = new AutoScale();
        Stopwatch stopwatch = new Stopwatch();

        public TestForm6()
        {
            InitializeComponent();
            this.SetAnchorNone();
            autoScale.AutoFont = true;
            autoScale.FontDependOn(label1, textBox1, comboBox1, numericUpDown1, domainUpDown1);
            autoScale.SetContainer(this);
        }

        private void TestForm1_Load(object sender, EventArgs e)
        {

        }

        private void TestForm1_SizeChanged(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            autoScale.UpdateControlsLayout();  //默认内部的嵌套布局也自适应缩放
            //autoScale.UpdateControlsLayout(false);  //但也可以设置只对这一层级的布局进行自适应缩放
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
