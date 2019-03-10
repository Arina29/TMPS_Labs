using System;
using System.Collections.Generic;

namespace Clothes
{
    public class Employee 
    {
        private string _name;
        private string _position;
        private Departments? _departmentName;
        private List<Employee> _employees;

        public Employee(string name, string position, Departments? departmentName)
        {
            _name = name;
            _position = position;
            _departmentName = departmentName;
            _employees = new List<Employee>();
        }

        public void DisplayEmployeeInfo()
        {
            string info = "[Employee: (";
            info += _departmentName == null ? "" : "Department name: " + _departmentName + "; ";
            Console.WriteLine(info + "Position: " + _position + "; Name: " + _name + ")]");
        }

        public void AddEmployee(Employee newEmployee)
        {
            _employees.Add(newEmployee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

        public List<Employee> GetEmployeesList()
        {
            return _employees;
        }

        public void Sew()
        {
            ClothesFacade clothesFacade = new ClothesFacade();
            switch (_departmentName)
            {
                case Departments.Blouse:
                {
                    clothesFacade.SewBlouse();
                    break;
                }
                case Departments.Jacket:
                {
                    clothesFacade.SewJackets();
                    break;
                }
                case Departments.Trousers:
                {
                    clothesFacade.SewTrousers();
                    break;
                }
            }
        }
    }
}
