using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Interfaces;
using Autino.Lounge.Services.Models.Token;
using AutinoConnect.Shared.Connectivity.Interfaces;

namespace Autino.Lounge.Services.Concrete
{
   public  class TokenService : ApiServiceBase , ITokenService
    {
        public  async Task<LoungeTokenResponseModel>  ValidateToken(string token)
        {
            var client = await GetClient($"api/lounge/tokenverification?token={token}");
            var response = await client
                .GetAsyncAndGetResponse<LoungeTokenResponseModel>();
            return response;
        }
        public TokenService(IWebApiClientManager webApiClientManager, IIdentityTokenService identityTokenService, IConfigurationService configurationService) : base(webApiClientManager, identityTokenService, configurationService)
        {

        }
    }
}
