using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Balderich.Models
{
    public class StatisticsActiveInput
    {
        [JsonProperty("start_date")]
        public long StartDate { get; set; }
        [JsonProperty("ends_date")]
        public long EndsDate { get; set; }
        [JsonProperty("count")]
        public List<List<object>> Count { get; set; }
    }
    public class SolveData
    {
        /// <summary>
        /// 日期字符串
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 解题数量
        /// </summary>
        public int Count { get; set; }
    }

    public class StatisticsActive
    {
        /// <summary>
        /// 开始时间时间戳
        /// </summary>
        public long StartDate { get; set; }
        /// <summary>
        /// 结束时间时间戳
        /// </summary>
        public long EndsDate { get; set; }
        /// <summary>
        /// 解题数据列表，其中每一项都为[日期字符串, 解题数量]的列表
        /// </summary>
        public List<SolveData> Count { get; set; }

        public StatisticsActive(StatisticsActiveInput sai)
        {
            StartDate = sai.StartDate;
            EndsDate = sai.EndsDate;
            Count = sai.Count.Select(x => new SolveData { Date = x[0].ToString(), Count = (int)(long)x[1] }).ToList();
        }
    }
}
