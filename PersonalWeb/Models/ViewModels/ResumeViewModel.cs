using System.Collections.Generic;
using PersonalWeb.Models.Entities;

namespace PersonalWeb.Models.ViewModels
{
    public class ResumeViewModel
    {
        public UserInfo user { get; set; }
        public IEnumerable<Edu> eduDetails { get; set; }
        public IEnumerable<Work> workDetails { get; set; }
        public IEnumerable<Project> projectDetails { get; set; }
    }
}
