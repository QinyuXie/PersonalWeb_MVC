using System.ComponentModel.DataAnnotations;

namespace PersonalWeb.Models.Entities
{
    public class Edu
    {
        [Key]
        public int EduId { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public int FromYear { get; set; }
        public int FromMonth { get; set; }
        public int ? ToYear { get; set; }
        public int ? ToMonth { get; set; }
        public string Major { get; set; }
        public string ReleventCourses { get; set; }

    }
}
