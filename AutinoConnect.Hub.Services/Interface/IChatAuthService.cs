using System;
using System.Collections.Generic;
using System.Text;
using AutinoConnect.Shared.Model.Chat;

namespace AutinoConnect.Hub.Services.Interface
{
    public interface IChatAuthService
    {
        ChatAuthenticationModel GetAuthModelAndValidateData(string authKey, int enquiryPartner);
        ChatAuthenticationModel GetAuthModel(string authKey);
    }
}
