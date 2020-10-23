using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class ProductRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static List<Product> GetProducts(){
            return (from Product
                    in db.Products
                    select Product).ToList();
        }

        public static Product GetProduct(int ID)
        {
            return (from Product
                    in db.Products
                    where Product.Id == ID
                    select Product).FirstOrDefault();
        }

        public static Product insertProduct(string name, int stock, int price)
        {
            Product p = ProductFactory.insertProduct(name, stock, price);
            db.Products.Add(p);
            db.SaveChanges();
            return p;
        }

        public static Product UpdateProduct(int ID, string name, int stock, int price)
        {
            Product p = GetProduct(ID);
            p.Name = name;
            p.Stock = stock;
            p.Price = price;

            db.SaveChanges();
            return p;
        }

        public static Product UpdateProductBought(int ID,int bought)
        {
            Product p = GetProduct(ID);
            p.Stock = p.Stock-bought;

            db.SaveChanges();
            return p;
        }

        public static Product DeleteProduct(int ID)
        {
            Product p = GetProduct(ID);
            if (p != null)
            {
                db.Products.Remove(p);
                db.SaveChanges();
            }
            return p;
        }

        public static List<Product> randomProduct()
        {
            return db.Products.OrderBy(p => Guid.NewGuid()).Take(5).ToList();
        }
    }
}