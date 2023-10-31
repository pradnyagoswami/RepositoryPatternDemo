
using RepositoryPatternDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RepositoryPatternDemo.Data
{
    
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Employe> Employes { get; set; }
        public static implicit operator ApplicationBuilder(ApplicationDbContext v)
        {

            throw new NotImplementedException();
        }


    }
}
