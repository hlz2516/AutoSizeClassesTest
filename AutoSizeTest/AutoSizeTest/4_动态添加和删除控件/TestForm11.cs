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
    public partial class TestForm11 : Form
    {
        Button button3 = new Button();
        AutoAdaptWindowsSize AutoSize;

        public TestForm11()
        {
            InitializeComponent();
        }

        private void TestForm7_Load(object sender, EventArgs e)
        {
            AutoSize = new AutoAdaptWindowsSize(this);
        }

        private void TestForm7_SizeChanged(object sender, EventArgs e)
        {
            if (AutoSize != null) // 一定加这个判断，电脑缩放布局不是100%的时候，会报错
            {
                AutoSize.FormSizeChanged();
            }
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
            AutoSize.InitControlsInfo(this.panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(this.button3);
        }
    }
}
