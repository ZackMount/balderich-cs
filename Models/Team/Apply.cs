using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 战队申请列表
    /// </summary>
    public class Apply
    {
        /// <summary>
        /// 入队申请用户信息
        /// </summary>
        [JsonProperty("users")] 
        public List<ApplyUserList>? ApplyUsers { get; set; }
        /// <summary>
        /// 总用户数量
        /// </summary>
        [JsonProperty("total")] 
        public int Total { get; set; }
    }
}
