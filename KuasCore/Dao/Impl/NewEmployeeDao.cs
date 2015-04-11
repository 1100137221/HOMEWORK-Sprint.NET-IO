
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "fish";
            employees1.Name = "魚";
            employees1.Age = 15;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Tom";
            employees2.Name = "湯姆";
            employees2.Age = 20;
            employees.Add(employees2);


            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "1100137221";
            employees.Name = "陳冠儒";
            employees.Age = 21;
            return employees;
        }

    }
}
