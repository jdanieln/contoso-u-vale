using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU_VLA.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
