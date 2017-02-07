namespace Todos.Data.Migrations
{
    using Data;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Countries.Data.Models;
    public sealed class Configuration : DbMigrationsConfiguration<TodosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TodosDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (context.Todos.Count() > 0)
            {
                return;
            }

            var todosCount = 50;
            var catCount = 5;
            var todos = new Todo[todosCount];
            for (int i = 1; i <= todosCount; i++)
            {
                todos[i - 1] = new Todo
                {
                    Id = i,
                    Title = $"Todo {i}",
                    Body = $"Todo {i} body",
                    Category = new Category { Id = (i % catCount) + 1, Name = $"Category {i%5}" },
                };
            }

            context.Todos.AddOrUpdate(todos);
        }
    }
}
