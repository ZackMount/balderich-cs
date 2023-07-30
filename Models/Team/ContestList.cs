using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    public class ContestList
    {
        /// <summary>
        /// 比赛列表
        /// </summary>
        [JsonProperty("contests")]
        public List<Contest>? Contests { get; set; }
        /// <summary>
        /// 比赛总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
