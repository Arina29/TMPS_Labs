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
            Employee director = new Employee("Aurel", "Company director", null);
            Employee headOfBlouseDepartment = new Employee("Ionel", "Head of deparment", Departments.Blouse);
            Employee headOfTrousersDepartment = new Employee("Ionela", "Head of deparment", Departments.Trousers);
            Employee headOfJacketDepartment = new Employee("Dorina", "Head of deparment", Departments.Jacket);
            Employee blouseEmployee1 = new Employee("Gabi", "Seamstress", Departments.Blouse);
            Employee trousersEmployee1 = new Employee("Gabi1", "Seamstress", Departments.Trousers);
            Employee jacketEmployee1 = new Employee("Gabi2", "Seamstress", Departments.Jacket);
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
