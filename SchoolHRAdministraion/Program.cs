using System;
using HRAdministationAPI;
using System.Collections.Generic;
using System.Linq;

namespace SchoolHRAdministraion
{
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
            IEmployees teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Salary = 1000
            };
            IEmployees teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Salary = 2000
            };

            IEmployees headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Jack",
                LastName = "Doe",
                Salary = 3000
            };

            IEmployees deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "Jill",
                LastName = "Doe",
                Salary = 4000
            };

            employees.Add(teacher1);
            employees.Add(teacher2);
            employees.Add(headOfDepartment);
            employees.Add(deputyHeadMaster);
            Console.WriteLine("Data seeded successfully");
        }
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