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
}
