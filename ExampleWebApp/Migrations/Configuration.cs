namespace ExampleWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExampleWebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExampleWebApp.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(c => c.Id,
                new Entities.Category
                {
                    Id = 1, 
                    Name = "Ноутбуки",
                    Photo = "defoult.jpg"
                });

            context.Categories.AddOrUpdate(c => c.Id,
               new Entities.Category
               {
                   Id = 2,
                   Name = "Планшети",
                   Photo = "defoult1.jpg"
               });
        }
    }
}
