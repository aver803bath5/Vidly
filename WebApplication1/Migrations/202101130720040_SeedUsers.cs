namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'263f8d55-8401-4ad8-9e02-c1e8a0205ba1', N'guest@vidly.com', 0, N'ACY/MuwGeQ8AxxLVwS4MGvBcYHIq4Euej5cfpvIqjufAIIpoer15NtJPmKWDjgu1VQ==', N'd0cd8394-5aa2-4d50-b03b-f822bd4b6305', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'998a3d6f-69f0-4fbb-be60-1a014c7fab31', N'admin@vidly.com', 0, N'AAMxGkacywoadYv5i+cCMjKeWpJK3jHOsaoLo1llxIGym0APZ/qoXS59YuokybC+Kg==', N'd498aa7a-3717-490c-80d7-6a07df779e20', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'18b04526-bc1c-4449-b363-6da7506cbf1c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'998a3d6f-69f0-4fbb-be60-1a014c7fab31', N'18b04526-bc1c-4449-b363-6da7506cbf1c')
");
        }
        
        public override void Down()
        {
        }
    }
}
