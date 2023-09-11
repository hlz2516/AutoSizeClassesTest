using AutoSizeTest._1_缩放效果和耗时;
using AutoSizeTest._2_是否支持嵌套布局;
using AutoSizeTest._3_是否支持anchor属性;
using AutoSizeTest._4_动态添加和删除控件;
using AutoSizeTest._5_如何处理toolstrip;
using AutoSizeTest._6_缩放模式;
using AutoSizeTest._7_如何处理自定义控件;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSizeTest
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form18());
        }
    }
}
