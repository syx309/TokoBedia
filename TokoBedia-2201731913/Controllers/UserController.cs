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
    public class UserController
    {
        public static List<User> GetUser()
        {
            return UserHandler.GetUsers();
        }

        public static User GetUser(int id)
        {
            return UserHandler.GetUser(id);
        }

        public static Response DoRegister(string email, string name, string password, string confirm_pass, string gender, int role)
        {
            if (email == "")
            {
                return new Response(false, "Fill your email");
            }
            if (UserHandler.IsUnique(email) == false)
            {
                return new Response(false, "Email has been used");
            }
            if (name == "")
            {
                return new Response(false, "Fill your name");
            }
            else if (password == "")
            {
                return new Response(false, "Fill your password");
            }
            else if (password != confirm_pass)
            {
                return new Response(false, "Passwords don't match");
            }
            else if (gender == "")
            {
                return new Response(false, "Choose your gender");
            }

            return new Response(UserHandler.DoRegister(email, name, password, gender, role), "Registered Successfully");
        }

        public static Response BlockUser(string block_id, string curr_id)
        {
            if (block_id == "" || block_id.All(char.IsDigit) != true)
            {
                return new Response(false, "id is invalid or empty");
            }
            if (block_id == curr_id)
            {
                return new Response(false, "You can't change your own status");
            }
            int id = Int32.Parse(block_id);

            return new Response(UserHandler.BlockUser(id), "User has been blocked successfully");
        }

        public static Response UnblockUser(string unblock_id, string curr_id)
        {
            if (unblock_id == "" || unblock_id.All(char.IsDigit) != true)
            {
                return new Response(false, "id is invalid or empty");
            }
            if (unblock_id == curr_id)
            {
                return new Response(false, "You can't change your own status");
            }
            int id = Int32.Parse(unblock_id);

            return new Response(UserHandler.UnblockUser(id), "User has been unblocked successfully");
        }

        public static Response ChangeRole(string userId, string curr_id)
        {
            if (userId == "" || userId.All(char.IsDigit) != true)
            {
                return new Response(false, "id is invalid or empty");
            }
            if (userId == curr_id)
            {
                return new Response(false, "You can't change your own role");
            }
            int id = Int32.Parse(userId);

            return new Response(UserHandler.ChangeRole(id), "User Role has been changed successfully");
        }
    }
}