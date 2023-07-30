using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 比赛信息
    /// </summary>
    public class Contest
    {
        /// <summary>
        /// 比赛编号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 比赛封面路径，没有则为空
        /// </summary>
        [JsonProperty("cover")] 
        public string? Cover { get; set; }
        /// <summary>
        /// 比赛标题
        /// </summary>
        [JsonProperty("title")] 
        public string? Title { get; set; }
        /// <summary>
        /// 开始时间时间戳
        /// </summary>
        [JsonProperty("start_date")] 
        public long StartDate { get; set; }
        /// <summary>
        /// 结束时间时间戳
        /// </summary>
        [JsonProperty("ends_date")] 
        public long EndsDate { get; set; }
        /// <summary>
        /// 是否为战队赛
        /// </summary>
        [JsonProperty("is_team")] 
        public bool IsTeam { get; set; }
        /// <summary>
        /// 比赛简介
        /// </summary>
        [JsonProperty("desc")] 
        public string? Description { get; set; }
        /// <summary>
        /// 比赛状态
        /// </summary>
        [JsonProperty("state")] 
        public int State { get; set; }
    }
}
