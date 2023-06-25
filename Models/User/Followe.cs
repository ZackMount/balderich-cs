using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.User
{
    /// <summary>
    /// 粉丝/关注用户数据
    /// </summary>
    public class Followe
    {
        /// <summary>
        /// 用户UID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; }
        /// <summary>
        /// 用户个性签名
        /// </summary>
        [JsonProperty("bio")]
        public string? Bio { get; set; }
        /// <summary>
        /// 用户头像路径，若未上传则为空字符串
        /// </summary>
        [JsonProperty("avatar")]
        public string? Avatar { get; set; }
    }
}
