using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidation.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string SocialAddress { get; set; }
        public string Address { get; set; }
        public string StudentNumber { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
