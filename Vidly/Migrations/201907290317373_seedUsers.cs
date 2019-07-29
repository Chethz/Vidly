namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cbd21d84-b2dd-4775-ae81-5dcba8687495', N'admin@vidly.com', 0, N'AGjjL9vrL26JR3YsgJUahO3QOSN88iRdUhK2glGr8z1IcLBjsQb2r8Vtm6XbycerCQ==', N'5002bcd9-c0d8-47d7-948c-532bee88f5e9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e4d06354-5fdf-407f-b43f-530f7750bda8', N'guest@vidly.com', 0, N'AGUhVW08foBKZLDfJFp9Clwc5YexAMDQznDERF1MiOmmg9kbgmfutaq5sJ2/ROVmAQ==', N'74ce2ee1-ad46-4121-b4a6-07baff6fe231', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6959cc2e-7b6e-4237-89ce-f6a17155a6f7', N'CanManageMovies') 

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbd21d84-b2dd-4775-ae81-5dcba8687495', N'6959cc2e-7b6e-4237-89ce-f6a17155a6f7')
");
        }
        
        public override void Down()
        {
        }
    }
}
