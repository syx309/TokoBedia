using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Controllers
{
    public class ProfileController
    {
        public static Response UpdateProfile(string user_id, string email, string name, string gender)
        {
            int id = Int32.Parse(user_id);

            if (email == "" || UserRepository.IsUnique(email) == false)
            {
                return new Response(false, "Email is used or empty");
            }
            if (name == "")
            {
                return new Response(false, "Name is invalid");
            }
            if (gender == "")
            {
                return new Response(false, "Gender is invalid");
            }

            return new Response(UserHandler.UpdateProfile(id, email, name, gender), "Profile has been Updated");
        }

        public static Response UpdatePassword(string userId, string oldPass, string newPass, string confirmPass)
        {
            int id = Int32.Parse(userId);
            User U = UserHandler.GetUser(id);
            if (oldPass == "")
            {
                return new Response(false, "Old password is empty");
            }
            if (oldPass != U.Password)
            {
                return new Response(false, "Old password is wrong");
            }
            if (newPass == "")
            {
                return new Response(false, "New password is wrong");
            }
            if (newPass.Length < 5)
            {
                return new Response(false, "Password need to be at least 5 character");
            }
            if (newPass != confirmPass)
            {
                return new Response(false, "Password doesn't match");
            }

            return new Response(UserHandler.UpdatePassword(id, newPass), "Password has been changed");

        }

    }
}