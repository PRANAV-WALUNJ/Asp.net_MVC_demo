namespace MVC_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newregistraiontableinsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Userlogins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MobileNumber = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Userlogins");
        }
    }
}
