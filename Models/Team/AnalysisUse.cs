using Newtonsoft.Json;

namespace Balderich.Models.Team
{
    public class AnalysisUseProblem
    {
        /// <summary>
        /// 现有题数
        /// </summary>
        [JsonProperty("now")]
        public int Now { get; set; }
        /// <summary>
        /// 最大题数
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class AnalysisUseContest
    {
        /// <summary>
        /// 现有比赛
        /// </summary>
        [JsonProperty("now")]
        public int Now { get; set; }
        /// <summary>
        /// 最大比赛
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class AnalysisUseMemory
    {
        /// <summary>
        /// 已用空间（MiB）
        /// </summary>
        [JsonProperty("now")]
        public float Now { get; set; }
        /// <summary>
        /// 最大空间（MiB）
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class AnalysisUsePerson
    {
        /// <summary>
        /// 现有人员
        /// </summary>
        [JsonProperty("now")]
        public int Now { get; set; }
        /// <summary>
        /// 最大人数
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }
    }

    public class AnalysisUse
    {
        /// <summary>
        /// 题目使用情况
        /// </summary>
        [JsonProperty("problem")] 
        public AnalysisUseProblem? Problem { get; set; }
        /// <summary>
        /// 比赛使用情况
        /// </summary>
        [JsonProperty("contest")] 
        public AnalysisUseContest? Contest { get; set; }
        /// <summary>
        /// 空间使用情况
        /// </summary>
        [JsonProperty("memory")]
        public AnalysisUseMemory? Memory { get; set; }
        /// <summary>
        /// 成员数量情况
        /// </summary>
        [JsonProperty("person")]
        public AnalysisUsePerson? Person { get; set; }
        /// <summary>
        /// 战队等级
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; set; }
        /// <summary>
        /// 战队属性
        /// </summary>
        [JsonProperty("state")]
        public int State { get; set; }
    }
}
