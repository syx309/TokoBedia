using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class UserHandler
    {
        public static bool DoRegister(string email, string name, string password, string gender, int role)
        {
            if (UserRepository.GetUser(email, password) == null)
            {
                User newUser = UserFactory.InsertUser(email, name, password, gender, role);
                UserRepository.InsertUser(email, name, password, gender, role);
                return true;
            }

            return false;
        }

        public static List<User> GetUsers()
        {
            return UserRepository.GetUsers();
        }

        public static User GetUser(int id)
        {
            return UserRepository.GetUser(id);
        }

        public static User GetUser(string email,string password)
        {
            return UserRepository.GetUser(email, password);
        }

        public static bool DeleteUser(int id)
        {
            if (UserRepository.GetUser(id) != null)
            {
                // Clear all carts associated to this user
                UserRepository.DeleteUser(id);
                return true;
            }

            return false;
        }

        public static bool IsUnique(string email)
        {
            return UserRepository.IsUnique(email);
        }

        public static bool IsAdmin(string id)
        {
            return UserRepository.IsAdmin(id);
        }

        public static bool BlockUser(int id)
        {
            if(UserRepository.GetUser(id) != null)
            {
                UserRepository.BlockUser(id);
                return true;
            }

            return false;
        }

        public static bool UnblockUser(int id)
        {
            if (UserRepository.GetUser(id) != null)
            {
                UserRepository.unBlockUser(id);
                return true;
            }

            return false;
        }

        public static bool ChangeRole(int id)
        {
            if (UserRepository.GetUser(id) != null)
            {
                UserRepository.ChangeRole(id);
                return true;
            }

            return false;
        }

        public static bool UpdateProfile(int id, string email, string name, string gender)
        {
            if(UserRepository.GetUser(id) != null)
            {
                UserRepository.UpdateUser(id,email,name,gender);
                return true;
            }

            return false;
        }

        public static bool UpdatePassword(int userId, string newPass)
        {
            if (UserRepository.GetUser(userId) != null)
            {
                UserRepository.updatePassword(userId, newPass);
                return true;
            }

            return false;
        }
    }
}