using System;
using AutinoConnect.Utility.Interfaces;
using Newtonsoft.Json;

namespace AutinoConnect.Utility.Concrete
{

        public class ModelToQueryStringService : IModelToQueryStringService
        {
            public T Deserialize<T>(string input) where T : class
            {
                string unzipped = ZipUtility.Unzip(Convert.FromBase64String(input));
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(SimpleEncrypt.DecryptString(unzipped,
                    SimpleEncrypt.GENERIC_PASSWORD));
            }
            public string Serialize<T>(T input) where T : class
            {
                var jsonModel = JsonConvert.SerializeObject(input);

                var encrypted = SimpleEncrypt.EncryptString(jsonModel, SimpleEncrypt.GENERIC_PASSWORD);
                var zipped = Convert.ToBase64String(ZipUtility.Zip(encrypted));
                return zipped;
            }

        }
    
}
