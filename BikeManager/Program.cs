using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BikeManagerProgram
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logo logo = new Logo();
            logo.ShowDialog();

            if(logo.DialogResult==DialogResult.OK)
                Application.Run(new Form_Main(logo.getRentalShop()));
        }
    }
}
