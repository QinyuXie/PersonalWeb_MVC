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
        //public ResumeViewModel(UserInfo _user, 
        //                        IEnumerable<Edu> _eduDetails,
        //                        IEnumerable<Work> _workDetails,
        //                        IEnumerable<Project> _projectDetails)
        //{
        //    user = _user;
        //    eduDetails = _eduDetails;
        //    workDetails = _workDetails;
        //    projectDetails = _projectDetails;
        //}
    }
}
