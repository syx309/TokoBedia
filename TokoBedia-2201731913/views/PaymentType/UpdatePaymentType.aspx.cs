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
    public partial class UpdatePaymentType : System.Web.UI.Page
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

            if (Page.IsPostBack == false)
            {
                if (Request.QueryString["payId"] != null)
                {
                    int payId = Int32.Parse(Request.QueryString["payId"]);
                    PaymentType paytype = PaymentTypeHandler.GetPaymentType(payId);

                    PaymentTypeName.Text = paytype.Type;
                    paytypeTxt.Text = paytype.Type;
                    //payIdTxt.Text = payId.ToString();
                }
                else
                {
                    Response.Redirect("~/PaymentType/ViewPaymentType.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int payId = Int32.Parse(Request.QueryString["payId"]);
            Debug.Print(paytypeTxt.Text);
            Response response = PaymentTypeController.UpdatePaymentType(payId, paytypeTxt.Text);
     
            if (response.successStatus == true)
            {
                Response.Write("<script>alert('Product updated successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}