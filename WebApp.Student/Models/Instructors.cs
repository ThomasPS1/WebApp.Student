using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Student.Models
{
    [Table("Instructor")]
    public class Instructors
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        //list of course
        public List<Courses>? Courses { get; set; }
    }
}
