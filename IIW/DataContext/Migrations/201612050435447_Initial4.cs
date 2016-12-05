namespace IIW.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attractions",
                c => new
                    {
                        AttractionId = c.Int(nullable: false, identity: true),
                        AttractionName = c.String(),
                        AttractionAddress = c.String(),
                        AttractionDescription = c.String(),
                        AttractionImgSource = c.String(),
                    })
                .PrimaryKey(t => t.AttractionId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventAddress = c.String(),
                        EventURL = c.String(),
                        EventImgSource = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        MovieTheaterName = c.String(),
                        MovieTheaterAddress = c.String(),
                        MovieName = c.String(),
                        MovieShowTimes = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Cuisines = c.String(),
                        Establishment_types = c.String(),
                        currency = c.String(),
                        featured_image = c.String(),
                        average_cost_for_two = c.String(),
                        deeplink = c.String(),
                        thumb = c.String(),
                        is_delivering_now = c.String(),
                        menu_url = c.String(),
                        photos_url = c.String(),
                        user_rating = c.String(),
                        offers = c.String(),
                        location = c.String(),
                        has_table_booking = c.String(),
                        events_url = c.String(),
                        price_range = c.String(),
                        name = c.String(),
                        has_online_delivery = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
            DropTable("dbo.Movies");
            DropTable("dbo.Events");
            DropTable("dbo.Attractions");
        }
    }
}
