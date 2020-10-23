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
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (UserHandler.IsAdmin(Session["id"].ToString()) == true)
            {
                Response.Redirect("~/views/Homeaspx.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["productId"] != null)
                {
                    int productId = Int32.Parse(Request.QueryString["productId"]);

                    SetLabelText(productId);
                }
                else
                {
                    Response.Redirect("~/views/Cart/ViewCart.aspx");
                }
            }
        }

        private void SetLabelText(int productId)
        {
            Product p = ProductHandler.GetProduct(productId);
            Cart c = CartHandler.GetCart(Int32.Parse(Session["id"].ToString()), productId);
            prodName.Text = p.Name;
            prodPrice.Text = p.Price.ToString();
            prodStock.Text = p.Stock.ToString();
            quantityTxt.Text = c.Quantity.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(Session["id"].ToString());
            int productId = Int32.Parse(Request.QueryString["productId"]);
            Response response = CartController.UpdateCart(userId, productId, quantityTxt.Text);

            if(response.successStatus == true)
            {
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}