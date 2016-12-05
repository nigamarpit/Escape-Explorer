namespace IIW.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "ZipCode", c => c.Int(nullable: false));
        }
    }
}
