using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 入队申请用户信息
    /// </summary>
    public class ApplyUserList
    {
        /// <summary>
        /// 申请编号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 用户UID
        /// </summary>
        [JsonProperty("uid")] 
        public int Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("username")] 
        public string? Username { get; set; }
        /// <summary>
        /// 用户Rating
        /// </summary>
        [JsonProperty("rating")] 
        public int Rating { get; set; }
        /// <summary>
        /// 申请理由
        /// </summary>
        [JsonProperty("msg")] 
        public string? Message { get; set; }
        /// <summary>
        /// 申请日期时间戳
        /// </summary>
        [JsonProperty("date")] 
        public long Date { get; set; }
    }
}
