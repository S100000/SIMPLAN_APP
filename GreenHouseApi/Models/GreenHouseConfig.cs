using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenHouseApi.Models
{
    public class GreenHouseConfig
    {
        public int Id { get; set; }
        public string ConfigName { get; set; } = string.Empty;
        public double MaxTemp { get; set; }
        public double MinTemp { get; set; }
        public double MaxSoilMoisture { get; set; }
        public double MinSoilMoisture { get; set; }
        public double MinWaterLevel { get; set; }
    }
}