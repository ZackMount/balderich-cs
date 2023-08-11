using Balderich.Models.Team;
using Balderich.Utils;
using Newtonsoft.Json;
using System.Text;

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
        public static async Task<string> GetNoticeAsync(Session session)
        {
            var apiMessageResult = await Request.GetAsync(session, "team/notice/");
            return apiMessageResult?.Data["notice"] ?? "";
        }
        /// <summary>
        /// 战队每日打卡
        /// </summary>
        /// <param name="session">会话</param>
        /// <returns>打卡信息</returns>
        public static async Task<ClockIn> ClockinAsync(Session session)
        {
            var apiMessageResult = await Request.GetAsync(session, "team/clockin/");
            return JsonConvert.DeserializeObject<ClockIn>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队题目列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>战队题目列表</returns>
        public static async Task<ProblemList> GetProblemListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/problem/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ProblemList>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队题目详细信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="pid">题目ID</param>
        /// <returns>战队题目详细信息</returns>
        public static async Task<ProblemInfo> GetProblemInfoAsync(Session session, int pid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/problem/{pid}/info/");
            return JsonConvert.DeserializeObject<ProblemInfo>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队比赛列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">会话</param>
        /// <returns>其中state的值从[0-2]，分别代表未开始、进行中和已结束。</returns>
        public static async Task<ContestList> GetContestListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ContestList>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队比赛详细信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="cid">比赛ID</param>
        /// <returns>
        /// <br>其中level分别为[0-4]代表个人公开赛、个人密码赛、团队公开赛和团队密码赛。</br>
        /// <br>type字段永远对1</br>
        /// <br>mode字段为多个设置项xor后的值</br>
        /// </returns>
        public static async Task<ContestDetails> GetContestAsync(Session session, int cid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/{cid}/info/");
            return JsonConvert.DeserializeObject<ContestDetails>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队比赛排行榜数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="cid">比赛ID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>
        /// <br>cetegory为类型列表，包含题目类型字符串，“1”->"10"分别代表WEB->实战。</br>
        /// <br>point为分数字段，键为题目PID，值为题目当前分数。</br>
        /// <br>problems为题目详细信息列表，分别为PID，解题数，题目名。</br>
        /// <br>top3为前3血字典，键为题目PID，值为前三血用户UID字符串列表。</br>
        /// </returns>
        public static async Task<Models.Contest.RankList> GetContestRankListAsync(Session session, int cid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/{cid}/rank/list/{page}/{size}/");
            return new Models.Contest.RankList(JsonConvert.DeserializeObject<Models.Contest.RankListRaw>(apiMessageResult?.Data.ToString()));
        }
        /// <summary>
        /// 获取战队成员列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回内容中role为用户角色，其中[0,1,2]分别代表[成员，管理员，队长]</returns>
        public static async Task<MemberList>? GetUserListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/user/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<MemberList>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队申请列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回战队申请列表</returns>
        public static async Task<ApplyUserList>? GetUserApplyListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/user/apply/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ApplyUserList>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取战队使用情况
        /// </summary>
        /// <param name="session">会话</param>
        /// <returns>返回战队使用情况</returns>
        public static async Task<AnalysisUse> GetAnalysisUse(Session session)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/analysis/use/");
            return JsonConvert.DeserializeObject<AnalysisUse>(apiMessageResult?.Data.ToString());
        }
    }
}