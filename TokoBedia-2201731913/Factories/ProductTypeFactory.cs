using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Factories
{
    public class ProductTypeFactory
    {
        public static ProductType insertProductType(string name, string description)
        {
            ProductType pt = new ProductType()
            {
                Name = name,
                Description = description
            };
            return pt;
        }
    }
}