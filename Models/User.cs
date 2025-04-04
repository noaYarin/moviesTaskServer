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
        public User() { }   

        public User(int id, string name, string email, string password, bool active)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.active = active;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public bool Active { get => active; set => active = value; }


        public bool Insert()
        {
            foreach (User user in usersList)
            {
                if (user.id == id)
                {
                    return false;
                }
            }

            usersList.Add(this);
            return true;
        }

        public List<User> Read()
        {
            return usersList;
        }
    }
}
