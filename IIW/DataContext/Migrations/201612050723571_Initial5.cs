namespace IIW.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "RestaurantName", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantAddress", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantRating", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantCuisine", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantTelephone", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantImage", c => c.String());
            DropColumn("dbo.Restaurants", "Cuisines");
            DropColumn("dbo.Restaurants", "Establishment_types");
            DropColumn("dbo.Restaurants", "currency");
            DropColumn("dbo.Restaurants", "featured_image");
            DropColumn("dbo.Restaurants", "average_cost_for_two");
            DropColumn("dbo.Restaurants", "deeplink");
            DropColumn("dbo.Restaurants", "thumb");
            DropColumn("dbo.Restaurants", "is_delivering_now");
            DropColumn("dbo.Restaurants", "menu_url");
            DropColumn("dbo.Restaurants", "photos_url");
            DropColumn("dbo.Restaurants", "user_rating");
            DropColumn("dbo.Restaurants", "offers");
            DropColumn("dbo.Restaurants", "location");
            DropColumn("dbo.Restaurants", "has_table_booking");
            DropColumn("dbo.Restaurants", "events_url");
            DropColumn("dbo.Restaurants", "price_range");
            DropColumn("dbo.Restaurants", "name");
            DropColumn("dbo.Restaurants", "has_online_delivery");
            DropColumn("dbo.Restaurants", "url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "url", c => c.String());
            AddColumn("dbo.Restaurants", "has_online_delivery", c => c.String());
            AddColumn("dbo.Restaurants", "name", c => c.String());
            AddColumn("dbo.Restaurants", "price_range", c => c.String());
            AddColumn("dbo.Restaurants", "events_url", c => c.String());
            AddColumn("dbo.Restaurants", "has_table_booking", c => c.String());
            AddColumn("dbo.Restaurants", "location", c => c.String());
            AddColumn("dbo.Restaurants", "offers", c => c.String());
            AddColumn("dbo.Restaurants", "user_rating", c => c.String());
            AddColumn("dbo.Restaurants", "photos_url", c => c.String());
            AddColumn("dbo.Restaurants", "menu_url", c => c.String());
            AddColumn("dbo.Restaurants", "is_delivering_now", c => c.String());
            AddColumn("dbo.Restaurants", "thumb", c => c.String());
            AddColumn("dbo.Restaurants", "deeplink", c => c.String());
            AddColumn("dbo.Restaurants", "average_cost_for_two", c => c.String());
            AddColumn("dbo.Restaurants", "featured_image", c => c.String());
            AddColumn("dbo.Restaurants", "currency", c => c.String());
            AddColumn("dbo.Restaurants", "Establishment_types", c => c.String());
            AddColumn("dbo.Restaurants", "Cuisines", c => c.String());
            DropColumn("dbo.Restaurants", "RestaurantImage");
            DropColumn("dbo.Restaurants", "RestaurantTelephone");
            DropColumn("dbo.Restaurants", "RestaurantCuisine");
            DropColumn("dbo.Restaurants", "RestaurantRating");
            DropColumn("dbo.Restaurants", "RestaurantAddress");
            DropColumn("dbo.Restaurants", "RestaurantName");
        }
    }
}
