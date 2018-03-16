namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomerName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "Name", c => c.String());
            CreateIndex("dbo.Customers", "MembershipTypeID");
        }
    }
}
