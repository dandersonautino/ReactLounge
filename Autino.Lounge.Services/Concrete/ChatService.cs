using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Exceptions;
using Autino.Lounge.Services.Interfaces;
using AutinoConnect.Shared.Connectivity.Interfaces;
using AutinoConnect.Shared.Model;
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
        public async Task SendChat(string authCode,string message)
        {
            var authModel = Authenticate(authCode);
         //TODO chage the put endpoitn so it works with client chat
            ChatMessageModel chatMessageModel = new ChatMessageModel()
            {
                JobRef = authModel.JobRef.Value,
                Message = message,
                MessageTypeId = (int)ChatMessageType.Clientchat,
                User =  new GarageUserModel()
                {
                    FirstName = "a",
                    LastName = "Other",
                    Email = "dave@dave.com"
                }
            };
            var client = await GetClient("api/v1/GarageChat/");
            try
            {
                await client.WithJsonContent<ChatMessageModel>(chatMessageModel)
                    .AddCustomHeader("X-BAYCONNECT-GARAGEREF", authModel.GarageRef.ToString())
                    .PutAsyncAndGetResponse<ChatPutResponseModel>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
            



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
