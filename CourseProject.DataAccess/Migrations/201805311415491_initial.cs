namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 20),
                        StreetName = c.String(maxLength: 20),
                        WorkTime = c.String(maxLength: 10),
                        OnlineOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.City, unique: true);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 20),
                        StreetName = c.String(maxLength: 20),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.CityName, unique: true)
                .Index(t => t.City_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "City_Id", "dbo.Cities");
            DropIndex("dbo.Locations", new[] { "City_Id" });
            DropIndex("dbo.Locations", new[] { "CityName" });
            DropIndex("dbo.Cities", new[] { "Name" });
            DropIndex("dbo.Shops", new[] { "City" });
            DropTable("dbo.Locations");
            DropTable("dbo.Cities");
            DropTable("dbo.Shops");
        }
    }
}
