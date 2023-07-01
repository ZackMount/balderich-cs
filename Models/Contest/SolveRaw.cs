using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 解题信息
    /// </summary>
    public class SolveRaw
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("id")] 
        public int Id { get; set; }
        /// <summary>
        /// 用户标题
        /// </summary>
        [JsonProperty("username")] 
        public string? Username { get; set; }
        /// <summary>
        /// 解题题目ID（|隔开）
        /// </summary>
        [JsonProperty("solved")] 
        public string? SolvedId { get; set; }
        /// <summary>
        /// 解题时间ID（|隔开）
        /// </summary>
        [JsonProperty("solved_time")] 
        public string? SolvedTime { get; set; }
        /// <summary>
        /// 用户Rating
        /// </summary>
        [JsonProperty("rating")] 
        public int Rating { get; set; }
        /// <summary>
        /// 总得分
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }
    }
}
