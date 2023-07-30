using Newtonsoft.Json;

namespace Balderich.Models.Problem
{
    /// <summary>
    /// 解题信息
    /// </summary>
    public class SovledInfo
    {
        /// <summary>
        /// 解决人数
        /// </summary>
        [JsonProperty("solved")]
        public int Solved { get; set; }
        /// <summary>
        /// 错误次数
        /// </summary>
        [JsonProperty("wa")]
        public int WA { get; set; }
    }
}
