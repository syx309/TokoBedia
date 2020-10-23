using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Handler;

namespace TokoBedia_2201731913.views
{
    public partial class ViewProductType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["id"] != null)
            {
                string id = Session["id"].ToString();

                //Debug.Print(id);
                if (UserHandler.IsAdmin(id))
                {
                    insertBtn.Visible = true;
                    tableProductType.Columns[0].Visible = true;
                    tableProductType.Columns[1].Visible = true;
                }else
                {
                    Response.Redirect("~/views/Homeaspx.aspx");
                }
            }
            else
            {
                Response.Redirect("~/views/Login.aspx");
            }

            PopulateData();
        }

        public void PopulateData()
        {
            tableProductType.DataSource = ProductTypeHandler.GetProductTypes();
            tableProductType.DataBind();
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertProductType.aspx");
        }


        protected void tableProductType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int index = e.RowIndex;
            string productTypeId = tableProductType.Rows[index].Cells[2].Text;
            Response.Redirect("UpdateProductType.aspx?productTypeId=" + productTypeId);
        }

        protected void tableProductType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            string productId = tableProductType.Rows[index].Cells[2].Text;

            int id = Int32.Parse(productId);
            ProductTypeHandler.DeleteProductType(id);
            Response.Redirect(Request.RawUrl);
        }
    }
}