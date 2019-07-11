using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutinoConnect.Shared.Connectivity.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace reactlounge.Services
{
    public class ConfigurationService : IConfigurationService
    {


        public string Get(string key)
        {
            return _configurationRoot[key];
        }
        public ConfigurationService(IHostingEnvironment env)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        }
        private IConfigurationRoot _configurationRoot;


    }
}
