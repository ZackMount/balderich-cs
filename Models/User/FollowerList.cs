﻿using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 粉丝用户数据
    /// </summary>
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
    /// <summary>
    /// 粉丝列表
    /// </summary>
    public class FollowerList
    {
        /// <summary>
        /// 粉丝信息
        /// </summary>
        [JsonProperty("data")]
        public List<Follower>? Followers { get; set; }
    }

}
