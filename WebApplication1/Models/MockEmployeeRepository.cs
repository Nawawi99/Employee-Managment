﻿namespace WebApplication1.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee(){Id=1, Name="Ahmad", Email="Ahmad@gmail.com", Department=Department.IT},
                new Employee(){Id=2, Name="wesam", Email="wwww@gmail.com", Department=Department.HR},
                new Employee(){Id=4, Name="Diesel", Email="dddd@gmail.com", Department=Department.Marketing},
                new Employee(){Id=5, Name="kahled", Email="kkkk@gmail.com", Department=Department.IT}
            };
        }

        public void AddEmployee(Employee employee)
        {
            employee.Id = _employees.Max(emp => emp.Id) + 1;
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id) ?? _employees[0];
        }
    }
}
