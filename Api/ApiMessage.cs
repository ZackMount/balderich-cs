using Balderich.Models;
using Balderich.Models.User;
using Balderich.Utils;
using balderich_cs.Models.User;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace Balderich.Api
{
    public static class User
    {
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="name">用户名或用户UID。相同的路径数据缓存10分钟。</param>
        /// <returns>用户个人信息字段</returns>
        public static async Task<Info?> GetUserInfoAsync(Session session, string name)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{name}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取用户解题活跃数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID。相同的路径数据缓存60分钟。</param>
        /// <returns>从当年1月1日至当天的每日解题数据。</returns>
        public static async Task<StatisticsActive?> GetUserStatisticsActiveAsync(Session session, int uid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/statistics/active/");
            return new StatisticsActive(JsonConvert.DeserializeObject<StatisticsActiveInput>(apiMessageResult?.Data.ToString()));
        }
        /// <summary>
        /// 获取用户解题曲线
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID。相同的路径数据缓存60分钟。</param>
        /// <returns>分类返回用户解题时间时间戳数据。</returns>
        public static async Task<List<StatisticsSolves>?> GetUserStatisticsSolvesAsync(Session session, int uid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/statistics/solves/");
            var jobj = new JObject();
            jobj["data"] = apiMessageResult.Data;
            var result = JsonConvert.DeserializeObject<StatisticsSolvesRoot>(jobj.ToString());
            return result?.Solves;
            
        }
        /// <summary>
        /// 获取用户积分曲线
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID。相同的路径数据缓存60分钟。</param>
        /// <returns>返回用户参加的每场比赛排名以及积分变动数据。</returns>
        public static async Task<List<StatisticsRating>?> GetUserStatisticsRatingAsync(Session session, int uid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/statistics/rating/");
            var jobj = new JObject();
            jobj["data"] = apiMessageResult.Data;
            var result = JsonConvert.DeserializeObject<StatisticsRatingRoot>(jobj.ToString());
            return result?.Ratings;
        }
        /// <summary>
        /// 获取用户能力雷达图数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID。相同的路径数据缓存60分钟。</param>
        /// <returns>返回一个列表，包含用户各方向解题数据，其中一共六项，分别代表WEB、PWN、REVERSE、CRYPTO、MISC、OTHER方向解题数据，每项数据都为[解题数, 总题数]的列表</returns>
        public static async Task<StatisticsRadar?> GetUserStatisticsRadarAsync(Session session, int uid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/statistics/radar/");
            StatisticsRadar statisticsRadar = new();
            statisticsRadar.RadarData = apiMessageResult.Data.ToObject<List<List<int>>>();
            return statisticsRadar;
        }
        /// <summary>
        /// 获取用户文章列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回指定页的文章数据和文章总数，文章数据按照文章ID排降序。</returns>
        public static async Task<ArticleList?> GetUserArticleListAsync(Session session, int uid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/article/list/{page}/{size}/");
            return JsonConvert.DeserializeObject<ArticleList>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取用户关注列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回指定页的关注列表数据，数据按照关注时间排降序。</returns>
        public static async Task<List<Following>?> GetUserFollowingListAsync(Session session, int uid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/following/list/{page}/{size}/");
            var jobj = new JObject();
            jobj["data"] = apiMessageResult.Data;
            var result = JsonConvert.DeserializeObject<FollowingList>(jobj.ToString());
            return result?.Followings;
        }
        /// <summary>
        /// 获取用户粉丝列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回指定页的粉丝列表数据，数据按照关注时间排降序。</returns>
        public static async Task<List<Follower>?> GetUserFollowerListAsync(Session session, int uid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/follower/list/{page}/{size}/");
            var jobj = new JObject();
            jobj["data"] = apiMessageResult.Data;
            var result = JsonConvert.DeserializeObject<FollowerList>(jobj.ToString());
            return result?.Followers;
        }
    }
}
