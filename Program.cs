using Balderich.Api;
using Balderich.Utils;


Session session = new("1ff8125b2bf6c14a9cbd", "0f901a8581cef61960f35a559b6b69592dabbb35", DateTime.Now);
int[] uids = { 3388 };
Team.GetStatisticsDay(session);
Problem.GetSheetProblemListAsync(session, 1, 1, 15);
Contest.GetRankListAsync(session, 1, 10);