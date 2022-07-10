using EmployeeManagment.Data;

namespace EmployeeManagment.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee deletedEmployee = _context.Employees.Find(id);
            _context.Employees.Remove(deletedEmployee);
            _context.SaveChanges();
            return deletedEmployee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            Employee employee = _context.Employees.Find(employeeChanges.Id);
            employee.Name = employeeChanges.Name;
            employee.Email = employeeChanges.Email;
            employee.Department = employeeChanges.Department;
            _context.Employees.Update(employee);
            return employee;
        }
    }
}
