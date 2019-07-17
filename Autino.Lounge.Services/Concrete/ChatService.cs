using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Exceptions;
using Autino.Lounge.Services.Interfaces;
using AutinoConnect.Shared.Connectivity.Interfaces;
using AutinoConnect.Shared.Model.Chat;
using AutinoConnect.Utility.Interfaces;

namespace Autino.Lounge.Services.Concrete
{
    public class ChatService : ApiServiceBase,IChatService
    {
        public async  Task<ChatHistoryResponseModel> GetChatHistory(string authCode)
        {   ///TODO This is not secure need to validate this code against the intial token that access this functionlity - intridcue some sort of user object.
            /// like lounge
            var authDataModel = Authenticate(authCode);

            ChatHistoryRequestModel request = new ChatHistoryRequestModel()
            {
                JobRef = authDataModel.JobRef.Value,
               
            };
           
            var client = await GetClient($"api/v1/GarageChat/History/");
            var response = await client.WithJsonContent<ChatHistoryRequestModel>(request)
                .AddCustomHeader("X-BAYCONNECT-GARAGEREF", authDataModel.GarageRef.ToString())
                .PostAsyncAndGetResponse<ChatHistoryResponseModel>();
            return response;

        }
        private ChatAuthenticationModel Authenticate(string authCode)
        {
            ChatAuthenticationModel authDataModel;
            try
            {
                authDataModel = _modelToQueryStringService.Deserialize<ChatAuthenticationModel>(authCode);
            }
            catch (Exception e)
            {
                throw new ChatException("Unable to deserialize model : " + e.Message, e);
            }

            if (!authDataModel.JobRef.HasValue)
            {
                throw new ChatException("Job ref was null");
            }

            if (!authDataModel.GarageRef.HasValue)
            {
                throw new ChatException("GarageRef ref was null");
            }

            var remId = authDataModel.JobRef.Value.ToString();


            return authDataModel;
        }
        public ChatService(IWebApiClientManager webApiClientManager, IIdentityTokenService identityTokenService, IConfigurationService configurationService, IModelToQueryStringService modelToQueryStringService) : base(webApiClientManager, identityTokenService, configurationService)
        {
            
         
            _modelToQueryStringService = modelToQueryStringService;
          
        }
        
        private IModelToQueryStringService _modelToQueryStringService;
    }
}
