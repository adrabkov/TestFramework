using Newtonsoft.Json.Linq;

namespace CAD.CD.Search.TestFramework.Utils
{
    class SearchGenerator
    {
        public static JObject GenerateJson()
        {            
            string randomSearchName = "Test name";

            JObject savedSearchBody =
                    new JObject(
                        new JProperty("name", randomSearchName),
                        new JProperty("searchRequest",
                            new JObject(
                                new JProperty("offset", 0),
                                new JProperty("limit", 100),
                                new JProperty("locations", new JArray()
                                ))));
                        
            return savedSearchBody;
        }

        public static JObject GenerateJsonWithName(string searchName)
        {

            JObject savedSearchBody =
                    new JObject(
                        new JProperty("name", searchName),
                        new JProperty("searchRequest",
                            new JObject(
                                new JProperty("offset", 0),
                                new JProperty("limit", 100),
                                new JProperty("locations", new JArray()
                                ))));

            return savedSearchBody;
        }

        public static JObject GenerateJsonWithNameAndFilter(string searchName)
        {

            JObject savedSearchBody =
                    new JObject(
                        new JProperty("name", searchName),
                        new JProperty("searchRequest",
                            new JObject(
                                new JProperty("minimumPricePerMile", 100),
                                new JProperty("offset", 0),
                                new JProperty("limit", 100),
                                new JProperty("locations", new JArray()
                                ))));

            return savedSearchBody;
        }

        public static JObject GenerateSearchJsonCityToCity(string originCity, string originState, string originZip,
            string destinationCity, string destinationState, string destinationZip)
        {

            JObject savedSearchBody =
                    new JObject(
                        new JProperty("searchType", "Open"),
                        new JProperty("locations", new JArray(
                            new JObject(
                                new JProperty("city", originCity),
                                new JProperty("state", originState),
                                new JProperty("zip", originZip),
                                new JProperty("scope", "Pickup")
                                ),                                   
                            new JObject(
                                new JProperty("city", destinationCity),
                                new JProperty("state", destinationState),
                                new JProperty("zip", destinationZip),
                                new JProperty("scope", "Dropoff")
                                )
                            )
                        ),
                        new JProperty("offset", 0),
                        new JProperty("limit", 100)
                        );

            return savedSearchBody;
        }
    }
}
