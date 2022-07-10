namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee newEmployee);
        Employee DeleteEmployee(int id);
    }
}
