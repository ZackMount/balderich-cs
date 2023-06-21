namespace Balderich.Utils
{
    public  class SignatureClass
    {
        /// <summary>
        /// 请求路径
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 请求Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public long SignTime { get; set; }
        /// <summary>
        /// 请求Secret
        /// </summary>
        public string Secret { get; set; }
        public SignatureClass(string path, string key, long datatime, string secret)
        {
            Path = path;
            Key = key;
            SignTime = datatime;
            Secret = secret;
        }
    }
}
