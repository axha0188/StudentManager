using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManager.DataAccess.Models
{
    public class EnrollmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
        
        [ForeignKey("StudentId")]
        public StudentModel Student { get; set; }
        
        [ForeignKey("CourseId")]
        public CourseModel Course { get; set; }
    }
}
