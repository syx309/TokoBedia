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
    public partial class UpdateProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["productTypeId"] != null)
                {
                    int productTypeId = Int32.Parse(Request.QueryString["productTypeId"]);

                    SetLabelText(productTypeId);
                    idTxt.Text = productTypeId.ToString();
                }
                else
                {
                    Response.Redirect("~views/ProductType/ViewProductType.aspx");
                }
            }
        }

        private void SetLabelText(int productTypeId)
        {
            ProductType pt = ProductTypeHandler.GetProductType(productTypeId);
            prodName.Text = pt.Name;
            prodDesc.Text = pt.Description;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(idTxt.Text);
            Response response = ProductTypeController.UpdateProductType(id, nameTxt.Text, descTxt.Text);
            
            if(response.successStatus == true)
            {
                Response.Write("<script>alert('Product Type Updated successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        
        }
    }
}