using System.Collections.Generic;

namespace CAD.CD.Search.TestFramework.PageObjects.Utils
{
    public class Values
    {
        public enum ViewOptions
        {
            FullView,
            ScanView,
            MapView
        }

        public static List<string> GetReadyToShipWithInValues()
        {
            return new List<string>
            {
                "All",
                "Today",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "10",
                "14",
                "30",
                "60 (Default)"
            };
        }

        public static List<string> GetPaymentTypeDropDownValues()
        {
            return new List<string>
            {
                "All",
                "COD/COP",
                "COD/COP/Quickpay/Comchek",
            };
        }

        public static List<string> GetVehicleTypeDropDownValues()
        {
            return new List<string>
            {
                "ATV",
                "Boat",
                "Car",
                "Heavy Equipment",
                "Large Yacht",
                "Motorcycle",
                "Pickup",
                "RV",
                "SUV",
                "Travel Trailer",
                "Van",
                "Other"
            };
        }

        public static List<string> GetTrailerTypeDropDownValues()
        {
            return new List<string>
            {
                "All",
                "Open",
                "Enclosed",
                "Driveaway"
            };
        }

        public static List<string> GetRunningDropDownValues()
        {
            return new List<string>
            {
                "All",
                "Running",
                "Non running"
            };
        }

        public static List<string> GetMinimumVehiclesNumberDropDownValues()
        {
            return new List<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10"
            };
        }

        public static List<string> GetMaximumVehiclesNumberDropDownValues()
        {
            return new List<string>
            {
                "All",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10"
            };
        }

        public static List<string> GetResultsPerPageDropDownValues()
        {
            return new List<string>
            {
                "25",
                "50",
                "100 (Default)",
                "250",
            };
        }

        public static List<string> GetSortByDropDownValues()
        {
            return new List<string>
            {
                "From (Default)",
                "From Metro Area",
                "To",
                "To Metro Area",
                "Ship Date",
                "Company Name",
                "Post Date",
                "Price",
                "Price Per Mile",
                "Preferred Shipper",
                
            };
        }

        public static List<string> GetThenDropDownValues()
        {
            return new List<string>
            {
                "From",
                "From Metro Area",
                "To",
                "To Metro Area (Default)",
                "Ship Date",
                "Company Name",
                "Post Date",
                "Price",
                "Price Per Mile",
                "Preferred Shipper",
                
            };
        }

        public static List<string> GetStartRadiusDropDownValues()
        {
            return new List<string>
            {
                "None",
                "25 (Default)",
                "50",
                "75",
                "100",
            };
        }

        public static List<string> GetUserMenuValues()
        {
            return new List<string>
            {
                "My Profile",
                "My Billing",
                "My Ratings",
                "My Documents",
                "My Contracts",
                "My Network",
                "My Address Book",
            };
        }
    }
}
