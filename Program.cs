using Balderich.Api;
using Balderich.Models.User;
using Balderich.Utils;
using Newtonsoft.Json;

Session session = new("your_key", "your_secret");

var info = User.GetInfoAsync(session, "Xenny").Result; //user info here.

