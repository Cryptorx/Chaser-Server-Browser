using StackExchange.Redis;
using System.Collections.Generic;

namespace Chaser_Server_Browsing.Query.Server_List
{
    class MasterList
    {
        public List<string> GetServers()
        {
            List<string> servers = new List<string>();
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("192.223.27.80:6379,allowAdmin=true");
            IServer server = redis.GetServer("192.223.27.80", 6379);
            foreach (string key in server.Keys(1, "*"))
            {
                var name = redis.GetDatabase(1);
                string data = name.StringGet(key);
                if (data.Contains(@"statechanged"":""2"))
                {
                    name.KeyDelete(key);
                }
                servers.Add(key);
            }
            return servers;
        }
    }
}
