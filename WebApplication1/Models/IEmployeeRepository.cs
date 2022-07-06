namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
    }
}
