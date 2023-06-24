using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 用户个人信息
    /// </summary>
    public class Info
    {
        /// <summary>
        /// 用户UID
        /// </summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
        /// <summary>
        /// 用户UID
        /// </summary>
        [JsonProperty("bio")]
        public string? Bio { get; set; }
        /// <summary>
        /// 用户简介
        /// </summary>
        [JsonProperty("intro")]
        public string? Intro { get; set; }
        /// <summary>
        /// 用户解题数量
        /// </summary>
        [JsonProperty("solves")]
        public int Solves { get; set; }
        /// <summary>
        /// 用户Rating分数
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }
        /// <summary>
        /// 用户头像路径，如果未上传则为空字符串
        /// </summary>
        [JsonProperty("avatar")]
        public string? Avatar { get; set; }
        /// <summary>
        /// 用户背景图路径，如果未上传则为空字符串
        /// </summary>
        [JsonProperty("cover")]
        public string? Cover { get; set; }
        /// <summary>
        /// 用户注册时间时间戳
        /// </summary>
        [JsonProperty("register_date")]
        public long Register_Date { get; set; }
        /// <summary>
        /// 用户最后登录时间时间戳
        /// </summary>
        [JsonProperty("last_login_date")]
        public long LastLoginDate { get; set; }
        /// <summary>
        /// 用户邮箱，如果设置未公开则为空字符串
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }
        /// <summary>
        /// 用户粉丝数量
        /// </summary>
        [JsonProperty("followers")]
        public int Followers { get; set; }
        /// <summary>
        /// 用户关注数量
        /// </summary>
        [JsonProperty("following")]
        public int Following { get; set; }
        /// <summary>
        /// 用户战队ID，如果未加入战队则为0
        /// </summary>
        [JsonProperty("tid")]
        public int Tid { get; set; }
        /// <summary>
        /// 用户战队名，如果未加入战队则为空字符串
        /// </summary>
        [JsonProperty("team")]
        public string? Team { get; set; }
        /// <summary>
        /// 用户是否为VIP用户
        /// </summary>
        [JsonProperty("is_vip")]
        public bool IsVip { get; set; }
    }
}
