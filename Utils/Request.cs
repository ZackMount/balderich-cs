using Balderich.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Balderich.Utils
{
    public class Request
    {
        /// <summary>
        /// GET请求
        /// </summary>
        /// <param name="session"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static async Task<ApiMessageResult> GetAsync(Session session, string path)
        {
            var signatureClass = new SignatureClass($"/v2/api/{path}", session.Key, DateTimeUtil.DateTimeToTimeStamp(DateTime.Now), session.Secret);
            var signature = Signature.Calculator(signatureClass);
            var getUrl = $"https://www.nssctf.cn/v2/api/{path}?key={session.Key}&time={signatureClass.SignTime}&sign={signature}";
            var content = await HttpGetAsync(getUrl);

            var result = Parse(content);
            try
            {
                AssertSuccess((RetCode)result.Code);
                return result;
            }
            catch (ArgumentException ex)
                 {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        private static void AssertSuccess(RetCode code)
        {
            if (!Enum.IsDefined(typeof(RetCode), code))
            {
                throw new InvalidEnumArgumentException(nameof(code), (int)code, typeof(RetCode));
            }
            if (code != RetCode.SUCCESS)
            {
                throw new ArgumentOutOfRangeException(nameof(code), code, "The code is not success.");
            }
        }
        private static async Task<string> HttpGetAsync(string url)
        {
            using var client = new HttpClient();
            string content = await client.GetStringAsync(url);
            return content;
        }
        private static async Task<string> HttpPostAsync(string url, string data)
        {
            using var client = new HttpClient();
            using var content = new StringContent(data, Encoding.UTF8);
            var response = await client.PostAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
        private static ApiMessageResult? Parse(string content)
        {
            var obj = JObject.Parse(content);
            var code = (int)obj["code"];
            var data = obj["data"];
            if (data != null)
            {
                if (data is JObject)
                {
                    return new ApiMessageResult(code, (JObject)data);
                }
                else if (data is JArray)
                {
                    return new ApiMessageResult(code, (JArray)data);
                }
            }
            return null;
        }
    }
}

