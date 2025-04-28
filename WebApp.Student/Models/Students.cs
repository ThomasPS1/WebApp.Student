using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Student.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }
        public string Location { get; set; }
        //list of enrollment
        public List<Enrollment>? Enrollments { get; set; } 
    }
}
