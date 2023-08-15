using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balderich.Models.Contest
{
    /// <summary>
    /// 比赛排行榜数据
    /// </summary>
    public class RankList
    {
        /// <summary>
        /// 题目类型字符串，“1”->"10"分别代表WEB->实战。
        /// </summary>
        public List<string>? Category { get; set; }
        /// <summary>
        /// 分数(键为题目PID，值为题目当前分数)
        /// </summary>
        public Dictionary<string, int>? Points { get; set; }
        /// <summary>
        /// 前三血(键为题目PID，值为前三血用户UID字符串列表)
        /// </summary>
        public Dictionary<string, string>? Top3 { get; set; }
        /// <summary>
        /// 是否团队赛
        /// </summary>
        public bool? Team { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 题目详细信息列表
        /// </summary>
        public List<Problem>? Problems { get; set; }
        /// <summary>
        /// 解题信息
        /// </summary>
        public List<Solve>? Solves { get; set; }
        public RankList(RankListRaw data)
        {
            Category = data.Category;
            Points = data.Points;
            Top3 = data.Top3;
            Team = data.Team;
            Total = data.Total;
            foreach (var item in data.Problems)
            {
                Problem problem = new()
                {
                    Id = (int)item[0],
                    Count = (int)item[1],
                    Title = (string)item[2]
                };
                Problems?.Add(problem);
            }
            foreach (var item in data.Solves)
            {
                Solve s = new()
                {
                    Id = item.Id,
                    Rating = item.Rating,
                    Score = item.Score,
                    Username = item.Username,
                    SolvedId = item?.SolvedId?.Split('|').ToList(),
                    SolvedTime = item?.SolvedTime?.Split('|').ToList()
                };
                Solves?.Add(s);
            }
        }
    }
}
