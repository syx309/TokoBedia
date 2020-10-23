using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Handler;

namespace TokoBedia_2201731913.views
{
    public partial class Homeaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["id"] == null)
            {
                isGuest();
            }else
            {
                userID.Text = Session["id"].ToString();
                string id = Session["id"].ToString();
                if (UserHandler.IsAdmin(id))
                {
                    Label1.Text = "Admin";
                    viewUserBtn.Visible = true;
                    viewPTBtn.Visible = true;
                    viewCartBtn.Visible = false;
                    viewTransactionHistoryBtn.Visible = true;
                    tableProduct.Columns[0].Visible = false;
                }
                else
                {
                    isMember();
                }

                loginBtn.Visible = false;
                logoutBtn.Visible = true;
            }

            if (Page.IsPostBack == false)
            {
                PopulateData();
            }

        }
        public void PopulateData()
        {

            tableProduct.DataSource = ProductHandler.GetRandomProducts();
            tableProduct.DataBind();
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Product/ViewProduct.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Users/Profile.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Response.Cookies["email"].Expires = DateTime.Now.AddHours(-1);
            Response.Cookies["password"].Expires = DateTime.Now.AddHours(-1);
            Response.Redirect("Login.aspx");
        }

        protected void viewUserBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Users/ViewUser.aspx");
        }

        protected void insertProdBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Product/InsertProduct.aspx");
        }

        protected void updateProdBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Product/ViewProduct.aspx");
        }

        protected void viewPTBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ProductType/ViewProductType.aspx");
        }

        protected void insertPTBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ProductType/InsertProductType.aspx");
        }

        protected void updatePTBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ProductType/ViewProductType.aspx");
        }

        protected void viewPayTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/PaymentType/ViewPaymentType.aspx");
        }

        protected void InsertPayTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/PaymentType/InsertPaymentType.aspx");
        }

        protected void UpdatePayTypeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/PaymentType/ViewPaymentType.aspx");
        }

        protected void viewCartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Cart/ViewCart.aspx");
        }

        protected void viewTransactionHistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ViewTransactionHistory.aspx");
        }

        protected void viewTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/ViewTransactionReport.aspx");
        }

        public void isGuest()
        {
            Label1.Text = "Guest";
            LinkButton2.Visible = false;
            logoutBtn.Visible = false;
            viewUserBtn.Visible = false;
            viewPTBtn.Visible = false;
            insertProdBtn.Visible = false;
            insertPTBtn.Visible = false;
            viewCartBtn.Visible = false;
            viewTransactionHistoryBtn.Visible = false;
            UpdateProdBtn.Visible = false;
            viewPayTypeBtn.Visible = false;
            InsertPayTypeBtn.Visible = false;
            UpdatePayTypeBtn.Visible = false;
            viewTransactionReport.Visible = false;
            viewCartBtn.Visible = false;
            updatePTBtn.Visible = false;
            tableProduct.Columns[0].Visible = false;
        }

        public void isMember()
        {
            Label1.Text = "Member";
            viewUserBtn.Visible = false;
            viewPTBtn.Visible = false;
            insertProdBtn.Visible = false;
            insertPTBtn.Visible = false;
            UpdateProdBtn.Visible = false;
            viewPayTypeBtn.Visible = false;
            InsertPayTypeBtn.Visible = false;
            UpdatePayTypeBtn.Visible = false;
            viewTransactionReport.Visible = false;
            viewCartBtn.Visible = true;
            viewTransactionHistoryBtn.Visible = true;
            updatePTBtn.Visible = false;
            tableProduct.Columns[0].Visible = true;
        }

        protected void tableProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Other")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string productId = tableProduct.Rows[index].Cells[1].Text;
                Response.Redirect("~/views/Cart/AddCart.aspx?productId=" + productId);
            }
        }

    }
}