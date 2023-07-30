﻿using Balderich.Models.Contest;
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
        public static async Task<List>? GetListAsync(Session session, int page, int type = 1)
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
        public static async Task<Info>? GetInfoAsync(Session session, int cid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"contest/{cid}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data.ToString()); 
        }
        /// <summary>
        /// 获取比赛排行榜数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="cid">比赛ID</param>
        /// <param name="page">页数</param>
        /// <returns>
        /// <br>cetegory为类型列表，包含题目类型字符串，“1”->"10"分别代表WEB->实战。</br>
        /// <br>point为分数字段，键为题目PID，值为题目当前分数。</br>
        /// <br>problems为题目详细信息列表，分别为PID，解题数，题目名。</br>
        /// <br>top3为前3血字典，键为题目PID，值为前三血用户UID字符串列表。</br>
        /// </returns>
        public static async Task<RankList>? GetRankListAsync(Session session, int cid, int page)
        {
            var apiMessageResult = await Request.GetAsync(session, $"contest/{cid}/rank/list/{page}/");
            return new RankList(JsonConvert.DeserializeObject<RankListRaw>(apiMessageResult?.Data.ToString()));
        }
    }
}
