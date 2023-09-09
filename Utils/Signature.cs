using System.Security.Cryptography;
using System.Text;

namespace Balderich.Utils
{ 
    public class Signature
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
        public Signature(string Path, string Key, long Datatime, string Secret)
        {
            this.Path = Path;
            this.Key = Key;
            this.Secret = Secret; 
            this.SignTime = Datatime;
        }
        /// <summary>
        /// 签名计算
        /// </summary>
        /// <returns></returns>
        public string Calculator()
        {
            return EncryptBySHA256($"/v2/api/{Path}#{Key}#{SignTime}#{Secret}");
        }
        private string EncryptBySHA256(string text)
        {
            var bs = SHA256.HashData(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(bs).Replace("-", "").ToLower();
        }
    }
}
