using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autino.Lounge.Services.Models.Token;

namespace Autino.Lounge.Services.Interfaces
{
    public interface ITokenService
    {
        Task<LoungeTokenResponseModel> ValidateToken(string token);
    }
}
