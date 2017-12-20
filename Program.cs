using System;
using System.Collections.Generic;
using MySportsFeedsApi;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace api_test
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory loggerFactory = new LoggerFactory()
                .AddConsole()
                .AddDebug();
            ILogger logger = loggerFactory.CreateLogger<Program>();
            MySportsFeeds.Username = "lexm";
            MySportsFeeds.Password = "60yCVctFMRXg";

            //Task<string> getStats = MySportsFeeds.FetchFeedAsync("nfl", "2016-2017-regular", "full_game_schedule");
            //string result = getStats.Result;
            //logger.LogInformation("This is a message");
            //var sched = JsonConvert.DeserializeObject<FullGameSchedule>(result);
            //GameSchedule gameSchedule = sched.fullgameschedule;
            //List<GameEntry> gameentry = gameSchedule.gameentry;
            //GameEntry entry1 = gameentry[0];
            //logger.LogInformation("stats: {0}", JsonConvert.SerializeObject(entry1));

            Task<string> getStats = MySportsFeeds.FetchFeedAsync("nfl", "2016-regular", "active_players");
            string result = getStats.Result;
            //logger.LogInformation("This is a message");
            var players = JsonConvert.DeserializeObject<ActivePlayers>(result);
            ActivePlayerList playerList = players.activeplayers;
            List<Playerentry> playerentry = playerList.playerentry;
            Playerentry entry1 = playerentry[0];
            logger.LogInformation("player1: {0}", JsonConvert.SerializeObject(entry1));

            //GameSchedule gameSchedule = sched.fullgameschedule;
            //List<GameEntry> gameentry = gameSchedule.gameentry;
            //GameEntry entry1 = gameentry[0];
            //logger.LogInformation("stats: {0}", JsonConvert.SerializeObject(entry1));

            //Dictionary<string, string> Params = new Dictionary<string, string>();
            //Params.Add("fordate", "20161118");
            //Params.Add("player", "7861");
            //Task<string> getPlayerStats = MySportsFeeds.FetchFeedAsync("nfl", "2016-regular", "cumulative_player_stats");
            //string result = getPlayerStats.Result;
            //logger.LogInformation("result: {0}", result);
            //var sched = JsonConvert.DeserializeObject<CumulativePlayerStats>(result);
            //logger.LogInformation("stats: {0}", JsonConvert.SerializeObject(sched));
        }
    }
}
