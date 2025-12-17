using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace students_crud.Models
{
    public class Student
    {
        [Key]
        [DisplayName("StudentId")]
        public int studentId { get; set; }
        [Required]
        [DisplayName("StudentName")]
        
        public string studentName { get; set; }
        [Required]
        [DisplayName("StudentEmail")]
        public string studentEmail { get; set; }
        [DisplayName("StudentGender")]
        public string studentGender { get; set; }



    }
}
