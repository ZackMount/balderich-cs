using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 队伍列表
    /// </summary>
    public class List
    {
        /// <summary>
        /// 队伍
        /// </summary>
        [JsonProperty("teams")]
        public List<Info>? Teams { get; set; }
        /// <summary>
        /// 队伍总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
