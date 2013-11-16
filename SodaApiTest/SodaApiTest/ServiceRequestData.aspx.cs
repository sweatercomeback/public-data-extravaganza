using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SodaApiTest.Application;

namespace SodaApiTest
{
    public partial class ServiceRequestData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var noAuthClient = new Soda2Client(null, null, null);
            var host = ConfigurationManager.AppSettings["socrata.host"];
            var datasetId = ConfigurationManager.AppSettings["socrata.servicerequest.dataset"];
            var dataset = noAuthClient.getDatasetInfo<Row>(host, datasetId);

            Column[] columns = dataset.columns;
            var dataList = dataset.query("select *");
            var models = new List<ServiceRequestModel>();

            foreach (var data in dataList)
            {
                var model = new ServiceRequestModel();

                foreach (var column in columns)
                {

                    model.Address += (column.fieldName.ToUpper().Contains("ADDRESS1")) ? (data[column.fieldName].ToString()+ " ") : string.Empty;
                   // model.Address += (column.fieldName.ToUpper().Contains("ADDRESS2")) ? (data[column.fieldName].ToString()+ "22 ") : string.Empty;

                    if (column.fieldName.ToUpper().Contains("ADDRESS2"))
                    {
                        if (data.Keys.Contains(column.fieldName))
                        {
                            model.Address += (data[column.fieldName].ToString() + "22 ");
                        }
                        //Response.Write("Key Name:" + column.fieldName + " \t LENGTH:" + column.fieldName.Length + ":" + data[column.fieldName] + "<br/>");
                    }
                    if (column.fieldName.ToUpper().Contains("SERVNO"))
                    {
                        model.ServNo = data[column.fieldName].ToString();
                    }

                    if (column.fieldName.ToUpper().Contains("REQUESTDATE"))
                    {
                        var requestDateTime = DateTime.MinValue;
                        model.RequestDate = Convert.ToDateTime(data[column.fieldName]);
                    }

                    if (column.fieldName.ToUpper().Contains("PROBCODE"))
                    {
                        model.ProbCode = data[column.fieldName].ToString();
                    }

                    if (column.fieldName.ToUpper().Contains("PROBDESC"))
                    {
                        model.ProbDesc = data[column.fieldName].ToString();
                    }

                    if (column.fieldName.ToUpper().Contains("GPSX"))
                    {
                        //float longitude = 0;
                        //model.GPSX = (float.TryParse(data[column.fieldName].ToString(), out longitude)) ? longitude : 0;
                        model.GPSX = (data[column.fieldName].ToString());
                    }

                    if (column.fieldName.ToUpper().Contains("GPSY"))
                    {
                        //float longitude = 0;
                        //model.GPSY = (float.TryParse(data[column.fieldName].ToString())) ? longitude : 0;
                        model.GPSY = (data[column.fieldName].ToString());
                    }
                }
                Response.Write("ServiceNumber:" + model.ServNo + "<BR/>");
                Response.Write("RequestDate:" + model.RequestDate + "<BR/>");
                Response.Write("ProblemCode:" + model.ProbCode + "<BR/>");
                Response.Write("ProblemDescription:" + model.ProbDesc + "<BR/>");
                Response.Write("Address:" + model.Address + "<BR/>");
                Response.Write("GPSX:" + model.GPSX + "<BR/>");
                Response.Write("GPSY:" + model.GPSY + "<BR/>");
                models.Add(model);

            }

            Response.Write("Total Count:" + models.Capacity);
        }
    }
}