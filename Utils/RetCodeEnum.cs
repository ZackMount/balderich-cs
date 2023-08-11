namespace Balderich.Utils
{
    public enum RetCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        SUCCESS = 10000,
        /// <summary>
        /// 无授权
        /// </summary>
        AUTH_NONE = 10001,
        /// <summary>
        /// 授权不存在
        /// </summary>
        AUTH_NOT_EXIST = 10002,
        /// <summary>
        /// 授权签名错误
        /// </summary>
        AUTH_ERROR_SIGN = 10003,
        /// <summary>
        /// 授权超时
        /// </summary>
        AUTH_TIMEOUT = 10004,
        /// <summary>
        /// 授权计算错误
        /// </summary>
        AUTH_CALC_ERROR = 10005,
        /// <summary>
        /// 请求过快
        /// </summary>
        AUTH_REQUEST_FAST = 10006,
        /// <summary>
        /// 请求参数无效
        /// </summary>
        REQUEST_PARAM_INVALID = 10007,
        /// <summary>
        /// 用户不存在
        /// </summary>
        USER_NOT_EXIST = 11001,
        /// <summary>
        /// 用户关闭了关注
        /// </summary>
        USER_CLOSE_FOLLOW = 11002,
        /// <summary>
        /// 用户图片不存在
        /// </summary>
        USER_IMAGE_NONE = 11003,
        /// <summary>
        /// 用户图片格式错误
        /// </summary>
        USER_IMAGE_FORMAT_ERROR = 11004,
        /// <summary>
        /// 用户图片打开错误
        /// </summary>
        USER_IMAGE_OPEN_ERROR = 11005,
        /// <summary>
        /// 用户内存不足
        /// </summary>
        USER_MEMORY_NOT_ENOUGH = 11006,
        /// <summary>
        /// 用户图片不存在
        /// </summary>
        USER_IMAGE_NOT_EXIST = 11007,
        /// <summary>
        /// 题目不存在
        /// </summary>
        PROBLEM_NOT_EXIST = 12001,
        /// <summary>
        /// 题目权限被拒绝
        /// </summary>
        PROBLEM_PEMISSION_DENIED = 12002,
        /// <summary>
        /// 题目单不存在
        /// </summary>
        PROBLEM_SHEET_NOT_EXIST = 12101,
        /// <summary>
        /// 题目单权限被拒绝
        /// </summary>
        PROBLEM_SHEET_PEMISSION_DENIED = 12102,
        /// <summary>
        /// 比赛不存在
        /// </summary>
        CONTEST_NOT_EXIST = 13001,
        /// <summary>
        /// 比赛权限被拒绝
        /// </summary>
        CONTEST_PERMISSION_DENIED = 13002,
        /// <summary>
        /// 团队不存在
        /// </summary>
        TEAM_NOT_EXIST = 14001,
        /// <summary>
        /// 团队权限被拒绝
        /// </summary>
        TEAM_PERMISSION_DENIED = 14002,
        /// <summary>
        /// 团队无成员
        /// </summary>
        TEAM_NO_MEMBER = 14003,
        /// <summary>
        /// 团队方法权限被拒绝
        /// </summary>
        TEAM_METHOD_PERMISSION_DENIED = 14004,
        /// <summary>
        /// 团队题目不存在
        /// </summary>
        TEAM_PROBLEM_NOT_EXIST = 14101,
        /// <summary>
        /// 团队题目权限被拒绝
        /// </summary>
        TEAM_PROBELM_PERMISSION_DENIED = 14102,
        /// <summary>
        /// 团队比赛不存在
        /// </summary>
        TEAM_CONTEST_NOT_EXIST = 14201,
        /// <summary>
        /// 团队比赛权限被拒绝
        /// </summary>
        TEAM_CONTEST_PERMISSION_DENIED = 142020 
    }
}
