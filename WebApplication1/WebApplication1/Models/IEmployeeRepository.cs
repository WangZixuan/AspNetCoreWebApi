namespace WebApplication1.Models
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
    }
}
