using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Problem
{
    public class List
    {
        /// <summary>
        /// 题目列表
        /// </summary>
        [JsonProperty("problems")]
        public List<Problem>? Problems { get; set; }
        /// <summary>
        /// 题目总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
