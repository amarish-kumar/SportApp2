using SportApp2.Core.Domain.Base;
using System;

namespace SportApp2.Core.Domain
{
    public class User : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public float Height { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void SetEmail(string email)
        {
            if(!string.IsNullOrEmpty(email))
            {
                Email = email;
            }
            else
            {
                throw new Exception();
            }
        }

        public void SetPassword(string password)
        {
            if(!string.IsNullOrEmpty(password))
            {
                Password = password;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}