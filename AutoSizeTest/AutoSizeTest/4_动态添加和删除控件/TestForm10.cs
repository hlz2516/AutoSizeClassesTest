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
    public partial class TestForm10 : Form
    {
        ControlChange cc = new ControlChange();
        Button button3 = new Button();
        public TestForm10()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.button3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(143, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 74);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.panel1.Controls.Add(this.button3);
            //给动态添加的控件设置tag
            cc.setTag(this.button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(this.button3);
        }
    }
}
