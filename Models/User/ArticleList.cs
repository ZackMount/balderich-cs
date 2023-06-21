using System.Collections.Generic;

namespace Balderich.Models
{
    public class ArticleData
    {
        /// <summary>
        /// 文章数据
        /// </summary>
        public Dictionary<int, Article> Articles { get; set; }
        /// <summary>
        /// 文章总数
        /// </summary>
        public int Total { get; set; }
    }

    public class Article
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 文章上传日期
        /// </summary>
        public int Date { get; set; }

        /// <summary>
        /// 文章种类ID
        /// </summary>
        public int Type { get; set; }
    }
}
