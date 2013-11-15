using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SodaApiTest.Application;
using System.Configuration;

namespace SodaApiTest
{
    public partial class ReadData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var noAuthClient = new Soda2Client(null, null, null);
            var host = ConfigurationManager.AppSettings["socrata.host"];
            var datasetId = ConfigurationManager.AppSettings["socrata.sample.dataset"];
            var dataset = noAuthClient.getDatasetInfo<Row>(host, datasetId);

            Column[] columns = dataset.columns;
            foreach (var column in columns)
            {
                Response.Write("Column name:" + column.name + ":" + column.fieldValue + "\t Type:" + column.dataTypeName + "<br/>");
            }
            //var responseA = dataset.query("select * where title = 'The Killer'");
        }
    }
}