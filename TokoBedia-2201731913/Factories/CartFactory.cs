using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class CartFactory
    {
        public static Cart InsertCart(int userId, int productId, int quantity)
        {
            Cart c = new Cart()
            {
                UserId = userId,
                ProductId = productId,
                Quantity = quantity
            };

            return c;
        }
    }
}