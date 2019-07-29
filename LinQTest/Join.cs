using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQTest
{
    class Join
    {
        class JoinTable
        {
            class Department
            {
                public int DepartmentId { get; set; }
                public string Name { get; set; }
            }

            class Employee
            {
                public int EmployeeId { get; set; }
                public string EmployeeName { get; set; }
                public int DepartmentId { get; set; }
            }

            public static void Main()
            {
                List<Department> departments = new List<Department>();
                departments.Add(new Department { DepartmentId = 1, Name = "Account" });
                departments.Add(new Department { DepartmentId = 2, Name = "Sales" });
                departments.Add(new Department { DepartmentId = 3, Name = "Marketing" });

                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee { DepartmentId = 1, EmployeeId = 1, EmployeeName = "William" });
                employees.Add(new Employee { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Miley" });
                employees.Add(new Employee { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Benjamin" });

                var list = (from e in employees
                            join d in departments on e.DepartmentId equals d.DepartmentId
                            select new
                            {
                                EmployeeName = e.EmployeeName,
                                DepartmentName = d.Name
                            }) ;

                foreach (var e in list)
                {
                    Console.WriteLine("Employee Name = {0} , Department Name = {1}",
                             e.EmployeeName, e.DepartmentName);
                }


            }
        }
    }
}
