using Balderich.Api;
using Balderich.Utils;

namespace Balderich
{
    public class Client
    {
        private readonly Session Session;
        public User User;
        public Team Team;
        public Problem Problem;
        public Contest Contest;
        public Client(string Key, string Secret, DateTime dateTime) 
        {
            Session = new(Key, Secret, dateTime);
            User = new(Session);
            Team = new(Session);
            Problem = new(Session);
            Contest = new(Session);
        }
    }
}
