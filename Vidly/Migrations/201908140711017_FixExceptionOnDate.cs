namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixExceptionOnDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            AlterColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateRented", c => c.DateTime());
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
        }
    }
}
