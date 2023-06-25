using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 文章列表
    /// </summary>
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
