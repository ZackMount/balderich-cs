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
        public Session(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }
    }
}
