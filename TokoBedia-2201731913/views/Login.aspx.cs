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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id"] != null)
            {
                Response.Redirect("Homeaspx.aspx");
            }

            //init
            if(Page.IsPostBack == false)
            {
                if(Request.Cookies["email"] != null && Request.Cookies["password"] !=null)
                {
                    emailTxt.Text = Request.Cookies["email"].Value;
                    passwordTxt.Text = Request.Cookies["password"].Value;
                }
            }
        }

        protected void loginBtn1_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;

            Response response = LoginController.DoLogin(email, password);

            if (response.successStatus == true)
            {
                if (LoginController.IsBlocked(email,password) == false)
                {
                    //add session
                    Session["email"] = email;
                    Session["id"] = int.Parse(response.message);

                    if (RememberMe.Checked)
                    {
                        Response.Cookies["email"].Value = email;
                        Response.Cookies["email"].Expires = DateTime.Now.AddHours(3);
                        Response.Cookies["password"].Value = password;
                        Response.Cookies["password"].Expires = DateTime.Now.AddHours(3);

                    }

                    Response.Redirect("~/views/Homeaspx.aspx");
                }else
                {
                    Response.Write("<script>alert('You have been blocked by the admin')</script>");
                }
            }
            else
            {
                lblError.Text = response.message;
            }
                
            }

        protected void registerLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Register.aspx");
        }
    }

        
}