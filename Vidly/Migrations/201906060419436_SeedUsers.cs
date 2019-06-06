namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'156c587d-bbd9-4a7e-a915-f245b69c6161', N'admin@vidly.co.ao', 0, N'AN79EVoTTJVlsBCpHdDJHWiJ2eq7wKUWoDo133CbvaWYCYAkgGH6PuottUVhXMwCGA==', N'0fdacc61-621b-4168-8175-63053e31435d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.co.ao')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c8a4b90f-d418-4b02-80ef-2b6f734f1f38', N'guest@vidly.co.ao', 0, N'AD7eBSApNT9tt4akzysEfq8Y9vPg1zpCSGhHWw3B9hnUsAtdwumS/7I4h96AXruDhg==', N'03dc0492-f8d4-40fb-ad6b-4180056edb98', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.co.ao')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bdc8fbee-e9b2-4865-9f81-76911b546f0d', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'156c587d-bbd9-4a7e-a915-f245b69c6161', N'bdc8fbee-e9b2-4865-9f81-76911b546f0d')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
