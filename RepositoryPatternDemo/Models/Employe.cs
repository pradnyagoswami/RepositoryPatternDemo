
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternDemo.Models
{

    [Table("Employe")]
    public class Employe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Salary { get; set; }



    }
}
