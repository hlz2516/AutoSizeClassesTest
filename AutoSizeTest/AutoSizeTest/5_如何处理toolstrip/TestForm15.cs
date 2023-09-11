using AutoScaleHelper;
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
    public partial class TestForm15 : Form
    {
        AutoScale autoScale = new AutoScale();
        public TestForm15()
        {
            InitializeComponent();
            this.SetAnchorNone();
            autoScale.AutoFont = true;
            autoScale.SetContainer(this);
        }

        private void TestForm13_Load(object sender, EventArgs e)
        {
            
        }

        private void TestForm13_SizeChanged(object sender, EventArgs e)
        {
            autoScale.UpdateControlsLayout();
        }
    }
}
