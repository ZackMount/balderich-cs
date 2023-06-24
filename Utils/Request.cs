﻿using Balderich.Api;
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
        public static async Task<ApiMessageResult> GetAsync(Session session, string path)
        {
            var signatureClass = new SignatureClass($"/v2/api/{path}", session.Key, DateTimeUtil.DateTimeToTimeStamp(DateTime.Now), session.Secret);
            var signature = Signature.Calculator(signatureClass);
            var getUrl = $"https://www.nssctf.cn/v2/api/{path}?key={session.Key}&time={signatureClass.SignTime}&sign={signature}";
            var content = await HttpGetAsync(getUrl);
            try
            {
                var result = Parse(content);
                AssertSuccess((RetCode)result.Code);
                return result;
            }
            catch (ArgumentException ex)
                 {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static async Task<ApiMessageResult> PostAsync(Session session, string path, HttpContent? content)
        {
            var signatureClass = new SignatureClass($"/v2/api/{path}", session.Key, DateTimeUtil.DateTimeToTimeStamp(DateTime.Now), session.Secret);
            var signature = Signature.Calculator(signatureClass);
            var postUrl = $"https://www.nssctf.cn/v2/api/{path}?key={session.Key}&time={signatureClass.SignTime}&sign={signature}";
            var apiMessageResult = await HttpPostAsync(postUrl, content);
            try
            {
                var result = Parse(apiMessageResult);
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
        private static async Task<string?> HttpGetAsync(string url, int timeout = 10)
        {
            using var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(timeout);
            var content = await client.GetAsync(url);
            var result = content.Content.ReadAsStream().ToString();
            return result;
        }
        public static async Task<string?> HttpPostAsync(string url, HttpContent? content)
        {
            try
            {
                string responseContent = "";
                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    responseContent = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception($"POST Failure. Statue Code：{response.StatusCode}, Reason：{response.ReasonPhrase}");
                }

                return responseContent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

