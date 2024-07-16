using Microsoft.Extensions.Configuration;
using ShabatHost.Views;

namespace ShabatHost
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
            Application.Run(new ShabatHostForm());

            var config = new ConfigurationBuilder()
                     .AddUserSecrets<Program>()
                     .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];

        }
    }
}