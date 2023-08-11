using System.Security.Cryptography;
using System.Text;

namespace Balderich.Utils
{ 
    public static class Signature
    {
        /// <summary>
        /// 签名计算
        /// </summary>
        /// <param name="signatureClass"></param>
        /// <returns></returns>
        public static string Calculator(SignatureClass signatureClass)
        {
            return EncryptBySHA256($"/v2/api/{signatureClass.Path}#{signatureClass.Key}#{signatureClass.SignTime}#{signatureClass.Secret}");
        }
        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string EncryptBySHA256(string text)
        {
            var md5 = SHA256.Create();
            var bs = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            var sb = new StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
