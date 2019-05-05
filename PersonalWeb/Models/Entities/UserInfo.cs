using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalWeb.Models.Entities
{
    public enum Gender
    {
        Male,
        Female
    }

    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserFirstName { get; set; }
        [Required]
        public string UserLastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        [Required]
        public int YearOfBirth { get; set; }
        [Required]
        public int MonthOfBirth { get; set; }
        [Required]
        public int DayOfBirth { get; set; }
        [Required]
        public string Location { get; set; }
        [Required, Display(Name="PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        

        //public void update (UserInfo _userinfo)
        //{
        //    this.UserFirstName = _userinfo.UserFirstName;
        //    this.UserLastName = _userinfo.UserLastName;
        //    this.Age = _userinfo.Age;
        //    this.Address = _userinfo.Address;
        //    this.EmailAddress = _userinfo.EmailAddress;
        //    this.PhoneNumber = _userinfo.PhoneNumber;
        //}
    }
}
