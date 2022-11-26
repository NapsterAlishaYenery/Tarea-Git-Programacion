using DesingSellPoint.FormsSellPoint;

namespace DesingSellPoint
{
    internal static class Program
    {

        public static bool boolSplashConfirm = false;

        public static bool boolLogin = false;

        public static string NickUser = string.Empty;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmSplash());

            if (boolSplashConfirm)
            {
                Application.Run(new FrmHome());
            }
        }
    }
}