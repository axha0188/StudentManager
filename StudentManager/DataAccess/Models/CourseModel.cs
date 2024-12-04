using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentManager.DataAccess.Models
{
    public class CourseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string? Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of credits must be greater than 0")]
        public int Credits { get; set; }
    }
}
