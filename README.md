# Balderich-CS



## 关于

### 说明

- [NSSCTF](https://www.nssctf.cn/)平台API 原生异步实现的.NET SDK。（平台API文档 --> [API | NSSCTF](https://www.nssctf.cn/user/range/api)）



## 使用

### 示例

- 引入包

  ```c#
  using Balderich;
  ```
  
- 创建Client

  ```c#
  Client client = new("your_key", "your_secret", DateTime.Now);
  ```

- 根据不同模块发送Api请求

  ```c#
  //用户模块:获取用户个人信息
  var userInfo = client.User.GetInfoAsync("Xenny");
  //题目模块:获取题单题目列表
  var problemInfo = client.Problem.GetSheetProblemListAsync(1, 1, 10);
  //比赛模块:获取比赛排行榜数据
  var contestRankList = client.Contest.GetRankListAsync(1, 10);
  //战队模块:获取战队申请列表
  var teamApplyList = client.Team.GetUserApplyListAsync(1, 10);
  ```

### 异常处理

- 暂时没有统一做异常处理，统一抛直接异常码，建议自行捕获处理。



## 特别鸣谢

[Xenny](https://github.com/X3NNY)

[Nyr4ki](https://github.com/Nyr4ki)
