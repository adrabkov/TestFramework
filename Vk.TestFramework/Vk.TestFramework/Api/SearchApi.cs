using CAD.CD.Search.TestFramework.Config;
using CAD.CD.Search.TestFramework.Utils;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CAD.CD.Search.TestFramework.Api
{
    class SearchApi : CoreApi
    {
        private string CurrentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];
        public string UrlApiSearch => ConfigLoader.LoadJson("testConfig")[CurrentEnvironment]["Search_Web"]["URL"];

        public IRestResponse SearchListingsCityToCity(string originCity, string originState, string originZip,
            string destinationCity, string destinationState, string destinationZip)
        {
            var client = new RestClient(UrlApiSearch + "open-search");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());

            JObject searchBody = SearchGenerator.GenerateSearchJsonCityToCity(originCity, originState, originZip,
                destinationCity, destinationState, destinationZip);

            request.AddParameter("application/json", searchBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}
