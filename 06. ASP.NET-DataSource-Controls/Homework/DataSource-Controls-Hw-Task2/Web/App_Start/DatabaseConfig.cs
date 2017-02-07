namespace Todos.Web
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            //Database.Delete("Todos");
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TodosDbContext, Configuration>());
            TodosDbContext.Create().Database.Initialize(true);
        }
    }
}