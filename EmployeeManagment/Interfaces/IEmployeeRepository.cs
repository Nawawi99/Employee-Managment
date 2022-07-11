namespace EmployeeManagment.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        void UpdateEmployee(Employee newEmployee);
        Employee DeleteEmployee(int id);
    }
}
