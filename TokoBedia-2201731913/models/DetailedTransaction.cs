using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBedia_2201731913.models
{
    public class DetailedTransaction
    {
        public DateTime TransactionDate { get; set; }
        public string paymentType { get; set; }
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public int subTotal { get; set; }
    }
}