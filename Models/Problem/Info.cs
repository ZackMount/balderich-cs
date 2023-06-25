using Newtonsoft.Json;

namespace Balderich.Models.Problem
{
    /// <summary>
    /// 题目详细信息
    /// </summary>
    public class Info
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
        ///	题目描述
        /// </summary>
        [JsonProperty("desc")] 
        public string? Description { get; set; }
        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("point")] 
        public int Point { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags")] 
        public List<string>? Tags { get; set; }
        /// <summary>
        /// 是否有提示
        /// </summary>
        [JsonProperty("hint")] 
        public bool Hint { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        [JsonProperty("level")] 
        public float Level { get; set; }
        /// <summary>
        /// 是否有附件
        /// </summary>
        [JsonProperty("annex")] 
        public bool Annex { get; set; }
        /// <summary>
        /// 是否有靶机
        /// </summary>
        [JsonProperty("docker")] 
        public bool Docker { get; set; }
        /// <summary>
        /// 题目价格
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }
        /// <summary>
        /// 收藏数量
        /// </summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }
        /// <summary>
        /// 上传日期时间戳
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }
        /// <summary>
        /// 解题信息
        /// </summary>
        [JsonProperty("info")]
        public SovledInfo? SolvedInfo { get; set; }
        /// <summary>
        /// 上传者信息
        /// </summary>
        [JsonProperty("author")]
        public Author? Author { get; set; }
    }
}
