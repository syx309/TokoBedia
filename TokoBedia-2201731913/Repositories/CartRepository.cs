using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.Factories;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.Repositories
{
    public class CartRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static List<DetailedCart> GetCarts(int userId)
        {
            return (from Cart
                    in db.Carts
                    join Product in db.Products on Cart.ProductId equals Product.Id
                    where Cart.UserId == userId
                    select new DetailedCart(){
                        ProductId = Cart.ProductId,
                        ProductName = Product.Name,
                        ProductPrice=Product.Price,
                        Quantity = Cart.Quantity,
                        Subtotal = Cart.Quantity * Product.Price}).ToList();
        }

        public static Cart GetCart(int userId,int productId)
        {
            return (from Cart
                   in db.Carts
                    where Cart.UserId == userId && Cart.ProductId == productId
                    select Cart).FirstOrDefault();
        }

        public static Cart InsertCart(int userId, int productId, int quantity)
        {
            Cart c = CartFactory.InsertCart(userId,productId,quantity);
            db.Carts.Add(c);
            db.SaveChanges();

            return c;
        }

        public static Cart UpdateCart(int userId, int productId, int quantity)
        {
            Cart c = GetCart(userId, productId);
            c.Quantity = quantity;
            db.SaveChanges();

            return c;
        }

        public static Cart DeleteCart(int userId, int productId)
        {
            Cart c = GetCart(userId,productId);
            if (c != null)
            {
                db.Carts.Remove(c);
                db.SaveChanges();
            }
            return c;
        }

        
        public static int getCartTotal(int userId)
        {
            if(GetCarts(userId) == null)
            {
                return (from Cart
                    in db.Carts
                        join Product in db.Products on Cart.ProductId equals Product.Id
                        where Cart.UserId == userId
                        select new DetailedCart()
                        {
                            Subtotal = Cart.Quantity * Product.Price
                        }.Subtotal).Sum();
            }else
            {
                return 0;
            }
            
        }
    }
}