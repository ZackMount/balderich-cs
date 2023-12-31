﻿using Balderich.Models.Team;
using Balderich.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Balderich.Api
{
    /// <summary>
    /// 团队模块
    /// </summary>
    public partial class Team
    {
        public Team(Session session) 
        {
            this.session = session;
        }
        private readonly Session session;
        /// <summary>
        /// 获取战队列表
        /// </summary>
        /// <param name="page">战队列表</param>
        /// <param name="size">每页大小</param>
        /// <returns>战队列表</returns>
        public async Task<List?> GetListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<List>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队详细信息
        /// </summary>
        /// <param name="tid">团队ID</param>
        /// <returns>战队详细信息</returns>
        public async Task<Info?> GetInfoAsync(int tid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/{tid}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队通知信息
        /// </summary>
        /// <returns>战队通知信息</returns>
        public async Task<string> GetNoticeAsync()
        {
            var apiMessageResult = await Request.GetAsync(session, "team/notice/");
            return apiMessageResult?.Data?["notice"] ?? "";
        }
        /// <summary>
        /// 战队每日打卡
        /// </summary>
        /// <returns>打卡信息</returns>
        public async Task<ClockIn> ClockinAsync()
        {
            var apiMessageResult = await Request.GetAsync(session, "team/clockin/");
            return JsonConvert.DeserializeObject<ClockIn>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队题目列表
        /// </summary>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>战队题目列表</returns>
        public async Task<ProblemList> GetProblemListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/problem/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ProblemList>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队题目详细信息
        /// </summary>
        /// <param name="pid">题目ID</param>
        /// <returns>战队题目详细信息</returns>
        public async Task<ProblemInfo> GetProblemInfoAsync(int pid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/problem/{pid}/info/");
            return JsonConvert.DeserializeObject<ProblemInfo>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队比赛列表
        /// </summary>
        /// <param name="page">页数</param>
        /// <param name="size">会话</param>
        /// <returns>其中state的值从[0-2]，分别代表未开始、进行中和已结束。</returns>
        public async Task<ContestList> GetContestListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ContestList>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队比赛详细信息
        /// </summary>
        /// <param name="cid">比赛ID</param>
        /// <returns>
        /// <br>其中level分别为[0-4]代表个人公开赛、个人密码赛、团队公开赛和团队密码赛。</br>
        /// <br>type字段永远对1</br>
        /// <br>mode字段为多个设置项xor后的值</br>
        /// </returns>
        public async Task<ContestDetails> GetContestAsync(int cid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/{cid}/info/");
            return JsonConvert.DeserializeObject<ContestDetails>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队比赛排行榜数据
        /// </summary>
        /// <param name="cid">比赛ID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>
        /// <br>cetegory为类型列表，包含题目类型字符串，“1”->"10"分别代表WEB->实战。</br>
        /// <br>point为分数字段，键为题目PID，值为题目当前分数。</br>
        /// <br>problems为题目详细信息列表，分别为PID，解题数，题目名。</br>
        /// <br>top3为前3血字典，键为题目PID，值为前三血用户UID字符串列表。</br>
        /// </returns>
        public async Task<Models.Contest.RankList> GetContestRankListAsync(int cid, int page, int size)
        {
            //Didn't work...
            var apiMessageResult = await Request.GetAsync(session, $"team/contest/{cid}/rank/list/{page}/{size}/");

            return new Models.Contest.RankList(JsonConvert.DeserializeObject<Models.Contest.RankListRaw>(apiMessageResult?.Data?.ToString()));
        }
        /// <summary>
        /// 获取战队成员列表
        /// </summary>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回内容中role为用户角色，其中[0,1,2]分别代表[成员，管理员，队长]</returns>
        public async Task<MemberList>? GetUserListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/user/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<MemberList>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队申请列表
        /// </summary>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回战队申请列表</returns>
        public async Task<ApplyUserList>? GetUserApplyListAsync(int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/user/apply/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ApplyUserList>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队使用情况
        /// </summary>
        /// <returns>返回战队使用情况</returns>
        public async Task<AnalysisUse> GetAnalysisUse()
        {
            var apiMessageResult = await Request.GetAsync(session, $"team/analysis/use/");
            return JsonConvert.DeserializeObject<AnalysisUse>(apiMessageResult?.Data?.ToString());
        }
        /// <summary>
        /// 获取战队解题曲线数据
        /// </summary>
        /// <param name="uids">成员UID</param>
        /// <returns>返回成员解题曲线数据</returns>
        public async Task<List<AnalysisSolvesCurve>> GetAnalysisSolvesCurve(int[] uids)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { uids }), Encoding.UTF8, "application/json");
            var apiMessageResult = await Request.PostAsync(session, $"team/analysis/solves/curve/", content);
            var solvesCurves = new List<AnalysisSolvesCurve>();
            foreach (var item in JObject.Parse(apiMessageResult.Data?.ToString()).Properties())
            {
                var sc = new AnalysisSolvesCurve
                {
                    Uid = int.Parse(item.Name),
                    Curve = item.Value.ToObject<int[]>()
                };
                solvesCurves.Add(sc);
            }
            return solvesCurves;
        }
        /// <summary>
        /// 获取战队每日解题数据
        /// </summary>
        /// <param name="uids">成员UID</param>
        /// <returns>返回成员当日内解题数据</returns>
        public async Task<List<StatisticsDay>> GetStatisticsDay(int[] uids)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { uids }), Encoding.UTF8, "application/json");
            var apiMessageResult = await Request.PostAsync(session, $"team/statistics/day/", content);
            var statistics = new List<StatisticsDay>();
            foreach (var item in JObject.Parse(apiMessageResult.Data?.ToString()).Properties())
            {
                var sc = item.Value.ToObject<StatisticsDay>();
                sc.Uid = int.Parse(item.Name);
                statistics.Add(sc);
            }
            return statistics;
        }
    }
}