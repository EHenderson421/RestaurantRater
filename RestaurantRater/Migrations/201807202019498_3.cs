namespace RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "TotalRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "TotalRating", c => c.String());
        }
    }
}
