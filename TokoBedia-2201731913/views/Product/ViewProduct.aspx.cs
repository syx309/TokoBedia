using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Handler;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.views
{
    public partial class ViewProduct : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateData();

            if (Session["id"] != null)
            {
                string id = Session["id"].ToString();
                LinkButton1.Visible = false;

                //Debug.Print(id);
                if (UserHandler.IsAdmin(id))
                {
                    insertBtn.Visible = true;
                    tableProduct.Columns[0].Visible = true;
                    tableProduct.Columns[1].Visible = true;
                    tableProduct.Columns[2].Visible = false;
                }
                else
                {
                    notAdmin(0);
                }
            }else
            {
                notAdmin(1);
            }
        }

        public void notAdmin(int flag)
        {
            if (flag == 0)
            {
                insertBtn.Visible = false;
                tableProduct.Columns[0].Visible = false;
                tableProduct.Columns[1].Visible = false;
                tableProduct.Columns[2].Visible = true;
            }
            else if(flag==1)
            {
                insertBtn.Visible = false;
                tableProduct.Columns[0].Visible = false;
                tableProduct.Columns[1].Visible = false;
                tableProduct.Columns[2].Visible = false;
                LinkButton1.Visible = true;
            }
            
        }

        public void PopulateData()
        {
            tableProduct.DataSource = ProductHandler.GetProducts();
            tableProduct.DataBind();
        }

        protected void tableProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            string productId = tableProduct.Rows[index].Cells[3].Text;
            Response.Redirect("~/views/Product/UpdateProduct.aspx?productId=" + productId);
        }

        protected void tableProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            string productId = tableProduct.Rows[index].Cells[3].Text;

            int id = Int32.Parse(productId);
            ProductHandler.DeleteProduct(id);
            Response.Redirect(Request.RawUrl);
        }

        protected void tableProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Other")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string productId = tableProduct.Rows[index].Cells[3].Text;
                Response.Redirect("~/views/Cart/AddCart.aspx?productId=" + productId);
            }
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProduct.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/views/Login.aspx");
        }

    }
}