using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class UserFactory
    {

        public static User InsertUser(string email,string name, string password,string gender,int role)
        {
            User u = new User()
            {
                Email = email,
                Name = name,
                Password = password,
                Gender = gender,
                Status = "Active",
                RolesID = role
            };

            return u;
        }
    }
}