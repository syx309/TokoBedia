using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class TransactionRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static HeaderTransaction insertHeaderTransaction(int userId, int paymentId, DateTime Date)
        {
            HeaderTransaction ht = TransactionFactory.insertHeaderTransaction(userId, paymentId, Date);
            db.HeaderTransactions.Add(ht);
            db.SaveChanges();
            return ht;
        }

        

        public static DetailTransaction insertDetailTransaction(int headerId, int productId, int quantity)
        {
            DetailTransaction dt = TransactionFactory.insertDetailTransaction(headerId, productId, quantity);
            db.DetailTransactions.Add(dt);
            db.SaveChanges();
            return dt;
        }

        public static List<DetailTransaction> getTransactions()
        {
            return (from transaction
                    in db.DetailTransactions
                    select transaction).ToList();
        }

        public static List<DetailedTransaction> getUserTransaction(string id)
        {
            int Id = Int16.Parse(id);
            return (from Transaction in db.DetailTransactions
                    join Header in db.HeaderTransactions on Transaction.TransactionID equals Header.Id
                    join Payment in db.PaymentTypes on Header.PaymentTypesId equals Payment.Id
                    join Product in db.Products on Transaction.ProductID equals Product.Id
                    where Id == Header.UserId
                    select new DetailedTransaction()
                    {
                        TransactionDate = Header.Date,
                        paymentType = Payment.Type,
                        productName = Product.Name,
                        productQuantity = Transaction.Quantity,
                        subTotal = Transaction.Quantity * Product.Price
                    }).ToList();
        }
    }
}