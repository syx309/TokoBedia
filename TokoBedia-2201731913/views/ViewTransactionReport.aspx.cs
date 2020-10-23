using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBedia_2201731913.Reporting;
using TokoBedia_2201731913.Repositories;

namespace TokoBedia_2201731913.views
{
    public partial class ViewTransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TransactionReport report = new TransactionReport();
            CrystalReportViewer.ReportSource = report;

            report.SetDataSource(ReportRepository.GetReportData());
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homeaspx.aspx");
        }
    }
}