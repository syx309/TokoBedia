using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TokoBedia_2201731913.models;
using TokoBedia_2201731913.Reporting;

namespace TokoBedia_2201731913.Repositories
{
    public class ReportRepository
    {
        public static WebsiteEntities db = new WebsiteEntities();

        public static ReportDataSet GetReportData()
        {
            ReportDataSet dataset = new ReportDataSet();

            ReportDataSet.Header_TransactionDataTable HeaderTable = dataset.Header_Transaction;
            ReportDataSet.Detail_TransactionDataTable DetailTable = dataset.Detail_Transaction;

            foreach (HeaderTransaction ht in db.HeaderTransactions)
            {
                DataRow HeaderRow = HeaderTable.NewRow();

                HeaderRow["Transaction ID"] = ht.Id;
                HeaderRow["User Name"] = ht.User.Name;
                HeaderRow["Payment Type"] = ht.PaymentType.Type;
                HeaderRow["Transaction Date"] = ht.Date;

                HeaderTable.Rows.Add(HeaderRow);

                foreach (DetailTransaction dt in ht.DetailTransactions)
                {
                    DataRow DetailRow = DetailTable.NewRow();

                    DetailRow["Product Name"] = dt.Product.Name;
                    DetailRow["Product Price"] = dt.Product.Price;
                    DetailRow["Quantity"] = dt.Quantity;
                    DetailRow["Transaction ID"] = dt.TransactionID;

                    DetailTable.Rows.Add(DetailRow);
                }
            }
            return dataset;
        }
    }
}