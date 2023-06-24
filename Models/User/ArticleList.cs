using Newtonsoft.Json;
using System.Collections.Generic;

namespace Balderich.Models
{
    public class Article
    {
        /// <summary>
        /// 文章标题
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        /// <summary>
        /// 文章ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
        /// <summary>
        /// 文章上传日期
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }
        /// <summary>
        /// 文章种类ID
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
    }
    public class ArticleList
    {
        /// <summary>
        /// 文章数据
        /// </summary>
        [JsonProperty("articles")]
        public List<Article>? Articles { get; set; }
        /// <summary>
        /// 文章总数
        /// </summary>
        [JsonProperty("total")]
        public int? Total { get; set; }
    }

}
