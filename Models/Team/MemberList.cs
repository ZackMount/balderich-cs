using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 成员列表
    /// </summary>
    public class MemberList
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        [JsonProperty("users")]
        public List<Member>? Users { get; set; }
        /// <summary>
        /// 总用户数量
        /// </summary>
        [JsonProperty("total")] 
        public int Total { get; set; }
    }
}
