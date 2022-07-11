using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Name = "Ahmad",
                    Email = "ahmad@nawawi.com",
                    Department = Department.IT,
                    Id = 1
                },
                new Employee
                {
                    Name = "Mohammed",
                    Email = "mohammed@nawawi.com",
                    Department = Department.HR,
                    Id = 2
                });
        }
    }
}
