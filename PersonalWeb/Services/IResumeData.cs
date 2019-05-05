using System;
using PersonalWeb.Models.ViewModels;

namespace PersonalWeb.Services
{
    public interface IResumeData
    {
        ResumeViewModel GetInstance();
    }
}
