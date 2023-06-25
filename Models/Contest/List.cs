using Newtonsoft.Json;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 比赛列表
    /// </summary>
    public class List
    {
        /// <summary>
        /// 比赛列表
        /// </summary>
        [JsonProperty("contests")]
        public List<Info> Contests { get; set; }
        /// <summary>
        /// 比赛总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
