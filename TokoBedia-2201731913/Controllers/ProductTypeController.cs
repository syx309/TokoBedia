using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.Controllers
{
    public class ProductTypeController
    {
        public static Response InsertProductType(string name, string desc)
        {
            if (name == "" || name.Length < 5)
            {
                return new Response(false, "Please insert the name and a minimum of 5 character");
            }
            if (ProductTypeRepository.isUnique(name) == false)
            {
                return new Response(false, "Product Type Must Be Unique");
            }
            if (desc == "")
            {
                return new Response(false, "Please insert the description");
            }

            return new Response(ProductTypeHandler.InsertProductType(name, desc), "Product Type has been inserted");
        }

        public static Response UpdateProductType(int id, string name, string desc)
        {
            if (name == "" || name.Length < 5)
            {
                return new Response(false, "Please insert the name and a minimum of 5 character");
            }
            if (ProductTypeRepository.isUnique(name) == false)
            {
                return new Response(false, "Product Type Must Be Unique");
            }
            if (desc == "")
            {
                return new Response(false, "Please insert the description");
            }

            return new Response(ProductTypeHandler.UpdateProductType(id, name, desc), "Product Type has been inserted");
        }
    }
}