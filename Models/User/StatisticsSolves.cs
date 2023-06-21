using Newtonsoft.Json;
using System.Collections.Generic;

namespace Balderich.Models
{
    public class ChallengeType
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("data")]
        public List<int> Data { get; set; }
    }

    public class StatisticsSolves
    {
        [JsonProperty("")]
        public List<ChallengeType> Types { get; set; }
    }
}
