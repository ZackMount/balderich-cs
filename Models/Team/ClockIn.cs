using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    /// <summary>
    /// 打卡信息
    /// </summary>
    public class ClockIn
    {
        /// <summary>
        /// 返回此次打卡是否生效（一天最多生效一次）
        /// </summary>
        [JsonProperty("state")]
        public bool State { get; set; }
        /// <summary>
        /// 已打卡天数
        /// </summary>
        [JsonProperty("nums")] 
        public int Nums { get; set; }
    }
}
