using CAD.CD.Search.TestFramework.Config;
using Newtonsoft.Json.Linq;
using System;

namespace CAD.CD.Search.TestFramework.PageObjects.Utils
{
    public static class ListingGenerator
    {
        public static JObject GenerateListingJson()
        {
            Random rnd = new Random();
            string[] trailertypes = new[] { "Open", "Enclosed", "Driveaway"};
            string[] paymentMethods = new[] { "CASH_CERTIFIED_FUNDS", "CHECK" };
           
            JArray lisings = new JArray();

                int price = rnd.Next(0, 20000);
                int originNumber = rnd.Next(0, 39131);
                int destinationNumber = rnd.Next(0, 39131);
                string originCity = ConfigLoader.LoadJson("USCities")[originNumber]["city"];
                string originState = ConfigLoader.LoadJson("USCities")[originNumber]["state"];
                string originZip = ConfigLoader.LoadJson("USCities")[originNumber]["zip_code"];

                string destinationCity = ConfigLoader.LoadJson("USCities")[destinationNumber]["city"];
                string destinationState = ConfigLoader.LoadJson("USCities")[destinationNumber]["state"];
                string destinationZip = ConfigLoader.LoadJson("USCities")[destinationNumber]["zip_code"];

                JObject lising =
                        new JObject(
                            new JProperty("origin",
                                new JObject(
                                    new JProperty("city", originCity),
                                    new JProperty("state", originState),
                                    new JProperty("zip", originZip))),
                            new JProperty("destination",
                                new JObject(
                                    new JProperty("city", destinationCity),
                                    new JProperty("state", destinationState),
                                    new JProperty("zip", destinationZip))),
                            new JProperty("partnerReferenceId", "1testtes"),
                            new JProperty("trailerType", trailertypes[rnd.Next(trailertypes.Length)]),
                            new JProperty("vehicles",
                                new JArray(
                                    new JObject(
                                            new JProperty("year", "2020"),
                                            new JProperty("make", "Hoonda"),
                                            new JProperty("model", "Sivic"),
                                            new JProperty("vehicleType", "Other"),
                                            new JProperty("VehicleTypeOther", "My Other"),
                                            new JProperty("qty", "1"),
                                            new JProperty("wideLoad", "true")))),
                            new JProperty("availableDate", DateTime.Today.ToString("yyyy-MM-dd")),
                            new JProperty("desiredDeliveryDate", DateTime.Today.ToString("yyyy-MM-dd")),
                             new JProperty("price",
                                new JObject(
                                    new JProperty("total", price),
                                    new JProperty("cod",
                                        new JObject(
                                            new JProperty("amount", price),
                                            new JProperty("paymentMethod", paymentMethods[rnd.Next(paymentMethods.Length)]),
                                            new JProperty("paymentLocation", "Delivery"))))));

            return lising;
        }

        public static JObject GenerateListingJsonWithDestination(string destinationCity, string destinationState, string destinationZip)
        {
            Random rnd = new Random();
            string[] trailertypes = new[] { "Open", "Enclosed", "Driveaway" };
            string[] paymentMethods = new[] { "CASH_CERTIFIED_FUNDS", "CHECK" };

            JArray lisings = new JArray();

            int price = rnd.Next(0, 20000);
            int originNumber = rnd.Next(0, 39131);
            string originCity = ConfigLoader.LoadJson("USCities")[originNumber]["city"];
            string originState = ConfigLoader.LoadJson("USCities")[originNumber]["state"];
            string originZip = ConfigLoader.LoadJson("USCities")[originNumber]["zip_code"];

            JObject lising =
                    new JObject(
                        new JProperty("origin",
                            new JObject(
                                new JProperty("city", originCity),
                                new JProperty("state", originState),
                                new JProperty("zip", originZip))),
                        new JProperty("destination",
                            new JObject(
                                new JProperty("city", destinationCity),
                                new JProperty("state", destinationState),
                                new JProperty("zip", destinationZip))),
                        new JProperty("partnerReferenceId", "1testtes"),
                        new JProperty("trailerType", trailertypes[rnd.Next(trailertypes.Length)]),
                        new JProperty("vehicles",
                            new JArray(
                                new JObject(
                                        new JProperty("year", "2020"),
                                        new JProperty("make", "Hoonda"),
                                        new JProperty("model", "Sivic"),
                                        new JProperty("vehicleType", "Other"),
                                        new JProperty("VehicleTypeOther", "My Other"),
                                        new JProperty("qty", "1"),
                                        new JProperty("wideLoad", "true")))),
                        new JProperty("availableDate", DateTime.Today.ToString("yyyy-MM-dd")),
                        new JProperty("desiredDeliveryDate", DateTime.Today.ToString("yyyy-MM-dd")),
                         new JProperty("price",
                            new JObject(
                                new JProperty("total", price),
                                new JProperty("cod",
                                    new JObject(
                                        new JProperty("amount", price),
                                        new JProperty("paymentMethod", paymentMethods[rnd.Next(paymentMethods.Length)]),
                                        new JProperty("paymentLocation", "Delivery"))))));

            return lising;
        }

