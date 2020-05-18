namespace Pharmacy_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test3_alternation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "phone_number", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "phone_number", c => c.String(maxLength: 100));
        }
    }
}
