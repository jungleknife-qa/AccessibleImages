using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessibleImages.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Email]
        public string Email { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            if (password.Any(char.IsDigit))
                return true;

            return false;

        }

        public bool CheckPasswordLength(string password)
        {
            if (password.Length >= 8)
                return true;

            return false;

        }


    }
}
