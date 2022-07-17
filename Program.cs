namespace WriteAllWords
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

            Words.Initialise();

            if (!Words.ReadData())
            {
                Console.WriteLine("Something went wrong while reading words.");
            }
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            
        }
    }
}