using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class updateProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if(UserHandler.IsAdmin(Session["id"].ToString()) == false)
            {
                Response.Redirect("~/views/Homeaspx.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["productId"] != null)
                {
                    int productId = Int32.Parse(Request.QueryString["productId"]);

                    SetLabelText(productId);
                    productIDTxt.Text = productId.ToString();
                }
                else
                {
                    Response.Redirect("ViewProduct.aspx");
                }
            }
        }

        private void SetLabelText(int productId)
        {
            Product p = ProductHandler.GetProduct(productId);
            prodName.Text = p.Name;
            prodPrice.Text = p.Price.ToString();
            ProdStock.Text = p.Stock.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(productIDTxt.Text);
            Response response = ProductController.UpdateProduct(id, productNameTxt.Text, stockProductTxt.Text, productPriceTxt.Text);

            if(response.successStatus == true)
            {
                Response.Write("<script>alert('Product updated successfully')</script>");
                //Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
            
        }
    }
}