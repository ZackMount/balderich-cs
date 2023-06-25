using Newtonsoft.Json;

namespace Balderich.Models.Problem
{
    /// <summary>
    /// 题单信息
    /// </summary>
    public class SheetInfo
    {
        /// <summary>
        /// 题单ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 题单标题
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        /// <summary>
        /// 收藏数
        /// </summary>
        [JsonProperty("stars")] 
        public int Stars { get; set; }
        /// <summary>
        /// 题目数量
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// 上传者信息
        /// </summary>
        [JsonProperty("author")]
        public Author? Author { get; set; }
    }
}
