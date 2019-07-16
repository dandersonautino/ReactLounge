using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutinoConnect.Shared.Model.Chat;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using AutinoConnect.Hub.Services.Interface;

namespace AutinoConnect.ChatHub
{
    public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public void Send(string firstname, string surname, string message, string authKey, int type, string localOffset)
        {
            var authModel = GetAuthModel(authKey);

            var timeSpan = TimeSpan.Parse(localOffset);

            ChatMessageResponseModel responseModel = new ChatMessageResponseModel()
            {
                Message = message,
                SenderFirstname = firstname,
                SenderSurname = surname,
                MessageTypeId = type,
                MessageDate = DateTime.UtcNow.Add(timeSpan)
            };
            //  Call the broadcastMessage method to update clients.
            Clients.Group(authModel.JobRef.Value.ToString())
                .SendAsync("broadcastMessage",
                    JsonConvert.SerializeObject(responseModel, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings()
                        { ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        }



        public async Task JoinGroup(string authKey)
        {
            var authModel = GetAuthModel(authKey);
            await Groups.AddToGroupAsync(Context.ConnectionId, authModel.JobRef.ToString());

        }

        private ChatAuthenticationModel GetAuthModel(string authKey)
        {
            //assume carvue for now
            return _chatAuthService.GetAuthModelAndValidateData(authKey, 7);

        }

        public ChatHub( IChatAuthService chatAuthService)
        {
            
            _chatAuthService = chatAuthService;
        }


        private IChatAuthService _chatAuthService;

    }
}
