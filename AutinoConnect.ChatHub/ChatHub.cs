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
        public async Task Send(string firstname, string surname, string message, string authKey, int type, string localOffset)
        {
            var authModel = await GetAuthModel(authKey);

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


        public void SendToAll(string name, string message)
        {
            Clients.All.SendAsync("sendToAll", name, message);
        }
        public async Task JoinGroup(string authKey)
        {
            var authModel = await GetAuthModel(authKey);
            await Groups.AddToGroupAsync(Context.ConnectionId, authModel.JobRef.ToString());

        }

        private async Task <ChatAuthenticationModel> GetAuthModel(string authKey)
        {
            //assume carvue for now
            return await _chatAuthService.GetAuthModelAndValidateData(authKey, 7);

        }

        public ChatHub( IChatAuthService chatAuthService)
        {
            
            _chatAuthService = chatAuthService;
        }


        private IChatAuthService _chatAuthService;

    }
}
