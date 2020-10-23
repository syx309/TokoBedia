using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Controllers;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.views
{
    public partial class AddCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (UserHandler.IsAdmin(Session["id"].ToString()) == true)
                {
                    Response.Redirect("~/views/Homeaspx.aspx");
                }

                if (Request.QueryString["productId"] != null)
                {
                    int productId = Int32.Parse(Request.QueryString["productId"]);

                    SetLabelText(productId);
                }
                else
                {
                    Response.Redirect("~/Product/ViewProduct.aspx");
                }
            }
        }

        private void SetLabelText(int productId)
        {
            Product p = ProductHandler.GetProduct(productId);
            nameLabel.Text = p.Name;
            stockLabel.Text = p.Stock.ToString();
            priceLabel.Text = p.Price.ToString();
        }

        protected void AddCartBtn_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Session["id"].ToString());
            int productId = Int32.Parse(Request.QueryString["productId"]);

            Response response = CartController.InsertCart(userId, productId, quantityTxt.Text);

            if(response.successStatus == true)
            {
                //Response.Write("<script>alert('Product updated successfully')</script>");
                //Response.Redirect(Request.RawUrl);
                Response.Redirect("~/views/Cart/ViewCart.aspx");
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}