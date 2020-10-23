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
    public partial class ViewCart : System.Web.UI.Page
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

            PopulateData();
            tablePaymentType.Visible = false;
            Label2.Visible = false;
            PaymentTypeId.Visible = false;
        }

        public void PopulateData()
        {
            int id = Int32.Parse(Session["id"].ToString());
            tableCart.DataSource = CartHandler.GetCarts(id);
            tableCart.DataBind();

            if(tableCart.DataSource != null)
            {
                grandTotalTxt.Text = CartHandler.GetGrandTotal(id).ToString();
            }else
            {
                grandTotalTxt.Text = "0";
            }
            
        }

        protected void tableProductType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            string productId = tableCart.Rows[index].Cells[2].Text;
            Response.Redirect("~/views/Cart/UpdateCart.aspx?productId=" + productId);
        }

        protected void tableProductType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            int userId = Int32.Parse(Session["id"].ToString());
            string productId = tableCart.Rows[index].Cells[2].Text;

            int id = Int32.Parse(productId);
            CartHandler.DeleteCart(userId, id);
            Response.Redirect(Request.RawUrl);
        }

        protected void CheckoutBtn(object sender, EventArgs e)
        {
            populatePaymentTable();
            tablePaymentType.Visible = true;
            Label2.Visible = true;
            PaymentTypeId.Visible = true;

            string paymentTypeId = PaymentTypeId.Text;
            int userId = Int32.Parse(Session["id"].ToString());

            Response response = CartController.CheckOut(CartHandler.GetCarts(userId), paymentTypeId, userId);
            
            if(response.successStatus == true)
            {
                Response.Redirect("~/views/Homeaspx.aspx");
            }else
            {
                lblErrortxt.Text = response.message;
            }
        }

        protected void populatePaymentTable()
        {
            tablePaymentType.DataSource = PaymentTypeHandler.GetPaymentTypes();
            tablePaymentType.DataBind();
        }
    }
}