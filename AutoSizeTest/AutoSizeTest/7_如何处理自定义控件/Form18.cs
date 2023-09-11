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

namespace AutoSizeTest._7_如何处理自定义控件
{
    public partial class Form18 : Form
    {
        AutoScale autoScale = new AutoScale();
        AutoScale autoScaleForUC1 = new AutoScale();
        public Form18()
        {
            InitializeComponent();
            autoScale.SetContainer(this);
            userControl11.SetAnchorNone();
            autoScaleForUC1.AutoFont = true;
            autoScaleForUC1.SetContainer(userControl11);
        }

        private void Form16_Load(object sender, EventArgs e)
        {
           
        }

        private void Form16_SizeChanged(object sender, EventArgs e)
        {
            autoScale.UpdateControlsLayout();
            autoScaleForUC1.UpdateControlsLayout();
        }
    }
}
