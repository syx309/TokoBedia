using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class PaymentTypeFactory
    {
        public static PaymentType InsertPaymentType(string type)
        {
            PaymentType paytype = new PaymentType()
            {
                Type = type
            };
            return paytype;
        }
    }
 }