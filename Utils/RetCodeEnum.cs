namespace Balderich.Utils
{
    public enum RetCode
    {
        /// <summary>
        /// 认证正常，返回数据
        /// </summary>
        SUCCESS = 10000,
        /// <summary>
        /// 认证字段为空或缺失
        /// </summary>
        AUTH_NONE = 10001,
        /// <summary>
        /// 不存在的API Key
        /// </summary>
        AUTH_NOT_EXIST = 10002,
        /// <summary>
        /// 认证签名错误
        /// </summary>
        AUTH_ERROR_SIGN = 10003,
        /// <summary>
        /// 该请求已过期（time超时）
        /// </summary>
        AUTH_TIMEOUT = 10004,
        /// <summary>
        /// 签名计算异常
        /// </summary>
        AUTH_CALC_ERROR = 10005,
        /// <summary>
        /// 签名计算异常
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
        /// 用户未开放关注列表
        /// </summary>
        USER_CLOSE_FOLLOW = 11002,
        /// <summary>
        /// 上传图片为空
        /// </summary>
        USER_IMAGE_NONE = 11003,
        /// <summary>
        /// 上传图片格式不为PNG、JPEG或GIF
        /// </summary>
        USER_IMAGE_FORMAT_ERROR = 11004,
        /// <summary>
        /// 上传图片解析错误
        /// </summary>
        USER_IMAGE_OPEN_ERROR = 11005,
        /// <summary>
        /// 用户可用空间不足
        /// </summary>
        USER_MEMORY_NOT_ENOUGH = 11006,
        /// <summary>
        /// 图床图片不存在或非当前用户上传
        /// </summary>
        USER_IMAGE_NOT_EXIST = 11007,
        /// <summary>
        /// 题目不存在
        /// </summary>
        PROBLEM_NOT_EXIST = 12001,
        /// <summary>
        /// 题目无权访问
        /// </summary>
        PROBLEM_PEMISSION_DENIED = 12002,
        /// <summary>
        /// 题单不存在
        /// </summary>
        PROBLEM_SHEET_NOT_EXIST = 12101,
        /// <summary>
        /// 题单无权访问
        /// </summary>
        PROBLEM_SHEET_PEMISSION_DENIED = 12102,
        /// <summary>
        /// 比赛不存在
        /// </summary>
        CONTEST_NOT_EXIST = 13001,
        /// <summary>
        /// 比赛无权访问
        /// </summary>
        CONTEST_PERMISSION_DENIED = 13002,
        /// <summary>
        /// 战队不存在
        /// </summary>
        TEAM_NOT_EXIST = 14001,
        /// <summary>
        /// 战队无权访问
        /// </summary>
        TEAM_PERMISSION_DENIED = 14002,
        /// <summary>
        /// 未加入任何战队
        /// </summary>
        TEAM_NO_MEMBER = 14003,
        /// <summary>
        /// 无权访问此功能
        /// </summary>
        TEAM_METHOD_PERMISSION_DENIED = 14004,
        /// <summary>
        /// 战队题目不存在
        /// </summary>
        TEAM_PROBLEM_NOT_EXIST = 14101,
        /// <summary>
        /// 战队题目无权访问
        /// </summary>
        TEAM_PROBELM_PERMISSION_DENIED = 14102,
        /// <summary>
        /// 战队比赛不存在
        /// </summary>
        TEAM_CONTEST_NOT_EXIST = 14201,
        /// <summary>
        /// 战队比赛无权访问
        /// </summary>
        TEAM_CONTEST_PERMISSION_DENIED = 142020 
    }
}
