using Balderich.Models.User;
using Balderich.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;

namespace Balderich.Api
{
    public static class User
    {
        /// <summary>
        /// 获取用户个人信息
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="name">用户名或用户UID</param>
        /// <returns>用户个人信息字段</returns>
        public static async Task<Info?> GetInfoAsync(Session session, string name)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{name}/info/");
            return JsonConvert.DeserializeObject<Info>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取用户解题活跃数据
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID</param>
        /// <returns>从当年1月1日至当天的每日解题数据。</returns>
        public static async Task<StatisticsActive?> GetStatisticsActiveAsync(Session session, int uid)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/statistics/active/");
            return new StatisticsActive(JsonConvert.DeserializeObject<StatisticsActiveInput>(apiMessageResult?.Data.ToString()));
        }
        /// <summary>
        /// 获取用户解题曲线
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="uid">用户UID</param>
        /// <returns>分类返回用户解题时间时间戳数据。</returns>
        public static async Task<List<StatisticsSolves>?> GetStatisticsSolvesAsync(Session session, int uid)
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
        /// <param name="uid">用户UID</param>
        /// <returns>返回用户参加的每场比赛排名以及积分变动数据。</returns>
        public static async Task<List<StatisticsRating>?> GetStatisticsRatingAsync(Session session, int uid)
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
        /// <param name="uid">用户UID</param>
        /// <returns>返回一个列表，包含用户各方向解题数据，其中一共六项，分别代表WEB、PWN、REVERSE、CRYPTO、MISC、OTHER方向解题数据，每项数据都为[解题数, 总题数]的列表</returns>
        public static async Task<StatisticsRadar?> GetStatisticsRadarAsync(Session session, int uid)
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
        public static async Task<ArticleList?> GetArticleListAsync(Session session, int uid, int page, int size)
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
        public static async Task<List<Following>?> GetFollowingListAsync(Session session, int uid, int page, int size)
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
        public static async Task<List<Follower>?> GetFollowerListAsync(Session session, int uid, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/{uid}/follower/list/{page}/{size}/");
            var jobj = new JObject();
            jobj["data"] = apiMessageResult.Data;
            var result = JsonConvert.DeserializeObject<FollowerList>(jobj.ToString());
            return result?.Followers;
        }
        /// <summary>
        /// 获取图床使用情况
        /// </summary>
        /// <param name="session">会话</param>
        /// <returns>返回图床使用情况。</returns>
        public static async Task<PictureBedUsed> GetPictureBedUsedAsync(Session session)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/picturebed/used/");
            return JsonConvert.DeserializeObject<PictureBedUsed>(apiMessageResult?.Data.ToString());
        }
        /// <summary>
        /// 获取图床列表
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="page">页数</param>
        /// <param name="size">每页大小</param>
        /// <returns>返回指定页的图床列表数据，数据按照id排降序。</returns>
        public static async Task<List<Picture>?> GetPictureBedListAsync(Session session, int page, int size)
        {
            var apiMessageResult = await Request.GetAsync(session, $"user/picturebed/list/{page}/{size}/");
            var result = JsonConvert.DeserializeObject<PictureBedList>(apiMessageResult?.Data.ToString());
            return result?.Picture;
        }
        /// <summary>
        /// 图床上传图片
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="imagePath">图片路径</param>
        /// <returns>上传成功返回图片信息，否则返回null。</returns>
        public static async Task<PictureBedUploadResponse?> UploadToPictureBedAsync(Session session, string imagePath)
        {
            byte[] imageData = File.ReadAllBytes(imagePath);
            string fileName = Path.GetFileName(imagePath);
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new ByteArrayContent(imageData), "image", fileName);
                var apiMessageResult = await Request.PostAsync(session, "user/picturebed/upload/", content);
                return JsonConvert.DeserializeObject<PictureBedUploadResponse>(apiMessageResult?.Data.ToString());
            }
        }
        /// <summary>
        /// 图床下载图片
        /// </summary>
        /// <param name="session">会话</param>
        /// <param name="pid">图片ID</param>
        /// <param name="savePath">图片保存路径，文件名从响应头中读取</param>
        /// <returns>成功返回true，失败抛出异常</returns>
        public static bool DownloadPicture(Session session, int pid, string savePath)
        {
            var path = $"user/picturebed/{pid}/download/";
            var signatureClass = new SignatureClass($"/v2/api/{path}", session.Key, DateTimeUtil.DateTimeToTimeStamp(DateTime.Now), session.Secret);
            var signature = Signature.Calculator(signatureClass);
            var postUrl = $"https://www.nssctf.cn/v2/api/{path}?key={session.Key}&time={signatureClass.SignTime}&sign={signature}";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync(postUrl, null).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                if (response.Content.Headers.Contains("Content-Disposition"))
                {
                    string contentDisposition = response.Content.Headers.GetValues("Content-Disposition").FirstOrDefault();
                    var match = new Regex("filename=\"(.*)\"").Match(contentDisposition);
                    if (match.Success)
                    {
                        string FileName = match.Groups[1].Value;
                        string filePath = Path.Combine(savePath, FileName);
                        byte[] imageData = response.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                        File.WriteAllBytes(filePath, imageData);
                        return true;
                    }
                    throw new Exception("Content-Disposition does not contain a 'filename' attribute.");
                }
                else
                {
                    throw new Exception("Response does not contain a 'Content-Disposition' header.");
                }
            }
            else
            {
                throw new Exception($"POST Failure. Statue Code：{response.StatusCode}, Reason：{response.ReasonPhrase}");
            }
        }
    }
}
