namespace RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(),
                        Cuisine = c.String(),
                        TotalRating = c.String(),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Clients", new[] { "User_Id" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Clients");
        }
    }
}
