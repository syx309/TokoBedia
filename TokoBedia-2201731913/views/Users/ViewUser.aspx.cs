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
    public partial class ViewUser : System.Web.UI.Page
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

            Label1.Visible = false;
            blockTxt.Visible = false;
            Label2.Visible = false;
            unblockTxt.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
            Label3.Visible = false;
            Button3.Visible = false;
            changeRoleTxt.Visible = false;
        }

        public void PopulateData()
        {
            tableUser.DataSource = UserHandler.GetUsers();
            tableUser.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response response = UserController.BlockUser(blockTxt.Text, Session["id"].ToString());

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('User Blocked successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response response = UserController.UnblockUser(unblockTxt.Text, Session["id"].ToString());

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('User unBlocked successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response response = UserController.ChangeRole(changeRoleTxt.Text, Session["id"].ToString());

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('User unBlocked successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            blockTxt.Visible = true;
            Button1.Visible = true;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label2.Visible = true;
            unblockTxt.Visible = true;
            Button2.Visible = true;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            changeRoleTxt.Visible = true;
            Button3.Visible = true;
        }

    }
}