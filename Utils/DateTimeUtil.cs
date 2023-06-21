namespace Balderich.Utils
{
    public static class DateTimeUtil
    {
        /// <summary>
        /// 获取1970年的时间
        /// </summary>
        private static DateTime timeStampStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        /// <summary>
        /// 生成十位时间戳
        /// </summary>
        /// <param name="dateTime">现在的时间</param>
        /// <returns></returns>
        public static long DateTimeToTimeStamp(DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - timeStampStartTime).TotalSeconds;
        }
        /// <summary>
        /// 生成十三位时间戳
        /// </summary>
        /// <param name="dateTime">现在的时间</param>
        /// <returns></returns>
        public static long DateTimeToLongTimeStamp(DateTime dateTime)
        {
            return (long)(dateTime.ToUniversalTime() - timeStampStartTime).TotalMilliseconds;
        }
    }
}
