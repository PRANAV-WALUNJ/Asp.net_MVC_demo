namespace MVC_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialscema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Empid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Salary = c.Int(nullable: false),
                        DeptId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Empid)
                .ForeignKey("dbo.Departments", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
