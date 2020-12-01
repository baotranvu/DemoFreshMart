using System;
using System.Windows.Forms;
using Unity;
using ViewModels;



namespace App
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();
        public static void CustomerRegister()
        {
            Container.RegisterType<ICustomerViewModel, CustomerViewModel>();
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
            Config.CustomerRegister();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
