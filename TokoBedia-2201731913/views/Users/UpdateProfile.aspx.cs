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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }

            if (Page.IsPostBack == false)
            {
                if (Session["id"]!=null)
                {
                    int id = Int32.Parse(Session["id"].ToString());
                    User u = UserHandler.GetUser(id);

                    emailLabel.Text = u.Email;
                    nameLabel.Text = u.Name;
                    genderLabel.Text = u.Gender;

                    emailTxt.Text = u.Email;
                    nameTxt.Text = u.Name;
                    genderBtn.Text = u.Gender;
                }
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response response = ProfileController.UpdateProfile(Session["id"].ToString(), emailTxt.Text, nameTxt.Text, genderBtn.Text);
            
            if(response.successStatus == true)
            {
                Response.Write("<script>alert('Profile Updated Successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
        }
    }
}