using Newtonsoft.Json;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 比赛详细信息
    /// </summary>
    public class Info
    {
        /// <summary>
        /// 比赛ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 比赛封面路径
        /// </summary>
        [JsonProperty("cover")] 
        public string? Cover { get; set; }
        /// <summary>
        /// 比赛标题
        /// </summary>
        [JsonProperty("title")] 
        public string? Title { get; set; }
        /// <summary>
        /// 比赛等级
        /// </summary>
        [JsonProperty("level")] 
        public int Level { get; set; }
        /// <summary>
        /// 比赛模式
        /// </summary>
        [JsonProperty("mode")] 
        public int Mode { get; set; }
        /// <summary>
        /// 比赛开始时间时间戳
        /// </summary>
        [JsonProperty("start_date")] 
        public long StartDate { get; set; }
        /// <summary>
        /// 比赛结束时间时间戳
        /// </summary>
        [JsonProperty("ends_date")] 
        public long EndsDate { get; set; }
        /// <summary>
        /// 比赛描述
        /// </summary>
        [JsonProperty("desc")] 
        public string? Description { get; set; }
        /// <summary>
        /// 比赛状态
        /// </summary>
        [JsonProperty("state")] 
        public int State { get; set; }
        /// <summary>
        /// 参赛人数
        /// </summary>
        [JsonProperty("count")] 
        public int Count { get; set; }
    }
}
