using System;
using System.Windows.Forms;
using Unity;
using ViewModels;
using Interfaces;


namespace Views
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            Container.RegisterType<ICustomerViewModel, CustomerViewModel>();
            Container.RegisterType<IEmployeeViewModel, EmployeeViewModel>();
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
