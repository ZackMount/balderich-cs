using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 题目信息
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// 题目编号
        /// </summary>
        [JsonProperty("id")] 
        public int Id { get; set; }
        /// <summary>
        /// 题目标题
        /// </summary>
        [JsonProperty("title")] 
        public string? Title { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }
        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("point")] 
        public int Point { get; set; }
        /// <summary>
        /// 收藏数
        /// </summary>
        [JsonProperty("likes")] 
        public int Likes { get; set; }
        /// <summary>
        /// 解题人数
        /// </summary>
        [JsonProperty("solves")] 
        public int Solves { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        [JsonProperty("level")] 
        public int Level { get; set; }
    }
}
