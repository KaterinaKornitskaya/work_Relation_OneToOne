using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_Relation_OneToOne.Data;
using work_Relation_OneToOne.Interfaces;
using work_Relation_OneToOne.Model;

namespace work_Relation_OneToOne.Repository
{
    internal class UserRepository : IUser
    {
        public void AddUser()
        {
            using (ApplicationContext db = Program.DbContext())
            {
                User us = new User
                {
                    FirstName = "Kate",
                    LastName = "Radchenko",
                    UserSettings = new UserSettings
                    {
                        Age = 29,
                        Passport = "asgdfahvdafg"
                    }
                };
                db.Users.Add(us);
                db.SaveChanges();
            }
        }

        public void AddTestData()
        {

            List<User> users = User.TestData();
            using (ApplicationContext db = Program.DbContext())
            {
                // добавить тестовые данные, только если БД ранее не было
                if(db.Database.EnsureCreated() == true)
                {
                    db.Users.AddRange(users);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteUser()
        {
            using (ApplicationContext db = Program.DbContext())
            {
                var us = db.Users.FirstOrDefault(user => user.Id == 8);
                if(us is not null)
                {
                    db.Users.Remove(us);
                    db.SaveChanges();
                }
            }
        }

        public void DeleteUser2(int id)
        {
            using (ApplicationContext db = Program.DbContext())
            {
                try
                {
                    db.Users.Where(u => u.Id==id).ExecuteDelete();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        public void GetUserById(int id)
        {
            using (ApplicationContext db = Program.DbContext())
            {
                try
                {
                    var x = db.Users.Include(u => u.UserSettings).FirstOrDefault(u => u.Id==id);
                    Console.WriteLine($"Name: {x.FirstName}, " +
                        $"Surname: {x.LastName}, " +
                        $"Age: {x.UserSettings.Age}, " +
                        $"Passport: {x.UserSettings.Passport}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                
            }
        }
    }
}
