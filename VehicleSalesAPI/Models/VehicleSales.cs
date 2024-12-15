using System.Collections.Generic;

namespace VehicleSalesAPI.Models
{
    public class VehicleSales
    {
        public int Year { get; set; }
        public int Quarter { get; set; }
        public string Region { get; set; }
        public string Model { get; set; }
        public int UnitsSold { get; set; }

        public static List<VehicleSales> GetSampleData()
        {
            return new List<VehicleSales>
            {
                new VehicleSales { Year = 2021, Quarter = 1, Region = "North", Model = "Sedan", UnitsSold = 120 },
                new VehicleSales { Year = 2021, Quarter = 2, Region = "South", Model = "SUV", UnitsSold = 95 },
                // Add more sample data as needed
            };
        }
    }
}
