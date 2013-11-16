﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Configuration;

namespace PD.API.Services.Helpers
{
    public class SiteConfig
    {
        public string OAuthURL { get; private set; }
        public string AppID { get; private set; }
        public string SodaHost { get; set; }
        public string SodaDataSet { get; private set; }
        public string ServiceRequestDataSet { get; private set; }

        public SiteConfig(IResourceManager resources)
        {
            OAuthURL = resources.GetString("OAuthURL");
            if (OAuthURL == null)
            {
                ThrowConfigException("OAuthURL");
            }

            AppID = resources.GetString("AppID");
            if (AppID == null)
            {
                ThrowConfigException("AppID");
            }
            SodaHost = resources.GetString("SodaHost");
            if (AppID == null)
            {
                ThrowConfigException("SodaHost");
            }

            SodaDataSet = resources.GetString("SodaDataSet");
            if (AppID == null)
            {
                ThrowConfigException("SodaDataSet");
            }

            ServiceRequestDataSet = resources.GetString("ServiceRequestDataSet");
            if (AppID == null)
            {
                ThrowConfigException("ServiceRequestDataSet");
            }

        }

        private void ThrowConfigException(string configValue)
        {
            throw new ConfigurationErrorsException("'" + configValue + "' web config entry is not found.");
        }
    }
}
