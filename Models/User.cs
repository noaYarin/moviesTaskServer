using Microsoft.AspNetCore.Identity;
using System;

namespace movieTasks.Models
{
    public class User
    {
        int id;
        string name;
        string email;
        string password;
        bool active = true;

        static List<User> usersList = new List<User>();
        private static PasswordHasher<User> hasher = new PasswordHasher<User>();

        public User() { }   

        public User(int id, string name, string email, string password, bool active)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = hasher.HashPassword(this, password);
            this.active = active;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Active { get => active; set => active = value; }

        public bool CheckPassword(string userPassword)
        {
            var result = hasher.VerifyHashedPassword(this, this.Password, userPassword);
            return result == PasswordVerificationResult.Success;
        }

        public void SetPassword(string plainPassword)
        {
            this.password = hasher.HashPassword(this, plainPassword);
        }

        public bool Insert()
        {
            foreach (User user in usersList)
            {
                if (user.id == this.id || user.email== this.email)
                {
                    return false;
                }
            }

            this.SetPassword(this.Password);

            usersList.Add(this);
            return true;
        }

        public bool Register()
        {
            if (Insert())
            {
                return true;
            }
            return false;
        }

        public bool Login()
        {
            foreach (User user in usersList)
            {
                if (user.CheckPassword(this.password) && user.email==this.email)
                {
                    return true;
                }
            }
            return false;
        }


        public List<User> Read()
        {
            return usersList;
        }
    }
}
