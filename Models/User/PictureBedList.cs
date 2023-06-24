using Newtonsoft.Json;

namespace Balderich.Models.User
{
    public class Picture
    {
        /// <summary>
        /// 图片编号
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 图片名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 图片上传时间时间戳
        /// </summary>
        [JsonProperty("date")]
        public int Date { get; set; }
        /// <summary>
        /// 图片大小（字节）
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
    /// <summary>
    /// 图床列表数据
    /// </summary>
    public class PictureBedList
    {
        /// <summary>
        /// 图片信息
        /// </summary>
        [JsonProperty("pictures")]
        public List<Picture> Pictures { get; set; }
        /// <summary>
        /// 图片数量总数
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }

}
