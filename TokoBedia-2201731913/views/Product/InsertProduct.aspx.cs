using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Controllers;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Helpers;

namespace TokoBedia_2201731913.views
{
    public partial class insertProduct : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (UserHandler.IsAdmin(Session["id"].ToString()) == false)
            {
                Response.Redirect("Homeaspx.aspx");

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string name = productNameTxt.Text;
            Response response = ProductController.InsertProduct(productNameTxt.Text, stockPriceTXT.Text, productPriceTxt.Text);

            if(response.successStatus == true)
            {
                Response.Write("<script>alert('Product Inserted Successfully')</script>");
                //Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}