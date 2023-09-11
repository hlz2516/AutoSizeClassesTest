using AutoScaleHelper;
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

namespace AutoSizeTest._1_缩放效果和耗时
{
    public partial class TestForm3 : Form
    {
        AutoScale autoScale = new AutoScale();
        Stopwatch stopwatch = new Stopwatch();

        public TestForm3()
        {
            InitializeComponent();
            this.SetAnchorNone();
            autoScale.AutoFont = true;
            autoScale.FontDependOn(label1, textBox1, comboBox1, numericUpDown1, domainUpDown1);
            autoScale.SetContainer(this);
        }

        private void TestForm3_SizeChanged(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            autoScale.UpdateControlsLayout();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
