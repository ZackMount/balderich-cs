using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 题目信息
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// 题目ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 解题数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 题目名
        /// </summary>
        public string? Title { get; set; }
    }
}
