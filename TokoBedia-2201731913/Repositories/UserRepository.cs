using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class UserRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static List<User> GetUsers()
        {
            return (from User
                    in db.Users
                    select User).ToList();
        }

        public static User GetUser(string email, string password)
        {
            return (from User
                        in db.Users
                      where User.Email == email && User.Password == password
                      select User
                ).FirstOrDefault();
        }

        public static User GetUser(int id)
        {
            return (from User
                      in db.Users
                      where User.Id == id
                      select User).FirstOrDefault();
        }
        public static User InsertUser(string email,string name, string password,string gender, int role)
        {
            User u = UserFactory.InsertUser(email,name, password,gender,role);
            db.Users.Add(u);
            db.SaveChanges();

            return u;
        }

        public static User UpdateUser(int id,string email, string name, string gender)
        {
            User U = GetUser(id);
            U.Email = email;
            U.Name = name;
            U.Gender = gender;

            //Debug.Print();
            db.SaveChanges();
            return U;
        }

        public static User BlockUser(int id)
        {
            User u = GetUser(id);
            u.Status = "Blocked";
            db.SaveChanges();
            return u;
        }

        public static User unBlockUser(int id)
        {
            User u = GetUser(id);
            u.Status = "Active";
            db.SaveChanges();
            return u;
        }

        public static User updatePassword(int id,string password)
        {
            User u = GetUser(id);
            u.Password = password;
            db.SaveChanges();
            return u;
        }

        public static bool IsAdmin(string id)
        {
            int userID = Int16.Parse(id);

            User admin = (from User
                      in db.Users
                      where User.Id == userID
                      select User).FirstOrDefault();

            if (admin.RolesID == 1) return true;
            else return false;
        }

        public static bool IsUnique(string email)
        {
            User u = (from User
                      in db.Users
                      where User.Email == email
                      select User).FirstOrDefault();
            if (u == null) return true;
            return false;
        }

        public static User DeleteUser(int id)
        {
            User user = GetUser(id);

            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }

            return user;
        }

        public static User ChangeRole(int id)
        {
            User u = GetUser(id);
            if(u.RolesID == 1)
            {
                u.RolesID = 2;
            }
            else if(u.RolesID == 2)
            {
                u.RolesID = 1;
            }
            db.SaveChanges();
            return u;
        }
    }
}