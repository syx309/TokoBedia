using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Handler
{
    public class ProductTypeHandler
    {
        public static List<ProductType> GetProductTypes()
        {
            return ProductTypeRepository.GetProductType();
        }

        public static ProductType GetProductType(int id)
        {
            return ProductTypeRepository.GetProductType(id);
        }

        public static bool DeleteProductType(int id)
        {
            if(ProductTypeRepository.GetProductType(id) !=null)
            {
                ProductTypeRepository.DeleteProductType(id);
                return true;
            }
            return false;
        }

        public static bool InsertProductType(string name, string desc)
        {
            ProductTypeRepository.insertProductType(name, desc);
            return true;
        }

        public static bool UpdateProductType(int id, string name, string desc)
        {
            ProductTypeRepository.UpdateProductType(id, name, desc);
            return true;
        }
    }
}