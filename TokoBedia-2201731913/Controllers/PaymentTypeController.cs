using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;

namespace TokoBedia_2201731913.Controllers
{
    public class PaymentTypeController
    {
        public static Response InsertPaymentType(string type)
        {
            if (type == "" || type.Length < 3)
            {
                return new Response(false, "Please insert the type and/or a minimum of 3 character");
            }
            if(PaymentTypeHandler.IsUnique(type) == false)
            {
                return new Response(false, "Payment Type needs to be unique");
            }

            return new Response(PaymentTypeHandler.InsertPaymentType(type), "Product Type has been inserted");
        }

        public static Response UpdatePaymentType(int id, string type)
        {
            if (type == "" || type.Length < 3)
            {
                return new Response(false, "Please insert the type and/or a minimum of 3 character");
            }
            if (PaymentTypeHandler.IsUnique(type) == false)
            {
                return new Response(false, "Payment Type needs to be unique");
            }

            return new Response(PaymentTypeHandler.UpdatePaymentType(id, type), "Product Type has been inserted");
        }
    }
}