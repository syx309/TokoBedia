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
    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                Response.Redirect("Homeaspx.aspx");
            }
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string name = nameTxt.Text;
            string password = passwordTxt.Text;
            string confirmationPassword = confirmPasswordTxt.Text;
            string gender = genderBtn.Text;

            Response response = UserController.DoRegister(email, name, password, confirmationPassword, gender, 2);
   
            if (response.successStatus == true)
            {
                Response.Redirect("~/views/Login.aspx");
            }else
            {
                lblError.Text = response.message;
            }
        }

        protected void loginLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}