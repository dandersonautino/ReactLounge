using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutinoConnect.Shared.Model.Chat;

namespace Autino.Lounge.Services.Interfaces
{
    public interface IChatService
    {
        //bool DoesJobIdBelongToUserId(int userId, string jobId);
        //  ChatIndexViewModel GetChatIndexViewModel(Guid jobId, User user);
        Task<ChatHistoryResponseModel>  GetChatHistory(string authCode);
       // ShouldShowChatWindow ShouldShowChat(string jobId);
        //void SendChat(string authCode, int userId, string message);
        //bool SendLoungeInvite(string authCode, int userId);
        //bool IsJobSynchedToAutinoConnect(string jobId);
    }
}
