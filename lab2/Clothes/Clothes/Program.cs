using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee director = new Employee("Frodo", "Company director", null);
            Employee headOfBlouseDepartment = new Employee("Harry", "Head of deparment", Departments.Blouse);
            Employee headOfTrousersDepartment = new Employee("Emily ", "Head of deparment", Departments.Trousers);
            Employee headOfJacketDepartment = new Employee("John", "Head of deparment", Departments.Jacket);
            Employee blouseEmployee1 = new Employee("Elena", "Seamstress", Departments.Blouse);
            Employee trousersEmployee1 = new Employee("Julia", "Seamstress", Departments.Trousers);
            Employee jacketEmployee1 = new Employee("Stefan", "Seamstress", Departments.Jacket);
            headOfBlouseDepartment.AddEmployee(blouseEmployee1);
            headOfTrousersDepartment.AddEmployee(trousersEmployee1);
            headOfJacketDepartment.AddEmployee(jacketEmployee1);
            director.AddEmployee(headOfBlouseDepartment);
            director.AddEmployee(headOfTrousersDepartment);
            director.AddEmployee(headOfJacketDepartment);

            foreach (var head in director.GetEmployeesList())
            {
                Console.WriteLine("-----------------------------------------------------------");
                head.DisplayEmployeeInfo();
                foreach (var seamstress in head.GetEmployeesList())
                {
                    seamstress.DisplayEmployeeInfo();
                    seamstress.Sew();
                }
            }

            Console.ReadKey();

        }
    }
}
