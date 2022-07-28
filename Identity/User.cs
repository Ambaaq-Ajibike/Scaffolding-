using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Scaffolding.Entity;
namespace Scaffolding.Identity
{
    public class User : IdentityUser
    {
        public  string FirstName{get; set;}
        public  string LastName{get; set;}
        public byte[] ProfilePicture{get; set;}
        public int UserNameChangeLimit{get; set;}
        public string ProfilePictureUrl{get; set;}
    }
}