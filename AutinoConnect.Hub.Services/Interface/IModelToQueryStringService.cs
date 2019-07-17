using System;
using System.Collections.Generic;
using System.Text;

namespace AutinoConnect.Hub.Services.Interface
{
    public interface IModelToQueryStringService
    {
        T Deserialize<T>(string input) where T : class;

        string Serialize<T>(T input) where T : class;
    }
}
