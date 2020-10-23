using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Controllers;
using TokoBedia_2201731913.Helpers;

namespace TokoBedia_2201731913.views
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/views/Login.aspx");
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response response = ProfileController.UpdatePassword(Session["id"].ToString(), TextBox1.Text, TextBox2.Text, TextBox3.Text);

            if (response.successStatus == true)
            {
                Response.Write("<script>alert('Password Changed Successfully')</script>");
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblError.Text = response.message;
            }
            
        }
    }
}