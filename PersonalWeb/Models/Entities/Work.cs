using System.ComponentModel.DataAnnotations;


namespace PersonalWeb.Models.Entities
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Position { get; set; }
        public string Responsibility { get; set; }
        public int FromYear { get; set; }
        public int FromMonth { get; set; }
       
        public int? ToYear { get; set; }
        public int? ToMonth { get; set; }



    }
}
