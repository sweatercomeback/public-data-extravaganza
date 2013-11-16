using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PD.API.SODA
{
    public static class ReadDataFromSoda
    {

        public static List<RoadContructionModel> RoadContructionData(string host, string datasetId)
        {
            var noAuthClient = new Soda2Client(null, null, null);
            //var host = ConfigurationManager.AppSettings["socrata.host"];
            //var datasetId = ConfigurationManager.AppSettings["socrata.sample.dataset"];]
            //var service = new ConfigService();
            //var host = service.Config.SodaHost;
            //var datasetId = service.Config.SodaDataSet;
            var dataset = noAuthClient.getDatasetInfo<Row>(host, datasetId);

            Column[] columns = dataset.columns;
            var dataList = dataset.query("select * where county_nam = 'WINNEBAGO'");
            var models = new List<RoadContructionModel>();

            foreach (var data in dataList)
            {
                var location = string.Empty;
                var model = new RoadContructionModel();

                foreach (var column in columns)
                {
                    //Response.Write("Column name:" + data[column.name] + ":" + column.fieldValue + "\t Type:" + column.dataTypeName + "<br/>");
                    //location+=(column.fieldName.ToUpper().Contains("LOCATION"))?  (data[column.fieldName] +" "):string.Empty;

                    //Response.Write("Column:" + column.name + "\t Data:" + data[column.fieldName] +"<BR/>");
                    model.Location += (column.fieldName.ToUpper().Contains("LOCATION"))
                                          ? (data[column.fieldName] + " ")
                                          : string.Empty;
                    model.Improvement += (column.fieldName.ToUpper().Contains("IMPRVMNT"))
                                             ? (data[column.fieldName] + " ")
                                             : string.Empty;
                    model.Route += (column.fieldName.ToUpper().Contains("ROUTE"))
                                       ? (data[column.fieldName] + "  ")
                                       : string.Empty;


                    if (column.fieldName.ToUpper().Contains("INVENTORY"))
                    {
                        model.Inventory = data[column.fieldName].ToString();
                    }

                    if (column.fieldName.ToUpper().Contains("RECORD"))
                    {
                        model.Record = data[column.fieldName].ToString();
                    }

                    if (column.fieldName.ToUpper().Contains("POINT_X"))
                    {
                        float latitude = 0;

                        model.Latitude = (float.TryParse(data[column.fieldName].ToString(), out latitude))
                                             ? latitude
                                             : 0;
                    }

                    if (column.fieldName.ToUpper().Contains("POINT_Y"))
                    {
                        float longitude = 0;
                        model.Longitude = (float.TryParse(data[column.fieldName].ToString(), out longitude))
                                              ? longitude
                                              : 0;
                    }

                    if (column.fieldName.ToUpper().Contains("COUNTY_NAM"))
                    {
                        model.CountyName = data[column.fieldName].ToString();
                    }
                    model.Description = "<h2>Location</h2>" + model.Location + "<br/>";
                    model.Description += "<h2>Improvement</h2>" + model.Improvement + "<br/>";
                    model.Description += "<h2>Route</h2>" + model.Route + "<br/>";
                }
                //Response.Write("Record:" + model.Record + "<BR/>");
                //Response.Write("Inventory:" + model.Inventory + "<BR/>");
                //Response.Write("Location:" + model.Location + "<BR/>");
                //Response.Write("Improvment:" + model.Improvement + "<BR/>");
                //Response.Write("Latitue:" + model.Latitude.ToString() + "<BR/>");
                //Response.Write("Longitude:" + model.Longitude.ToString() + "<BR/>");
                //Response.Write("Route:" + model.Route + "<BR/>");
                models.Add(model);

            }
            return models;
        }

        public static List<ServiceRequestModel> ServiceRequestData(string host, string datasetId)
        {

            var noAuthClient = new Soda2Client(null, null, null);
            //var host = ConfigurationManager.AppSettings["socrata.host"];
            //var datasetId = ConfigurationManager.AppSettings["socrata.servicerequest.dataset"];
            var dataset = noAuthClient.getDatasetInfo<Row>(host, datasetId);

            Column[] columns = dataset.columns;
            var dataList = dataset.query("select *");
            var models = new List<ServiceRequestModel>();

            foreach (var data in dataList)
            {
                var model = new ServiceRequestModel();

                foreach (var column in columns)
                {

                    model.Address += (column.fieldName.ToUpper().Contains("ADDRESS1"))
                                         ? (data[column.fieldName].ToString() + " ")
                                         : string.Empty;
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
                        float latitude = 0;
                        model.GPSX = (float.TryParse(data[column.fieldName].ToString(), out latitude)) ? latitude : 0;
                        //model.GPSX = (data[column.fieldName].ToString());
                    }

                    if (column.fieldName.ToUpper().Contains("GPSY"))
                    {
                        float longitude = 0;
                        model.GPSY = (float.TryParse(data[column.fieldName].ToString(), out longitude)) ? longitude : 0;
                        //model.GPSY = (data[column.fieldName].ToString());
                    }
                }
                //Response.Write("ServiceNumber:" + model.ServNo + "<BR/>");
                //Response.Write("RequestDate:" + model.RequestDate + "<BR/>");
                //Response.Write("ProblemCode:" + model.ProbCode + "<BR/>");
                //Response.Write("ProblemDescription:" + model.ProbDesc + "<BR/>");
                //Response.Write("Address:" + model.Address + "<BR/>");
                //Response.Write("GPSX:" + model.GPSX + "<BR/>");
                //Response.Write("GPSY:" + model.GPSY + "<BR/>");
                models.Add(model);

            }
            return models;
        }
    }
}

