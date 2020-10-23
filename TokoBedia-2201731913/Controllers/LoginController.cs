using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;

namespace TokoBedia_2201731913.Controllers
{
    public class LoginController
    {
        public static Response DoLogin(string email, string password)
        {
            if (email == "")
            {
                return new Response(false, "Email cannot be empty");
            }
            if (password == "")
            {
                return new Response(false, "Password cannot be empty");
            }

            Response response = LoginHandler.DoLogin(email, password);
            return response;
        }

        public static bool IsBlocked(string email, string password)
        {
            bool status = LoginHandler.GetStatus(email,password);
            return status;
        }
    }
}