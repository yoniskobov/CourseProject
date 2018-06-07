using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CourseProject.DB.Entities;

namespace CourseProject.DataAccess
{
    public class CourseProjectDbContext : DbContext 
    {
      public  DbSet<City> Cities { get; set; }
      public DbSet<Location> Locations { get; set; }
      public DbSet<Shop> CamShop { get; set; }
    }
}
