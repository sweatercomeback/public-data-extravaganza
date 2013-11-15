using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PD.API.Services.Helpers;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace PD.API.Services.Filters
{
    public class RecordRequestFilter : RequestFilterAttribute
    {
        public RecordRequestFilter(string applicationName)
        {
            _logHelper = new LogHelper(applicationName);
        }

        private readonly LogHelper _logHelper;

        public override void Execute(IHttpRequest req, IHttpResponse res, object requestDto)
        {
            string data;
            try
            {
                data = requestDto != null ? XmlSerializationHelper.RequestToXml(req, res, requestDto) : "NULL";
            }
            catch
            {
                data = "EXCEPTION ON TRANSLATION";
            }

            _logHelper.LogInfo(this, "Request Received", data);
        }
    }

    public class RecordResponseFilter : ResponseFilterAttribute
    {
        public RecordResponseFilter(string applicationName)
        {
            _logHelper = new LogHelper(applicationName);
        }

        private readonly LogHelper _logHelper;

        public override void Execute(IHttpRequest req, IHttpResponse res, object responseDto)
        {
            string data;
            try
            {
                data = responseDto != null ? XmlSerializationHelper.RequestToXml(req, res, responseDto) : "NULL";
            }
            catch
            {
                data = "EXCEPTION ON TRANSLATION";
            }
            _logHelper.LogInfo(this, "Response For Request", data);
        }
    }
}
