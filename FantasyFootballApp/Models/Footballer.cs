using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyFootballApp.Models
{
    public class Footballer
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("second_name")]
        public string SecondName { get; set; }

        [JsonProperty("points_per_game")]
        public double PointsPerGame { get; set; }

        [JsonProperty("minutes")]
        public double MinutesPlayed { get; set; }

        //Read only
        public double MostEfficient { get { return (((MinutesPlayed / 90) * PointsPerGame) / CostNow) * 10; } } 

        [JsonProperty("now_cost")]
        public double CostNow { get; set; }
    }
}
