using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_crud.Models
{
    public class Employee
    {

        [Key]
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public int Mobile{get;set;}
            public  int DeptId { get; set; }
       
           [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }
    }

    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
    public class EFDemoDbEntities : DbContext
        {
            public DbSet<Employee> Employee { get; set; }
            public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<MVC_crud.Models.Userlogin> Userlogins { get; set; }
    }
    
}