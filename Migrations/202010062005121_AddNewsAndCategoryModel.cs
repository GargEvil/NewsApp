namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsAndCategoryModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AuthorId = c.String(nullable: false, maxLength: 128),
                        Content = c.String(nullable: false),
                        Date = c.DateTime(),
                        imageUrl = c.String(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.News", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropIndex("dbo.News", new[] { "AuthorId" });
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
