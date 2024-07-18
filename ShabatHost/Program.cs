using Microsoft.Extensions.Configuration;
using ShabatHost.DAL;
using ShabatHost.DAL.Repositories;
using ShabatHost.Views;

namespace ShabatHost
{
    internal  class Program
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

            var config = new ConfigurationBuilder()
                     .AddUserSecrets<Program>()
                     .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];
                
            DBContext dbCtx = new DBContext(conn);
            dbCtx.CheckConnectionToDefaultDB(dbName);
            Seed seedService = new Seed(dbCtx);
            seedService.EnsureTablesAndSeedData();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var mainForm = new ShabatHostForm(new CategoryRepository(dbCtx));
            Application.Run(mainForm);
            //Application.Run(new ShabatHostForm());
        }
    }
}