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

namespace AutoSizeTest._4_动态添加和删除控件
{
    public partial class TestForm12 : Form
    {
        Button button3 = new Button();
        AutoScale autoScale = new AutoScale();

        public TestForm12()
        {
            InitializeComponent();
            this.SetAnchorNone();
            autoScale.AutoFont = true;
            autoScale.SetContainer(this);
        }

        private void TestForm7_Load(object sender, EventArgs e)
        {

        }

        private void TestForm7_SizeChanged(object sender, EventArgs e)
        {
            autoScale.UpdateControlsLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(143, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.Anchor = AnchorStyles.None;
            this.button3.UseVisualStyleBackColor = true;
            this.panel1.Controls.Add(this.button3);
            autoScale.AddControl(this.button3);
            autoScale.UpdateControlsLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autoScale.RemoveControl(this.button3);
            this.panel1.Controls.Remove(this.button3);
        }
    }
}
