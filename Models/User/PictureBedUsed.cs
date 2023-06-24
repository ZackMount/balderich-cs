using Newtonsoft.Json;

namespace Balderich.Models.User
{
    /// <summary>
    /// 图床使用情况
    /// </summary>
    public class PictureBedUsed
    {
        /// <summary>
        /// 已使用空间（字节）
        /// </summary>
        [JsonProperty("used_mem")]
        public int UsedMem { get; set; }
        /// <summary>
        /// 最大空间（字节）
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        /// <summary>
        /// 图片数量总数
        /// </summary>
        [JsonProperty("max_mem")]
        public int MaxMem { get; set; }
    }

}
