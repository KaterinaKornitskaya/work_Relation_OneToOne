using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_Relation_OneToOne.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    

        public UserSettings UserSettings { get; set; }

        public static List<User> TestData()
        {
            List<User> users = new List<User>
            {
                new User
                {
                    FirstName = "Kate",
                    LastName = "Kornitskaya",
                    UserSettings = new UserSettings
                    {
                        Age = 45,
                        Passport = "FR75767865"
                    }
                },
                new User
                {
                    FirstName = "Alex",
                    LastName = "Bobrenko",
                    UserSettings = new UserSettings
                    {
                        Age = 22,
                        Passport = "GH6567535"
                    }
                },
                new User
                {
                    FirstName = "Olga",
                    LastName = "Matviychuk",
                    UserSettings = new UserSettings
                    {
                        Age = 19,
                        Passport = "GH6921156"
                    }
                }
            };
            return users;
        }
    }
}
