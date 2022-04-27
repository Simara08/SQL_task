using ConsoleAppFramework.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AppContext = ConsoleAppFramework.DataAccess.AppContext;
using ConsoleAppFramework.Model;

namespace ConsoleAppFramework.Controller
{
   public class EmployeeController
    {
        private readonly AppContext _context;
        public EmployeeController()
        {
            _context = new AppContext();
        }
        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
        public void Created(string fullname)
        {
            Employee emp1 = new Employee { FullName = fullname };
            _context.Employees.Add(emp1);
            _context.SaveChanges();
        } 

        public void Edit(int id,string fulname)
        {
            Employee employeedb = _context.Employees.Find();
            if (employeedb==null)
            {
                Console.WriteLine("Not fount");
            }
            if(!String.IsNullOrEmpty(fulname))
            {
                employeedb.FullName = fulname;
            }
            _context.SaveChanges();
        }
        public void Delete(int? id)
        {
            if (id==null)
            {
                Console.WriteLine("Not fount");
            }
            else
            {
                Employee employeedb = _context.Employees.Find(id);
                if (employeedb==null)
                {
                    Console.WriteLine("Not fount");
                }
                else
                {
                    _context.Employees.Remove(employeedb);
                    _context.SaveChanges();
                    Console.WriteLine("Ok");
                }
            }
        }

        public void Filter(string search)
        {
            List<Employee> empList = _context.Employees.ToList();
            bool Isex = false;
            foreach (var item in empList)
            {
                if (item.FullName.ToLower().Contains(search)  || item.FullName.ToUpper().Contains(search))
                {
                    Console.WriteLine(item.FullName);
                }

            }
            if (Isex==false)
            {
                Console.WriteLine("Bele ishci yoxdur");
            }
        }
    }
}
