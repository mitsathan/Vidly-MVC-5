namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'5d9ebe4d-9023-4490-b9a0-cee4fc5c8b2f', N'guest@mail.com', 0, N'AH9OfuG2iC//Ra0Gi5tJqa+ZxBAEo2/ZN9xYzdC98rDXM2c9DdpydTuyDQH+wUfzfA==', N'7e194dc6-b846-4b76-931a-afa004cc9ffb', NULL, 0, 0, NULL, 1, 0, N'guest@mail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f42c0469-adcd-432a-bd21-713aeb0eecda', N'admin@mail.com', 0, N'AAt+5iVfYZ1yLVh3SUnveSC3gvAV/PcnUJbrAa2jA5etFHCUdrmIRygKwPrzr8xiqQ==', N'6d7986cc-f30f-4517-8fba-e1c889a73ecf', NULL, 0, 0, NULL, 1, 0, N'admin@mail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a0f1ed22-98bd-4cb4-8968-b14f9e908ad5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f42c0469-adcd-432a-bd21-713aeb0eecda', N'a0f1ed22-98bd-4cb4-8968-b14f9e908ad5')

");
        }

        public override void Down()
        {
        }
    }
}
