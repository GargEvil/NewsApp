namespace NewsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'admin@newsapp.com', 0, N'ALUwp8ipkf7BqcGhen5r0Cut8YI1se5nix19kBCeEATOaxzw6mLWDXYs2LtB7ZqbxQ==', N'537bd0aa-81d1-47fc-a38f-1fb392d6eb86', NULL, 0, 0, NULL, 1, 0, N'admin@newsapp.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c8728dbb-8149-400a-964e-86a3a05b7e4e', N'Admin')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b85ea4d2-6801-4f41-aac8-70fd47ab0fec', N'c8728dbb-8149-400a-964e-86a3a05b7e4e')
                     ");
        }
        
        public override void Down()
        {
        }
    }
}
