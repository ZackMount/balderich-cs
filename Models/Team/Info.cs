using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 队伍信息
    /// </summary>
    public class Info
    {
        /// <summary>
        /// 战队ID
        /// </summary>
        [JsonProperty("id")] 
        public int Id { get; set; }
        /// <summary>
        /// 战队名称
        /// </summary>
        [JsonProperty("name")] 
        public string? Name { get; set; }
        /// <summary>
        /// 战队头像路径，若未上传则为空字符串
        /// </summary>
        [JsonProperty("avatar")] 
        public string? Avatar { get; set; }
        /// <summary>
        /// 战队简介
        /// </summary>
        [JsonProperty("bio")] 
        public string? Bio { get; set; }
        /// <summary>
        /// 创建日期时间戳
        /// </summary>
        [JsonProperty("date")] 
        public long Date { get; set; }
        /// <summary>
        /// 队长信息
        /// </summary>
        [JsonProperty("user")] 
        public User? User { get; set; }
        /// <summary>
        ///	人员数量
        /// </summary>
        [JsonProperty("nums")] 
        public int Nums { get; set; }
    }

}
