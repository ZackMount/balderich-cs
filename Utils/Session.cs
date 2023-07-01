namespace Balderich.Utils
{
    public class Session
    {
        /// <summary>
        /// 请求Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 请求Secret
        /// </summary>
        public string Secret { get; set; }
        /// <summary>
        /// 请求时间戳（不同请求在有效期内可反复提交，请勿在短时间内生成不同session造成鉴权过快）
        /// </summary>
        public DateTime DateTime { get; set; }
        public Session(string key, string secret, DateTime dateTime)
        {
            Key = key;
            Secret = secret;
            DateTime = dateTime;
        }
    }
}
