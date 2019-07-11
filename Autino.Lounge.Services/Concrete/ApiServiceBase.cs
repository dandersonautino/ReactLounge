using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutinoConnect.Shared.Connectivity.Interfaces;
using AutinoConnect.Shared.Model;

namespace Autino.Lounge.Services.Concrete
{
    public abstract  class ApiServiceBase
    {
        protected async Task<IWebApiClientManagerCreatedWithSecurity> GetClient(string path)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string apiUrl = _configurationService.Get("AutinoConnectIntegrationApiRoot");


            var identityAuthorization = await _identityTokenService.GetToken<AuthorizationModel>();

            return _bayconnectApiClientManager.CreateNew(apiUrl, path)
                .WithBearerAuthorization(identityAuthorization.AccessToken);

        }
        public ApiServiceBase(IWebApiClientManager bayconnectApiClientManager,  IIdentityTokenService identityTokenService, IConfigurationService configurationService)
        {
            _bayconnectApiClientManager = bayconnectApiClientManager;        
            _identityTokenService = identityTokenService;
            _configurationService = configurationService;

        }
        private readonly IWebApiClientManager _bayconnectApiClientManager;
        private readonly IConfigurationService _configurationService;
        private readonly IIdentityTokenService _identityTokenService;
    }
}
