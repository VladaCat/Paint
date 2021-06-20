using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Net;

namespace Team_Project_Paint
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormsManager.dummyForm = new DummyForm();
            StaticNet.NetLogic = new NetLogic();
            
            Application.Run(FormsManager.dummyForm);

            
        }
    }
}
