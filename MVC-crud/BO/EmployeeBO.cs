using MVC_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_crud.BO
{
    public class EmployeeBO : IDisposable
    {
        private EFDemoDbEntities db = new EFDemoDbEntities();
        public IEnumerable<Employee> GetAll()
        {
            var employee = db.Employee.Include(e => e.Department);
            return (employee.ToList());
        }
        public Employee GetById(int id)
        {
            Employee employee = db.Employee.Find(id);
            return employee;
        }
        public Employee Add(Employee emp)
        {
            db.Employee.Add(emp);
            db.SaveChanges();
            return emp;
        }
        public void Update(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }
        public Employee Delete(int id)
        {
            Employee emp = db.Employee.Find(id);
            if (emp == null)
                return null;
            db.Employee.Remove(emp);
            db.SaveChanges();
            return emp;
        }
        public Employee Delete(Employee emp)
        {
            db.Employee.Remove(emp);
            db.SaveChanges();
            return emp;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}