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
    public partial class InsertProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                if (UserHandler.IsAdmin(Session["id"].ToString()) == false)
                {
                    Response.Redirect("~/views/Homeaspx.aspx");
                }
            }
            else
            {
                Response.Redirect("~/views/Login.aspx");
            }

            PopulateData();
        }

        public void PopulateData()
        {
            tableProductType.DataSource = ProductTypeHandler.GetProductTypes();
            tableProductType.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response response = ProductTypeController.InsertProductType(productTypeNameTxt.Text, descriptionTxt.Text);

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('Product Type inserted successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}