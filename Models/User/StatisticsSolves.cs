using Newtonsoft.Json;
using System.Collections.Generic;

namespace Balderich.Models
{
    public class ChallengeType
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

    public class StatisticsSolves
    {
        /// <summary>
        /// 题解数据
        /// </summary>
        [JsonProperty("data")]
        public List<ChallengeType> Solves { get; set; }
    }

}
