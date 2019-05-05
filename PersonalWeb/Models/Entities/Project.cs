namespace PersonalWeb.Models.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string ProjectName { get; set; }
        public string Location { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public int FromYear { get; set; }
        public int FromMonth { get; set; }
        public int FromDay { get; set; }
        public int? ToYear { get; set; }
        public int? ToMonth { get; set; }
        public int? ToDay { get; set; }


    }
}
