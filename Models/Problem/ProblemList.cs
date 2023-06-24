using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Problem
{
    /// <summary>
    /// 上传者
    /// </summary>
    public class Author
    {
        /// <summary>
        /// 上传者UID
        /// </summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
        /// <summary>
        /// 上传者用户名
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        /// <summary>
        /// 上传者Rating
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }
    }
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
        /// 上传者
        /// </summary>
        [JsonProperty("author")]
        public Author? Author { get; set; }
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
        /// 评分
        /// </summary>
        [JsonProperty("level")]
        public double Level { get; set; }
    }
    public class ProblemList
    {
        /// <summary>
        /// 题目列表
        /// </summary>
        [JsonProperty("problems")]
        public List<Problem>? Problems { get; set; }
        /// <summary>
        /// 题目总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
