using CAD.CD.Search.TestFramework.Config;
using CAD.CD.Search.TestFramework.Utils;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Linq;

namespace CAD.CD.Search.TestFramework.Api
{
    class SavedSearchApi : CoreApi
    {
        private string CurrentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];
        public string UrlApiSearch => ConfigLoader.LoadJson("testConfig")[CurrentEnvironment]["Search_Web"]["URL"];

        public IRestResponse CreateSavedSearch()
        {
            var client = new RestClient(UrlApiSearch + "saved-searches/open-search");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject savedSearchBody = SearchGenerator.GenerateJson();

            request.AddParameter("application/json", savedSearchBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public IRestResponse CreateSavedSearchWithName(string searchName)
        {
            var client = new RestClient(UrlApiSearch + "saved-searches/open-search");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject savedSearchBody = SearchGenerator.GenerateJsonWithName(searchName);

            request.AddParameter("application/json", savedSearchBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public IRestResponse CreateSavedSearchWithNameAndFilter(string searchName)
        {
            var client = new RestClient(UrlApiSearch + "saved-searches/open-search");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject savedSearchBody = SearchGenerator.GenerateJsonWithNameAndFilter(searchName);

            request.AddParameter("application/json", savedSearchBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public string GetIdOfCreatedSavedSearch(IRestResponse response)
        {
            var jObjectResponse = JObject.Parse(response.Content);
            return jObjectResponse.GetValue("id").ToString();
        }

        public IRestResponse GetSavedSearches()
        {
            var client = new RestClient(UrlApiSearch + "saved-searches?skip=0&take=1000");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            IRestResponse response = client.Execute(request);

            return response;
        }

        private string GetIdOfCreatedSavedSearchByName(IRestResponse response, string name)
        {           
            var jArrayResponse = JArray.Parse(response.Content);
            JObject items = jArrayResponse.Values<JObject>().Where(i => i["name"].Value<string>() == name).FirstOrDefault();
            return items.GetValue("id").ToString();
        }

        public void DeleteSavedSearch(string id)
        {
            var client = new RestClient(UrlApiSearch + "saved-searches/" + $"id/{id}");
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            IRestResponse response = client.Execute(request);
        }

        public void DeleteSavedSearchByName(string name)
        {
            DeleteSavedSearch(GetIdOfCreatedSavedSearchByName(GetSavedSearches(), name));
        }
    }
}
