using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class ProductFactory
    {
        public static Product insertProduct(string name, int stock, int price)
        {
            Product p = new Product() {
                Name = name,
                Stock = stock,
                Price = price,
            };
            return p;
        }

    }
}