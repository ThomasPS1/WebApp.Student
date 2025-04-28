using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Student.Models
{
    [Table("Courses")]
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int InstructorId { get; set; }
        //one instructor
        public Instructors? Instructors { get; set; }
        //list of enrollment
        public List<Enrollment>? Enrollment { get; set; }

    }
}
