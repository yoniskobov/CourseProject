namespace CourseProject.DataAccess.Migrations
{
    using CourseProject.DB.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProject.DataAccess.CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CourseProject.DataAccess.CourseProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Cities.Any())
            {



                context.Cities.AddOrUpdate(x => x.Id,
                    new City() { Id = 1, Name = "Велико Търново" },
                    new City() { Id = 2, Name = "София" },
                    new City() { Id = 3, Name = "Варна" },
                    new City() { Id = 4, Name = "Пловдив" }

                    

                );

                context.SaveChanges();
            }
        }
    }
}
