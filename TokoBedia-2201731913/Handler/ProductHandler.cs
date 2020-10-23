using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class ProductHandler
    {
        public static List<Product> GetProducts()
        {
            return ProductRepository.GetProducts();
        }

        public static List<Product> GetRandomProducts()
        {
            return ProductRepository.randomProduct();
        }

        public static Product GetProduct(int id)
        {
            return ProductRepository.GetProduct(id);
        }
 
        public static bool InsertProduct(string name,int stock,int price)
        {
            ProductRepository.insertProduct(name, stock, price);
            return true;
        }

        public static bool UpdateProduct(int ID, string name, int stock, int price)
        {
            ProductRepository.UpdateProduct(ID, name, stock, price);
            return true;
        }
        public static bool DeleteProduct(int id)
        {
            if (ProductRepository.GetProduct(id) != null)
            {
                ProductRepository.DeleteProduct(id);
                return true;
            }

            return false;
        }

    }
}