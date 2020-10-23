using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Handler;

namespace TokoBedia_2201731913.views
{
    public partial class ViewPaymentType : System.Web.UI.Page
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
            Response.Redirect("~/views/PaymentType/InsertPaymentType.aspx");
        }

        protected void tablePaymentType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            string payId = tablePaymentType.Rows[index].Cells[2].Text;
            Response.Redirect("~/views/PaymentType/UpdatePaymentType.aspx?payId=" + payId);
        }

        protected void tablePaymentType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            string payId = tablePaymentType.Rows[index].Cells[2].Text;

            int id = Int32.Parse(payId);
            PaymentTypeHandler.DeletePaymentType(id);
            Response.Redirect(Request.RawUrl);
        }
    }
}