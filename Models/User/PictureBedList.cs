﻿using Newtonsoft.Json;

namespace Balderich.Models.User
{
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
