using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 原始比赛排行榜数据
    /// </summary>
    public class RankListRaw
    {
        /// <summary>
        /// 题目类型字符串，“1”->"10"分别代表WEB->实战。
        /// </summary>
        [JsonProperty("category")]
        public List<string>? Category { get; set; }
        /// <summary>
        /// 分数(键为题目PID，值为题目当前分数)
        /// </summary>
        [JsonProperty("point")]
        public Dictionary<string, int>? Points { get; set; }
        /// <summary>
        /// 前三血(键为题目PID，值为前三血用户UID字符串列表)
        /// </summary>
        [JsonProperty("top3")]
        public Dictionary<string, string>? Top3 { get; set; }
        /// <summary>
        /// 是否团队赛
        /// </summary>
        [JsonProperty("team")]
        public bool? Team { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        /// <summary>
        /// 题目详细信息列表
        /// </summary>
        [JsonProperty("problems")] 
        public List<List<object>>? Problems { get; set; }
        /// <summary>
        /// 解题信息
        /// </summary>
        [JsonProperty("solves")]
        public List<SolveRaw>? Solves { get; set; }
    }
}
