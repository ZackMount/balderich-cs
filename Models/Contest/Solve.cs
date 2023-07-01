using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 解题信息
    /// </summary>
    public class Solve
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户标题
        /// </summary>
        public string? Username { get; set; }
        /// <summary>
        /// 解题题目ID
        /// </summary>
        public List<string>? SolvedId { get; set; }
        /// <summary>
        /// 解题时间ID
        /// </summary>
        public List<string>? SolvedTime { get; set; }
        /// <summary>
        /// 用户Rating
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// 总得分
        /// </summary>
        public int Score { get; set; }
    }
}
