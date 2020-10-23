using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Controllers;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.views
{
    public partial class ViewTransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("Homeaspx.aspx");
            }
            populateTransactions(Session["id"].ToString());
        }

        protected void populateTransactions(string id)
        {
            if (UserRepository.IsAdmin(id))
            {
                GridTransaction.DataSource = TransactionHandler.getAdminTransactions();
                GridTransaction.DataBind();
            }
            else
            {
                GridTransaction.DataSource = TransactionHandler.getTransactions(id);
                GridTransaction.DataBind();
            }
            
        }

        protected void ReportBTN_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ViewTransactionReport.aspx");
        }
    }
}