namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingChangeInModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "imageUrl", c => c.String());
            DropColumn("dbo.News", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.News", "Image", c => c.Binary());
            DropColumn("dbo.News", "imageUrl");
        }
    }
}
