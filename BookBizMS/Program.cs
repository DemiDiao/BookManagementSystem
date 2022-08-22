using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBizMS.GUI;

namespace BookBizMS
{
   

    static class Program
    {
        public static HomePage homePage;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homePage = new HomePage();
            Application.Run(homePage);
        }
    }
}
