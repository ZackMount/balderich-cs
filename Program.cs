using Balderich.Api;
using Balderich.Utils;


Session session = new("your_key", "your_secret");


//user info here.
var result = User.GetUserInfoAsync(session, "Xenny");

