using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.models;

namespace TokoBedia_2201731913.views.Users
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Session["id"] != null)
                {
                    int id = Int32.Parse(Session["id"].ToString());
                    User u = UserHandler.GetUser(id);

                    emailLabel.Text = u.Email;
                    nameLabel.Text = u.Name;
                    genderLabel.Text = u.Gender;
                }
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Users/UpdateProfile.aspx");
        }

        protected void changePass_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Users/ChangePassword.aspx");
        }
    }
}