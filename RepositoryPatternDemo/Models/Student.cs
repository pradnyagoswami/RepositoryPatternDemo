﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternDemo.Models
{
    [Table("Student")]
    public class Student
    {
        
           [Key] 
            public int RollNo { get; set; }

            [Required]
            public string? Name { get; set; }

            [Required]
            public int Percentage { get; set; }

            [Required]
            public string? City { get; set; }

        





    }
}