        public static JObject GenerateListingJsonWithOrigin(string originCity, string originState, string originZip)
        {
            Random rnd = new Random();
            string[] trailertypes = new[] { "Open", "Enclosed", "Driveaway" };
            string[] paymentMethods = new[] { "CASH_CERTIFIED_FUNDS", "CHECK" };

            JArray lisings = new JArray();

            int price = rnd.Next(0, 20000);
            int destinationNumber = rnd.Next(0, 39131);

            string destinationCity = ConfigLoader.LoadJson("USCities")[destinationNumber]["city"];
            string destinationState = ConfigLoader.LoadJson("USCities")[destinationNumber]["state"];
            string destinationZip = ConfigLoader.LoadJson("USCities")[destinationNumber]["zip_code"];

            JObject lising =
                    new JObject(
                        new JProperty("origin",
                            new JObject(
                                new JProperty("city", originCity),
                                new JProperty("state", originState),
                                new JProperty("zip", originZip))),
                        new JProperty("destination",
                            new JObject(
                                new JProperty("city", destinationCity),
                                new JProperty("state", destinationState),
                                new JProperty("zip", destinationZip))),
                        new JProperty("partnerReferenceId", "1testtes"),
                        new JProperty("trailerType", trailertypes[rnd.Next(trailertypes.Length)]),
                        new JProperty("vehicles",
                            new JArray(
                                new JObject(
                                        new JProperty("year", "2020"),
                                        new JProperty("make", "Hoonda"),
                                        new JProperty("model", "Sivic"),
                                        new JProperty("vehicleType", "Other"),
                                        new JProperty("VehicleTypeOther", "My Other"),
                                        new JProperty("qty", "1"),
                                        new JProperty("wideLoad", "true")))),
                        new JProperty("availableDate", DateTime.Today.ToString("yyyy-MM-dd")),
                        new JProperty("desiredDeliveryDate", DateTime.Today.ToString("yyyy-MM-dd")),
                         new JProperty("price",
                            new JObject(
                                new JProperty("total", price),
                                new JProperty("cod",
                                    new JObject(
                                        new JProperty("amount", price),
                                        new JProperty("paymentMethod", paymentMethods[rnd.Next(paymentMethods.Length)]),
                                        new JProperty("paymentLocation", "Delivery"))))));

            return lising;
        }

        public static JObject GenerateListingJsonWithOriginAndDestination(string originCity, string originState, string originZip,
            string destinationCity, string destinationState, string destinationZip)
        {
            Random rnd = new Random();
            string[] trailertypes = new[] { "Open", "Enclosed", "Driveaway" };
            string[] paymentMethods = new[] { "CASH_CERTIFIED_FUNDS", "CHECK" };

            JArray lisings = new JArray();

            int price = rnd.Next(0, 20000);

            JObject lising =
                    new JObject(
                        new JProperty("origin",
                            new JObject(
                                new JProperty("city", originCity),
                                new JProperty("state", originState),
                                new JProperty("zip", originZip))),
                        new JProperty("destination",
                            new JObject(
                                new JProperty("city", destinationCity),
                                new JProperty("state", destinationState),
                                new JProperty("zip", destinationZip))),
                        new JProperty("partnerReferenceId", "1testtes"),
                        new JProperty("trailerType", trailertypes[rnd.Next(trailertypes.Length)]),
                        new JProperty("vehicles",
                            new JArray(
                                new JObject(
                                        new JProperty("year", "2020"),
                                        new JProperty("make", "Hoonda"),
                                        new JProperty("model", "Sivic"),
                                        new JProperty("vehicleType", "Other"),
                                        new JProperty("VehicleTypeOther", "My Other"),
                                        new JProperty("qty", "1"),
                                        new JProperty("wideLoad", "true")))),
                        new JProperty("availableDate", DateTime.Today.ToString("yyyy-MM-dd")),
                        new JProperty("desiredDeliveryDate", DateTime.Today.ToString("yyyy-MM-dd")),
                         new JProperty("price",
                            new JObject(
                                new JProperty("total", price),
                                new JProperty("cod",
                                    new JObject(
                                        new JProperty("amount", price),
                                        new JProperty("paymentMethod", paymentMethods[rnd.Next(paymentMethods.Length)]),
                                        new JProperty("paymentLocation", "Delivery"))))));

            return lising;
        }
    }
}
