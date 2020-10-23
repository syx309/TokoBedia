using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class PaymentTypeRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static List<PaymentType> GetPaymentTypes()
        {
            return (from PaymentType
                    in db.PaymentTypes
                    select PaymentType).ToList();
        }

        public static PaymentType GetPaymentType(int id)
        {
            return (from PaymentType
                      in db.PaymentTypes
                      where PaymentType.Id == id
                      select PaymentType).FirstOrDefault();
        }

        public static PaymentType InsertPaymentType(string type)
        {
            PaymentType paytype = PaymentTypeFactory.InsertPaymentType(type);
            db.PaymentTypes.Add(paytype);
            db.SaveChanges();

            return paytype;
        }

        public static PaymentType UpdatePaymentType(int ID, string type)
        {
            PaymentType paytype = GetPaymentType(ID);
            paytype.Type = type;

            db.SaveChanges();
            return paytype;
        }

        public static PaymentType DeletePaymentType(int ID)
        {
            PaymentType paytype = GetPaymentType(ID);
            if (paytype != null)
            {
                db.PaymentTypes.Remove(paytype);
                db.SaveChanges();
            }
            return paytype;
        }

        public static bool isUnique(string type)
        {
            PaymentType paytype = (from PaymentType
                              in db.PaymentTypes
                              where PaymentType.Type == type
                              select PaymentType
                ).FirstOrDefault();

            if (paytype == null) return true;
            else return false;
        }
    }
}