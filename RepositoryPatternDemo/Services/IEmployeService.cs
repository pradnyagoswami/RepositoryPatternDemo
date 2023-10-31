using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IEmployeService
    {
        IEnumerable<Employe> GetEmployes();
        Employe GetEmployeById(int id);
        int AddEmploye(Employe employe);

        int UpdateEmploye(Employe employe);

        int DeleteEmploye(int id);
    }
}
