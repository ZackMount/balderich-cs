using Newtonsoft.Json;

namespace Balderich.Models.Problem
{
    /// <summary>
    /// 题单列表
    /// </summary>
    public class SheetList
    {
        /// <summary>
        /// 题单
        /// </summary>
        [JsonProperty("sheets")]
        public List<SheetInfo>? Sheets { get; set; }
        /// <summary>
        /// 题目总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
