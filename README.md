# Balderich-CS



## 关于

### 说明

- [NSSCTF](https://www.nssctf.cn/)平台API 原生异步实现的.NET SDK。（平台API文档 --> [API | NSSCTF](https://www.nssctf.cn/user/range/api)）



## 使用

### 示例

- 引入包

  ```c#
  using Balderich.Api;
  using Balderich.Utils;
  ```

- 创建Session

  ```c#
  Session session = new("your_key", "your_secret", DateTime.Now);
  ```

- 根据不同模块发送Api请求

  ```c#
  //用户模块:获取用户个人信息
  var userinfo = User.GetInfoAsync(session, Xenny);
  ```

### 异常处理

- 暂时没有统一做异常处理，统一抛异常处理，建议自己捕获处理（



## 特别鸣谢

#### Xenny
