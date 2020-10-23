using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class PaymentTypeHandler
    {
        public static List<PaymentType> GetPaymentTypes()
        {
            return PaymentTypeRepository.GetPaymentTypes();
        }

        public static PaymentType GetPaymentType(int id)
        {
            return PaymentTypeRepository.GetPaymentType(id);
        }

        public static bool IsUnique(string type)
        {
            return PaymentTypeRepository.isUnique(type);
        }

        public static bool InsertPaymentType(string type)
        {
            PaymentTypeRepository.InsertPaymentType(type);
            return true;
        }

        public static bool UpdatePaymentType(int id,string type)
        {
            if(PaymentTypeRepository.GetPaymentType(id) != null)
            {
                PaymentTypeRepository.UpdatePaymentType(id, type);
                return true;
            }
            return false;
        }

        public static bool DeletePaymentType(int id)
        {
            if (PaymentTypeRepository.GetPaymentType(id) != null)
            {
                PaymentTypeRepository.DeletePaymentType(id);
                return true;
            }
            return false;
        }
    }
}