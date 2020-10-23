using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Helpers;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class LoginHandler
    {
        public static Response DoLogin(string email, string password)
        {
            User user = UserRepository.GetUser(email, password);

            // user not found
            if (user == null)
            {
                return new Response(false, "Wrong email or password");
            }
           
            // !! You can also add banned validation here !!

            return new Response(true, user.Id.ToString());
        }

        public static bool GetStatus(string email,string password)
        {
            User user = UserRepository.GetUser(email, password);

            if(user.Status == "Blocked")
            {
                return true;
            }

            return false;
        }
    }
}