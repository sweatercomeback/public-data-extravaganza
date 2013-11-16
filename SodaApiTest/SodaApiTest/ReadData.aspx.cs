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
            var data = dataset.query("select * where county_nam = 'WINNEBAGO'");
            foreach (var column in data)
            {
                Response.Write("County:" + column["county_nam"] + " : " + "Location:" + column["location1"] + " " + column["location2"] + " " + column["location3"] + " " + column["location4"] + " " + column["location5"] + " " + column["location6"] + "<br/>");
                //Response.Write("Column name:" + column.name + ":" + column.fieldValue + "\t Type:" + column.dataTypeName + "<br/>");
            }
            //var responseA = dataset.query("select * where title = 'The Killer'");
        }
    }
}