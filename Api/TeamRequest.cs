using Balderich.Models.Team;
using Balderich.Utils;
using Newtonsoft.Json;
using System.Drawing;
using System.Security.Cryptography;

namespace Balderich.Api
{
    public static class Team
    {
        /// <summary>
        /// 获取战队列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">战队列表</param>
        /// <param name="size">每页大小</param>
        /// <returns>战队列表</returns>
        public static async Task<List?> GetListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<List>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队详细信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="tid">团队ID</param>
        /// <returns>战队详细信息</returns>
        public static async Task<Info?> GetInfoAsync(Session session,int tid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/{tid}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队通知信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <returns>战队通知信息</returns>
        public static async Task<string> GetNotice(Session session)
        {
            var apiMessageResult = await Request.GetAsync(session, "team/notice/");
            return apiMessageResult?.Data["notice"] ?? "";
        }
    }
}
