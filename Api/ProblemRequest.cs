using Balderich.Models.Problem;
using Balderich.Utils;
using Newtonsoft.Json;

namespace Balderich.Api
{
    /// <summary>
    /// 题目模块
    /// </summary>
    public class Problem
    {
        public Problem(Session session)
        {
            this.session = session;
        }
        private readonly Session session;
        /// <summary>
        /// 获取题目列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>题目列表</returns>
        public async Task<List?> GetListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<List>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取题目详细信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="pid">题目ID</param>
        /// <returns>题目详细信息</returns>
        public async Task<Info?> GetInfoAsync(int pid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/{pid}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取题单列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <returns>题单列表</returns>
        public async Task<SheetList?> GetSheetListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/sheet/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<SheetList>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取题单详细数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="psid">题单ID</param>
        /// <returns>题单详细数据</returns>
        public async Task<SheetInfo?> GetSheetInfoAsync(int psid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/sheet/{psid}/info/");
            return JsonConvert.DeserializeObject<SheetInfo>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取题单题目列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="psid">题单ID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>题单题目列表</returns>
        public async Task<List> GetSheetProblemListAsync(int psid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"problem/sheet/{psid}/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<List>(apiMessageResult?.Data?.ToString());
        }
    }
}
