//using System;
//using PersonalWeb.Models.Entities;
//using PersonalWeb.Models.ViewModels;
//using System.Collections.Generic;
//using System.Collections;
//namespace PersonalWeb.Services
//{ 

//    public class MockResumeData : IResumeData
//    {
//        private ResumeViewModel _resume;

//        public MockResumeData()
//        {
//            _resume = new ResumeViewModel
//            {
//                user = new UserInfo
//                {
//                    UserId = 1,
//                    UserFirstName = "Qinyu",
//                    UserLastName = "Xie",
//                    Gender = "Male",
//                    Age = 23,
//                    Location = "Syracuse",
//                    Address = "505 Walnut Ave",
//                    PhoneNumber = "3154508661",
//                    EmailAddress = "qinyu.syr@gmail.com",
//                    DayOfBirth = 4,
//                    MonthOfBirth = 2,
//                    YearOfBirth = 2018
//                },

//                eduDetails = new List<Edu>
//                {
//                    new Edu
//                    {
//                        EduId = 1,

//                        SchoolName = "Syracuse University",
//                        Degree = "Master",
//                        FromYear = 2018,
//                        FromMonth = 8,
//                        Major = "Computer Engineering",
//                        ReleventCourses = "Advanced Data Structure and Algorithm"
//                    }

//                },

//                workDetails = new List<Work>
//                {
//                    new Work
//                    {
//                        WorkId = 1,
//                        CompanyName = "COWA Robot",
//                        Position = "Software Engineer Intern",
//                        FromYear = 2018,
//                        FromMonth = 8,
//                        FromDay = 14,
//                        Location = "Shanghai",
//                        Responsibility = "Repair Computer"

//                    }
//                },

//                projectDetails = new List<Project>
//                {
//                    new Project
//                    {
//                        ProjectId = 1,
//                        ProjectName = "Personal Web",
//                        Location = "Syracuse",
//                        Description = "",
//                        FromYear = 2018,
//                        FromMonth = 8,
//                        FromDay = 14

//                    }

//                }
//            };
        
//        }

//        public ResumeViewModel GetInstance()
//        {
//            return _resume;
//        }
//    }
//}
