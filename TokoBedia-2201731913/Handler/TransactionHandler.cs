using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class TransactionHandler
    {
        public static void CheckOut(List<DetailedCart> Cart, int paymentId,int userId)
        {
            DateTime today = DateTime.Now;
            HeaderTransaction ht = TransactionRepository.insertHeaderTransaction(userId, paymentId,today);

            foreach(DetailedCart cart in Cart)
            {
                TransactionRepository.insertDetailTransaction(ht.Id,cart.ProductId, cart.Quantity);


                ProductRepository.UpdateProductBought(cart.ProductId, cart.Quantity);
                CartHandler.DeleteCart(userId, cart.ProductId);
            }
            
        }

        public static List<DetailedTransaction> getTransactions(string id)
        {
                return TransactionRepository.getUserTransaction(id);
        }

        public static List<DetailTransaction> getAdminTransactions()
        {
            return TransactionRepository.getTransactions();
        }
    }
}