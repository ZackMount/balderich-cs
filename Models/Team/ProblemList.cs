using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 题目列表
    /// </summary>
    public class ProblemList
    {
        /// <summary>
        /// 题目
        /// </summary>
        [JsonProperty("problems")] 
        public List<Problem>? Problems { get; set; }
        /// <summary>
        /// 题目信息
        /// </summary>
        [JsonProperty("total")] 
        public int Total { get; set; }
    }
}
