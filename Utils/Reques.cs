using Balderich.Api;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace Balderich.Utils
{
    public class Request
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://www.nssctf.cn/v2/api";

        public static async Task<ApiMessageResult> GetAsync(Session session, string path)
            => await SendRequestAsync(session, path, HttpMethod.Get);

        public static async Task<ApiMessageResult> PostAsync(Session session, string path, HttpContent? content)
            => await SendRequestAsync(session, path, HttpMethod.Post, content);

        public static async Task<ApiMessageResult> PutAsync(Session session, string path, HttpContent? content)
            => await SendRequestAsync(session, path, HttpMethod.Put, content);

        private static async Task<ApiMessageResult> SendRequestAsync(Session session, string path, HttpMethod method, HttpContent? content = null)
        {
            var signatureClass = new SignatureClass(path, session.Key, DateTimeUtil.DateTimeToTimeStamp(session.DateTime), session.Secret);
            var signature = Signature.Calculator(signatureClass);
            var url = $"{BaseUrl}/{path}?key={session.Key}&time={signatureClass.SignTime}&sign={signature}";

            var httpResponse = method switch
            {
                _ when method == HttpMethod.Get => client.GetAsync(url).Result,
                _ when method == HttpMethod.Post => client.PostAsync(url, content).Result,
                _ when method == HttpMethod.Put => client.PutAsync(url, content).Result,
                _ => throw new NotSupportedException($"Method {method} not supported"),
            };

            var resultContent = await httpResponse.Content.ReadAsStringAsync();
            var result = Parse(resultContent);

            AssertSuccess((RetCode)result.Code);
            return result;
        }

        private static void AssertSuccess(RetCode code)
        {
            if (!Enum.IsDefined(typeof(RetCode), code))
                throw new InvalidEnumArgumentException(nameof(code), (int)code, typeof(RetCode));

            if (code != RetCode.SUCCESS)
                throw new Exception(Enum.GetName(code));
        }

        private static ApiMessageResult Parse(string content)
        {
            var obj = JObject.Parse(content);
            var code = (int)obj["code"];
            var data = obj["data"];

            return data switch
            {
                JObject jobject => new ApiMessageResult(code, jobject),
                JArray jarray => new ApiMessageResult(code, jarray),
                _ => new ApiMessageResult(code, null),
            };
        }
    }
}
