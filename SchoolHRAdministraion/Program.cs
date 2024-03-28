using System;
using HRAdministationAPI;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRAdministraion
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalary = 0;
            List<IEmployees> emp = new List<IEmployees>();

            SeedData(emp);
            foreach (var employee in emp)
            {
                totalSalary += employee.Salary;
            }
            //
            // Console.WriteLine($"Total salary: {totalSalary}");


            Console.WriteLine($"Total salary: {emp.Sum(e => e.Salary)}");
        }

        public static void SeedData(List<IEmployees> employees)
        {
            IEmployees teacher1 = EmployeesFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "John", "Doe", 1000);
            IEmployees teacher2 = EmployeesFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Jane", "Doe", 2000);


            IEmployees headOfDepartment =
                EmployeesFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Jack", "Doe", 3000);


            IEmployees deputyHeadMaster =
                EmployeesFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Jill", "Doe", 4000);

            employees.Add(teacher1);
            employees.Add(teacher2);
            employees.Add(headOfDepartment);
            employees.Add(deputyHeadMaster);
            Console.WriteLine("Data seeded successfully");
        }
    }


    public class Teacher : EmployeesBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.03m);
        }
    }

    public class HeadOfDepartment : EmployeesBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.05m);
        }
    }

    public class DeputyHeadMaster : EmployeesBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.07m);
        }
    }

    public class HeadMaster : EmployeesBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.1m);
        }
    }

    public static class EmployeesFactory
    {
        public static IEmployees GetEmployeeInstance(EmployeeType employeeType, int id, string firstName,
            string lastName, decimal salary)
        {
            IEmployees employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployees, Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEmployees, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPattern<IEmployees, DeputyHeadMaster>.GetInstance();
                    break;
            }

            if (employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Salary = salary;
            }

            return employee;
        }
    }
}