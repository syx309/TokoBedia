using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Controllers
{
    public class CartController
    {
        public static Response InsertCart(int userId, int productId, string quantity)
        {
            if(quantity == "" || quantity.All(char.IsDigit) != true)
            {
                return new Response(false, "Quantity cannot be empty or non numeric");
            }
            int _quantity = Int32.Parse(quantity);

            if (CartHandler.InsertCart(userId,productId,_quantity))
            {
                return new Response(true, "Product has been added to cart");
            }
            return new Response(false, "Quantity invalid");
        }

        public static Response UpdateCart(int userId, int productId, string quantity)
        {
            if (quantity == "" || quantity.All(char.IsDigit) != true)
            {
                return new Response(false, "Quantity cannot be empty or non numeric");
            }
            int _quantity = Int32.Parse(quantity);

            if (CartHandler.UpdateCart(userId, productId, _quantity))
            {
                return new Response(true, "Cart has been updated");
            }

            return new Response(false, "Quantity invalid");
        }

        public static Response CheckOut(List<DetailedCart> Cart, string paymentId, int userId)
        {
            if(paymentId == "" || paymentId.All(char.IsDigit) != true)
            {
                return new Response(false, "Payment ID cannot be empty or non numeric");
            }

            int _paymentId = Int32.Parse(paymentId);
            if (PaymentTypeHandler.GetPaymentType(_paymentId) == null)
            {
                return new Response(false, "Wrong Payment Type ID");
            }

            if(Cart == null)
            {
                return new Response(false, "Cart Cannot be empty");
            }

            TransactionHandler.CheckOut(Cart, _paymentId,userId);
            return new Response(true, "Cart successfully checked out");
        }
    }
}