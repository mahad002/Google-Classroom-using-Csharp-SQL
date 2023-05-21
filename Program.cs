namespace Lab_10___21i_1239
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DBLAB10());
            //Application.Run(new Form5(1));
            //Application.Run(new Sclass(8));
        }
    }
}