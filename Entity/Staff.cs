using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scaffolding.Identity;
namespace Scaffolding.Entity
{
    public class Staff
    {
        public int Id{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string PhoneNumber{get; set;}
        public string Email{get; set;}
        public string StaffNumber{get; set;}
        public User User{get; set;}
        public byte[] ProfilePicture{get; set;}
        public string ProfilePictureUrl{get; set;}
    }
}