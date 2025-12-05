using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagment.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column("StudentName",TypeName ="varchar(20)")]
        public string? StudentName { get; set; }
        [Column("StudentGender", TypeName = "varchar(20)")]
        public string? Gender { get; set; }

        public int Age { get; set; }

        public int Standard { get; set; }

    }
}
