using Balderich.Api;
using Balderich.Utils;


Session session = new("your_key", "you_secret");

var result = User.GetUserInfoAsync(session, "Xenny");

