using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceHost;

namespace PD.API.Services.Helpers
{
    class XmlSerializationHelper
    {
        public static string RequestToXml(IHttpRequest req, IHttpResponse res, object requestDto)
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("AbsoluteURI: \"{0}\"\n", req.AbsoluteUri));
            sb.Append(string.Format("RemoteIP: \"{0}\"\n", req.RemoteIp));
            //sb.Append(XmlSerializationHelper.PocoToXml(req));
            //sb.Append(XmlSerializationHelper.PocoToXml(res));
            sb.Append(XmlSerializationHelper.PocoToXml(requestDto));
            return (sb.ToString());
        }

        public static string PocoToXml(object obj)
        {
            return (ServiceStack.Text.JsonSerializer.SerializeToString(obj));
        }
    }
}
