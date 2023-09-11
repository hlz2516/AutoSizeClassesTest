using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest
{
    class ControlChange
    {
        #region 控件大小随窗体大小等比例缩放
        public float x;//定义当前窗体的宽度
        public float y;//定义当前窗体的高度
        public void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        public void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }

        /// <summary>
        /// 控件在父控件中居中
        /// </summary>
        /// <param name="ctr">要设置的控件</param>
        /// <param name="isLR">左右居中</param>
        /// <param name="isUD">上下居中</param>
        /// <returns></returns>
        public bool CenterCtr(Control ctr, bool isLR, bool isUD)
        {
            Control pCtr = ctr.Parent;
            int x = isLR ? ((pCtr.Width - ctr.Width) / 2) : ctr.Location.X;
            int y = isUD ? ((pCtr.Height - ctr.Height) / 2) : ctr.Location.Y;
            ctr.Location = new System.Drawing.Point(x, y);
            return true;
        }

        #endregion

    }
}
