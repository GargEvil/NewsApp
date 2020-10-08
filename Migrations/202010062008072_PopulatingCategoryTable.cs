namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Vijesti')");
            Sql("INSERT INTO Categories (Name) VALUES ('Biznis')");
            Sql("INSERT INTO Categories (Name) VALUES ('Sport')");
            Sql("INSERT INTO Categories (Name) VALUES ('Magazin')");
            Sql("INSERT INTO Categories (Name) VALUES ('Lifestyle')");
            Sql("INSERT INTO Categories (Name) VALUES ('Scitech')");
            Sql("INSERT INTO Categories (Name) VALUES ('Auto')");
            Sql("INSERT INTO Categories (Name) VALUES ('Crna hronika')");
        }
        
        public override void Down()
        {
        }
    }
}
