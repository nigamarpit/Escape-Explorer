namespace IIW.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieImgSource", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieImgSource");
        }
    }
}
