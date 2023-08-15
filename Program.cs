using Balderich;

//Usage here.
Client client = new("your_key", "your_secret", DateTime.Now);

var userInfo = client.User.GetInfoAsync("Xenny").Result;
Console.WriteLine(userInfo?.Bio);
Console.WriteLine(userInfo?.Email);