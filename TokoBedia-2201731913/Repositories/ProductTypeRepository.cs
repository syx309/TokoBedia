using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class ProductTypeRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static List<ProductType> GetProductType()
        {
            return (from ProductType
                    in db.ProductTypes
                    select ProductType).ToList();
        }

        public static ProductType GetProductType(int id)
        {
            return (from ProductType
                    in db.ProductTypes
                    where ProductType.Id == id
                    select ProductType).FirstOrDefault();
        }

        public static ProductType insertProductType(string name, string description)
        {
            ProductType pt = ProductTypeFactory.insertProductType(name, description);
            db.ProductTypes.Add(pt);
            db.SaveChanges();
            return pt;
        }

        public static ProductType UpdateProductType(int ID, string name, string desc)
        {
            ProductType pt = GetProductType(ID);
            pt.Id = ID;
            pt.Name = name;
            pt.Description = desc;

            db.SaveChanges();
            return pt;
        }

        public static ProductType DeleteProductType(int ID)
        {
            ProductType pt = GetProductType(ID);
            if (pt != null)
            {
                db.ProductTypes.Remove(pt);
                db.SaveChanges();
            }
            return pt;
        }

        public static bool isUnique(string name)
        {
            ProductType pt = (from ProductType
                              in db.ProductTypes
                              where ProductType.Name == name
                              select ProductType
                ).FirstOrDefault();

            if (pt == null) return true;
            else return false;
        }
    }

}