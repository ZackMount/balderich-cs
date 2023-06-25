using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 粉丝列表
    /// </summary>
    public class FollowerList
    {
        /// <summary>
        /// 粉丝信息
        /// </summary>
        [JsonProperty("data")]
        public List<Followe>? Followers { get; set; }
    }

}
