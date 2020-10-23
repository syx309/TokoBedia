using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;

namespace TokoBedia_2201731913.Controllers
{
    public class ProductController
    {
        public static Response InsertProduct(string name, string stock, string price)
        {
            if (name == "")
            {
                return new Response(false, "Fill product name");
            }
            if (stock == "" || stock.All(char.IsDigit) !=true)
            {
                return new Response(false, "Fill product stock");
            }
            if (price == "" || price.All(char.IsDigit) != true)
            {
                return new Response(false, "Fill product price");
            }

            int _stock = Int32.Parse(stock);
            int _price = Int32.Parse(price);

            if (_stock < 1)
            {
                return new Response(false, "Please input a minimum of 1 stock");
            }
            if (_price < 1000 || _price % 1000 != 0)
            {
                return new Response(false, "Please input the Price more than a thousand and divisble by a thousand");
            }

            return new Response(ProductHandler.InsertProduct(name, _stock, _price), "Product has been inserted");
        }

        public static Response UpdateProduct(int id, string name, string stock, string price)
        {
            if (name == "")
            {
                return new Response(false, "Fill product name");
            }
            if (stock == "" || stock.All(char.IsDigit) != true)
            {
                return new Response(false, "Fill product stock");
            }
            if (price == "" || price.All(char.IsDigit) != true)
            {
                return new Response(false, "Fill product price");
            }

            int _stock = Int32.Parse(stock);
            int _price = Int32.Parse(price);

            if (_stock < 1)
            {
                return new Response(false, "Please input a minimum of 1 stock");
            }
            if (_price < 1000 || _price % 1000 != 0)
            {
                return new Response(false, "Please input the Price more than a thousand and divisble by a thousand");
            }

            return new Response(ProductHandler.UpdateProduct(id, name, _stock, _price), "Product has been updated");
        }

    }
}