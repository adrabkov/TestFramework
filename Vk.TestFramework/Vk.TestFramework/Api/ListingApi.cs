using CAD.CD.Search.TestFramework.PageObjects.Utils;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;

namespace CAD.CD.Search.TestFramework.Api
{
    public class ListingApi : CoreApi
    {
        protected List<string> listingIds = new List<string>();
        private Dictionary<string, string> HeadersList = new Dictionary<string, string>();

        public IRestResponse CreateListing()
        {
            var client = new RestClient(UrlApiListing);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject listingBody = ListingGenerator.GenerateListingJson();

            request.AddParameter("application/json", listingBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public IRestResponse CreateListingWithOrigin(string originCity, string originState, string originZip)
        {
            var client = new RestClient(UrlApiListing);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject listingBody = ListingGenerator.GenerateListingJsonWithOrigin(originCity, originState, originZip);

            request.AddParameter("application/json", listingBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public IRestResponse CreateListingWithDestination(string destinationCity, string destinationState, string destinationZip)
        {
            var client = new RestClient(UrlApiListing);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject listingBody = ListingGenerator.GenerateListingJsonWithDestination(destinationCity, destinationState, destinationZip);

            request.AddParameter("application/json", listingBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public IRestResponse CreateListingWithOriginDestination(string originCity, string originState, string originZip,
            string destinationCity, string destinationState, string destinationZip)
        {
            var client = new RestClient(UrlApiListing);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + GetToken());
            request.AddHeader("Accept", "application/json");

            JObject listingBody = ListingGenerator.GenerateListingJsonWithOriginAndDestination(originCity, originState, originZip, 
                destinationCity, destinationState, destinationZip);

            request.AddParameter("application/json", listingBody, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        public void GetIdOfCreatedListing(IRestResponse response)
        {
            HeadersList = new Dictionary<string, string>();

            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersList.Add(KeyPairs[0], KeyPairs[1]);
            }

            string locationHeader = HeadersList["Location"];
            string[] urlLocation = locationHeader.Split('/');

            string listingId = urlLocation[urlLocation.Length-1];            

            listingIds.Add(listingId);
            HeadersList.Clear();
        }

        public void CreateListings(int numberOfListingsToCreate)
        {
            for (int i = 0; i < numberOfListingsToCreate; i++)
            {
                IRestResponse listing = CreateListing();
                GetIdOfCreatedListing(listing);
            }
        }

        public void DeleteListings(List<string> ids)
        {            
            foreach (string id in ids)
            {
                var client = new RestClient(UrlApiListing + $"id/{id}");
                client.Timeout = -1;
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + GetToken());
                IRestResponse response = client.Execute(request);
            }
        }
    }
}
