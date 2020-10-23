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
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (UserHandler.IsAdmin(Session["id"].ToString()) == false)
            {
                Response.Redirect("~/views/Homeaspx.aspx");
            }

            PopulateData();
        }

        public void PopulateData()
        {
            tablePaymentType.DataSource = PaymentTypeHandler.GetPaymentTypes();
            tablePaymentType.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response response = PaymentTypeController.InsertPaymentType(paytypeTxt.Text);

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('PaymentType has been added')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}