using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class TransactionFactory
    {
        public static HeaderTransaction insertHeaderTransaction(int userId, int paymentId, DateTime TransDate)
        {
            HeaderTransaction ht = new HeaderTransaction()
            {
                UserId = userId,
                PaymentTypesId = paymentId,
                Date = TransDate
            };
            return ht;
        }

        public static DetailTransaction insertDetailTransaction(int headerId, int productId, int quantity)
        {
            DetailTransaction dt = new DetailTransaction() {
                TransactionID = headerId,
                ProductID = productId,
                Quantity = quantity
            };

            return dt;
        }

    }
}