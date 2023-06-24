using Newtonsoft.Json;
using System.Collections.Generic;

namespace Balderich.Models.User
{
    /// <summary>
    /// 题解数据
    /// </summary>
    public class StatisticsSolves
    {
        /// <summary>
        /// 题目类型
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
        /// <summary>
        /// 题目类型名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 全部解题时间戳
        /// </summary>
        [JsonProperty("data")]
        public List<int> Time { get; set; }
    }

    public class StatisticsSolvesRoot
    {
        [JsonProperty("data")]
        public List<StatisticsSolves>? Solves { get; set; }
    }

}
