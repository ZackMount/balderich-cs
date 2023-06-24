using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 每场比赛排名以及积分变动数据
    /// </summary>
    public class StatisticsRating
    {
        /// <summary>
        /// 比赛日期时间时间戳
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// 比赛后新的Rating
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }
        /// <summary>
        /// 比赛标题
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        /// <summary>
        /// 比赛最终排名，如果比赛未计算Rating则为0
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }
        /// <summary>
        /// 是否为不计算Rating的比赛
        /// </summary>
        [JsonProperty("unrated")]
        public bool Unrated { get; set; }
        /// <summary>
        /// 参赛人数数量
        /// </summary>
        [JsonProperty("nums")]
        public int Nums { get; set; }
    }
    public class StatisticsRatingRoot
    {
        [JsonProperty("data")]
        public List<StatisticsRating>? Ratings { get; set; }
    }

}
