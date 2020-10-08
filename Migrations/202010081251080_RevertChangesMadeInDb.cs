namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertChangesMadeInDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", "NewsId", "dbo.News");
            DropIndex("dbo.Files", new[] { "NewsId" });
            DropTable("dbo.Files");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 255),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Files", "NewsId");
            AddForeignKey("dbo.Files", "NewsId", "dbo.News", "Id", cascadeDelete: true);
        }
    }
}
