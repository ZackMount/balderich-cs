using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.User
{
    /// <summary>
    /// 文章信息
    /// </summary>
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
        public long? Date { get; set; }
        /// <summary>
        /// 文章种类ID
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
    }
}
