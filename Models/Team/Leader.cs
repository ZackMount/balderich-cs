using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 队长信息
    /// </summary>
    public class Leader
    {
        /// <summary>
        /// 队长UID
        /// </summary>
        [JsonProperty("uid")] 
        public int Uid { get; set; }
        /// <summary>
        /// 队长用户名
        /// </summary>
        [JsonProperty("username")] 
        public string? Username { get; set; }
        /// <summary>
        /// 队长Rating
        /// </summary>
        [JsonProperty("rating")] 
        public int Rating { get; set; }
        /// <summary>
        /// 队长头像路径，若未上传则为空字符串
        /// </summary>
        [JsonProperty("avatar")] 
        public string? Avatar { get; set; }
    }
}
