using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

<<<<<<< HEAD

            Application.Run(new FormDangNhap());



=======

            Application.Run(new FormAdmin());
>>>>>>> cb4ebb89b2c32d73a8c6da35a4fa58cb13cbbd7f
        }
    }
}
