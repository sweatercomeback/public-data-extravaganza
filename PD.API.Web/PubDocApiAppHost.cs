using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Funq;
using PD.API.Services;
using PD.API.Services.Helpers;
using ServiceStack.Configuration;
using ServiceStack.OrmLite;
using ServiceStack.WebHost.Endpoints;

namespace PD.API.Web
{
    public class PubDocApiAppHost : AppHostBase
    {
        public PubDocApiAppHost() : base(ConfigService.AppName, typeof(ConfigService).Assembly) { }

        /// <summary>
        /// Configure the container with the necessary routes for your ServiceStack application.
        /// </summary>
        /// <param name="container">The built-in IoC used with ServiceStack.</param>
        public override void Configure(Container container)
        {
            //Permit modern browsers (e.g. Firefox) to allow sending of any REST HTTP Method
            SetConfig(new EndpointHostConfig
            {
                GlobalResponseHeaders =
                    {
                        { "Access-Control-Allow-Origin", "*" },
                        { "Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS" },
                    },
            });

            var config = new SiteConfig(new ConfigurationResourceManager());
            container.Register(config);

            var logger = new LogHelper(ConfigService.AppName);
            container.Register(logger);

            var dbConnectionFactory = new OrmLiteConnectionFactory(ConfigurationManager.ConnectionStrings["MainServer"].ConnectionString, SqlServerDialect.Provider);
            container.Register<IDbConnectionFactory>(dbConnectionFactory);
        }
    }
}