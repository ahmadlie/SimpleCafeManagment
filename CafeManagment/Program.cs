using DataAccess;
using DataAccess.Entities;

namespace CafeManagment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext appDbContext = new AppDbContext();
            if (!appDbContext.Categories.Any())
            {
                appDbContext.Categories.Add(new Category() { Name = "Food" });
                appDbContext.Categories.Add(new Category() { Name = "Beverage" });
                appDbContext.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new AdminForm());

        }
    }
}