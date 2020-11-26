using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPal.Api;

namespace GoldConf.Models
{
    //Get configuration from web.config file
    public class PaypalConfigurations
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;
        static PaypalConfigurations()
        {

            var config = GetConfig();
            ClientId = config[""];
            ClientSecret = config[""];
        }
        public static Dictionary<string, string> GetConfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }
        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
            return accessToken;
        }
        //This will return APIContext object
        private static APIContext GetAPIContext()
        {
            var apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}
