using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 比赛详细信息
    /// </summary>
    public class ContestDetails
    {
        /// <summary>
        /// 比赛编号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 比赛权限
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }
        /// <summary>
        /// 比赛类型
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }
        /// <summary>
        /// 比赛模式
        /// </summary>
        [JsonProperty("Mode")] 
        public int Mode { get; set; }
        /// <summary>
        /// 比赛简介
        /// </summary>
        [JsonProperty("desc")]
        public string? Description { get; set; }
        /// <summary>
        /// 比赛封面路径，没有则为空
        /// </summary>
        [JsonProperty("cover")]
        public string? Cover { get; set; }
        /// <summary>
        /// 一血额外得分（百分比）
        /// </summary>
        [JsonProperty("top_score")] 
        public int TopScore { get; set; }
        /// <summary>
        /// 一血后递减额外得分（百分比）	
        /// </summary>
        [JsonProperty("decrease_score")] 
        public int DecreaseScore { get; set; }
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
    }
}
