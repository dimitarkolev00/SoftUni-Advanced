using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> vloggerWithHisFollowers = new Dictionary<string, HashSet<string>>();

            Dictionary<string, HashSet<string>> vloggerWithHisFollowings = new Dictionary<string, HashSet<string>>();

            string command;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                ProcessInput(vloggerWithHisFollowers, vloggerWithHisFollowings);
            }

            vloggerWithHisFollowers = vloggerWithHisFollowers.OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => vloggerWithHisFollowings[kvp.Key].Count)
                .ToDictionary(a => a.Key, b => b.Value);
            int cnt = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggerWithHisFollowings.Count} vloggers in its logs.");

            var mostFamousVlogger = vloggerWithHisFollowers.First();
            string mostFamousVloggerName = mostFamousVlogger.Key;

            HashSet<string> mostFamousVloggerFoolowers = mostFamousVlogger.Value.OrderBy(n => n).ToHashSet();

            Console.WriteLine($"{cnt++}. {mostFamousVloggerName} : {mostFamousVloggerFoolowers.Count} followers, " +
                $"{vloggerWithHisFollowings[mostFamousVloggerName].Count} following");

            foreach (var follower in mostFamousVloggerFoolowers)
            {
                Console.WriteLine($"*  {follower}");
            }

            foreach (var vloggerFollowersPair in vloggerWithHisFollowers.Skip(1))
            {
                string name = vloggerFollowersPair.Key;
                HashSet<string> followers = vloggerFollowersPair.Value;
                Console.WriteLine($"{cnt++}. {name} : {followers.Count} followers, {vloggerWithHisFollowings[name].Count} following");
            }
        }
        private static void ProcessInput(Dictionary<string, HashSet<string>> vloggerWithHisFollowers, Dictionary<string, HashSet<string>> vloggerWithHisFollowings)
        {
            string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string cmdType = commandArgs[1];
            if (cmdType == "joined")
            {
                JoinVlogger(vloggerWithHisFollowers, vloggerWithHisFollowings, commandArgs);
            }
            else if (cmdType == "followed")
            {
                Follow(vloggerWithHisFollowers, vloggerWithHisFollowings, commandArgs);
            }
        }

        private static void Follow(Dictionary<string, HashSet<string>> vloggerWithHisFollowers, Dictionary<string, HashSet<string>> vloggerWithHisFollowings, string[] commandArgs)
        {
            string follower = commandArgs[0];
            string toBeFollowed = commandArgs[2];

            if (follower != toBeFollowed)
            {
                if (vloggerWithHisFollowings.ContainsKey(follower) &&
                    vloggerWithHisFollowers.ContainsKey(toBeFollowed))
                {
                    vloggerWithHisFollowings[follower].Add(toBeFollowed);
                    vloggerWithHisFollowers[toBeFollowed].Add(follower);
                }
            }
        }

        private static void JoinVlogger(Dictionary<string, HashSet<string>> vloggerWithHisFollowers, Dictionary<string, HashSet<string>> vloggerWithHisFollowings, string[] commandArgs)
        {
            string vloggerToJoin = commandArgs[0];
            if (!vloggerWithHisFollowers.ContainsKey(vloggerToJoin))
            {
                vloggerWithHisFollowers[vloggerToJoin] = new HashSet<string>();
                vloggerWithHisFollowings[vloggerToJoin] = new HashSet<string>();
            }
        }
    }
}
