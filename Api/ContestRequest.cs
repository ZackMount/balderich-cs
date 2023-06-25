using Balderich.Models.Contest;
using Balderich.Utils;
using Newtonsoft.Json;


namespace Balderich.Api
{
    public static class Contest
    {
        /// <summary>
        /// 获取比赛列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="type">比赛类型，[0, 1]分别代表[公开赛事, 私密赛事]，默认公开赛事</param>
        /// <returns>比赛列表</returns>
        public static async Task<List>? GetList(Session session, int page, int type = 1)
        {
            var apiMessageResult = await Request.GetAsync(session, $"contest/{type}/list/{page}/");
            return JsonConvert.DeserializeObject<List>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取比赛详细信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="cid">比赛ID</param>
        /// <returns>比赛详细信息</returns>
        public static async Task<Info>? GetInfo(Session session, int cid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"contest/{cid}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data.ToString());
        }
    }
}
