namespace MVC_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class register : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Userlogins", "MobileNumber", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Userlogins", "MobileNumber", c => c.Int(nullable: false));
        }
    }
}
