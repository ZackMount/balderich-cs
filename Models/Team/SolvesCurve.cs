namespace Balderich.Models.Team
{
    /// <summary>
    /// 解题曲线数据
    /// </summary>
    public class AnalysisSolvesCurve
    {
        /// <summary>
        /// 用户UID
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 解题曲线数据
        /// </summary>
        public int[]? Curve {  get; set; } 
    }
}
