namespace MVC_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mobileisadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Mobile", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Mobile");
        }
    }
}
