using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public interface IEmployeRepository
    {

        IEnumerable<Employe> GetEmployes();
        Employe GetEmployeById(int id);
        int AddEmploye(Employe employe);

        int UpdateEmploye(Employe employe);

        int DeleteEmploye(int id);


    }
}
