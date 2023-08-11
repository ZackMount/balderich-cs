using Newtonsoft.Json;


namespace Balderich.Models.Team
{
    /// <summary>
    /// 队员信息
    /// </summary>
    public class Member
    {
        /// <summary>
        /// 成员编号
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
        /// 用户别名
        /// </summary>
        [JsonProperty("alias")] 
        public string? Alias { get; set; }
        /// <summary>
        /// 加入日期时间戳
        /// </summary>
        [JsonProperty("date")] 
        public int Date { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        [JsonProperty("role")] 
        public int Role { get; set; }
    }
}
