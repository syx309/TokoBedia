using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class CartHandler
    {
        public static List<DetailedCart> GetCarts(int userId)
        {
            return CartRepository.GetCarts(userId);
        }

        public static Cart GetCart(int userId, int productId)
        {
            return CartRepository.GetCart(userId, productId);
        }

        public static bool InsertCart(int userId, int productId, int quantity )
        {
            Product p = ProductHandler.GetProduct(productId);
            Cart c = CartRepository.GetCart(userId, productId);

            if (quantity > p.Stock)
            {
                return false;
            }

            if( c != null)
            {
                int new_quantity = c.Quantity + quantity;
                CartRepository.UpdateCart(userId, productId, new_quantity);
                return true;
            }

            CartRepository.InsertCart(userId, productId, quantity);
            return true;
        }

        public static bool UpdateCart(int userId, int productId, int quantity)
        {
            Product p = ProductHandler.GetProduct(productId);

            if (quantity > p.Stock)
            {
                return false;
            }

            CartRepository.UpdateCart(userId, productId, quantity);
            return true;
        }

        public static bool DeleteCart(int userId, int productId)
        {
            Product p = ProductHandler.GetProduct(productId);
            User u = UserHandler.GetUser(userId);

            if( u != null && p != null)
            {
                CartRepository.DeleteCart(userId, productId);
                return true;
            }

            return false;
        }

        public static int GetGrandTotal(int userId)
        {
            return CartRepository.getCartTotal(userId);
        }
    }
}