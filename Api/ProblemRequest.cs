using Balderich.Models.Problem;
using Balderich.Utils;
using Newtonsoft.Json;
using System.Drawing;

namespace Balderich.Api
{
    public static class Problem
    {
        /// <summary>
        /// 获取题目列表
        /// </summary>
        /// <param name="session"></param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>题目列表</returns>
        public static async Task<ProblemList?> GetProblemList(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ProblemList>(apiMessageResult?.Data.ToString());
        }
    }
}
