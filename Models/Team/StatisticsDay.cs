using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 用户当日解题数据
    /// </summary>
    public class StatisticsDay
    {
        /// <summary>
        /// 用户UID
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; }
        /// <summary>
        /// 公开题库解题数
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// 公开题库得分
        /// </summary>
        [JsonProperty("sum_score")]
        public int SumScore { get; set; }
        /// <summary>
        /// 战队题库解题数
        /// </summary>
        [JsonProperty("username")]
        public int TeamCount { get; set; }
        /// <summary>
        /// 战队题库得分
        /// </summary>
        [JsonProperty("team_sum_score")]
        public int TeamSumScore { get; set; }
    }
}
