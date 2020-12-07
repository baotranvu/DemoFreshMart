using System;
using System.Windows.Forms;
using Unity;
using ViewModels;
using Interfaces;
using DevExpress.XtraEditors;
using System.Threading;


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

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                XtraMessageBox.Show((e.ExceptionObject as Exception).Message, "Error!");
            Application.ThreadException += (s, e) =>
                XtraMessageBox.Show(e.Exception.Message, "Error!");
                var token = new CancellationTokenSource();
            token.Cancel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
