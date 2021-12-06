namespace WebApplication1.Models
{
    public class HardCodeEmployeeRepository : IEmployeeRepository
    {
        public Employee GetById(int id)
        {
            return _employees.First(emp => emp.Id == id);
        }

        private List<Employee> _employees = new()
        {
            new Employee{ Id = 0, Name = "Johny" },
            new Employee{ Id = 1, Name = "John" },
            new Employee{ Id = 2, Name = "Sam" },
            new Employee{ Id = 3, Name = "Jesus" }
        };
    }
}
