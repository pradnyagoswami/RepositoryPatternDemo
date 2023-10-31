using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories;

namespace RepositoryPatternDemo.Services
{
    public class EmployeService : IEmployeService
    {
        private readonly IEmployeRepository repo;

        public EmployeService(IEmployeRepository repo)
        {

            this.repo = repo;
        }

        public int AddEmploye(Employe employe)
        {
           return repo.AddEmploye(employe);
        }

        public int DeleteEmploye(int id)
        {
            return repo.DeleteEmploye(id);
        }

        public Employe GetEmployeById(int id)
        {
            return repo.GetEmployeById(id);
        }

        public IEnumerable<Employe> GetEmployes()
        {
            return repo.GetEmployes();
        }

        public int UpdateEmploye(Employe employe)
        {
            return repo.UpdateEmploye(employe);
        }
    }
}
