using CAD.CD.Search.TestFramework.Config;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CAD.CD.Search.TestFramework.Api
{
    public class CoreApi
    {
        private string CurrentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];
        public string UrlApiListingToken => ConfigLoader.LoadJson("testConfig")[CurrentEnvironment]["Search_Web"]["URLApiListingToken"];
        public string UrlApiListing => ConfigLoader.LoadJson("testConfig")[CurrentEnvironment]["Search_Web"]["URLApiListing"];
        private string Client_id = ConfigLoader.LoadJson("testCreds")["client_id"];
        private string Client_secret = ConfigLoader.LoadJson("testCreds")["client_secret"];
        private string Grant_type = ConfigLoader.LoadJson("testCreds")["grant_type"];
        private string UserName = ConfigLoader.LoadJson("testCreds")["usernameApiListing"];
        private string Password = ConfigLoader.LoadJson("testCreds")["password"];

        public string GetToken()
        {
            var client = new RestClient(UrlApiListingToken + "connect/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", Client_id);
            request.AddParameter("client_secret", Client_secret);
            request.AddParameter("grant_type", Grant_type);
            request.AddParameter("UserName", UserName);
            request.AddParameter("Password", Password);

            IRestResponse response = client.Execute(request);

            var jObject = JObject.Parse(response.Content);
            string token = jObject.GetValue("access_token").ToString();

            return token;
        }
    }
}
