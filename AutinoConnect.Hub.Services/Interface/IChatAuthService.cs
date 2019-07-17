using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutinoConnect.Shared.Model.Chat;

namespace AutinoConnect.Hub.Services.Interface
{
    public interface IChatAuthService
    {
        Task<ChatAuthenticationModel> GetAuthModelAndValidateData(string authKey, int enquiryPartner);
        ChatAuthenticationModel GetAuthModel(string authKey);
    }
}
