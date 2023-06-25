using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 关注列表
    /// </summary>
    public class FollowingList
    {
        /// <summary>
        /// 关注者信息
        /// </summary>
        [JsonProperty("data")]
        public List<Followe>? Followings { get; set; }
    }

}
