using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balderich_cs.Models.User
{
    public class Follower
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

    public class FollowerList
    {
        /// <summary>
        /// 粉丝列表
        /// </summary>
        [JsonProperty("data")]
        public List<Follower>? Followers { get; set; }
    }

}
