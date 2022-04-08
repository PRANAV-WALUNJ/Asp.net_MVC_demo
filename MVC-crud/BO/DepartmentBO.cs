using MVC_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_crud.BO
{
    public class DepartmentBO
    {
        private EFDemoDbEntities db = new EFDemoDbEntities();
        public IEnumerable<Department> GetAll()
        {
            return db.Departments.ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}