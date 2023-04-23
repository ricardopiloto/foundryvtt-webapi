
using FoundryWebAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FoundryWebAPI.Services
{
    public class WorldService
    {
        public static string GetWorlds()
        {
            // string path = "/home/ubuntu/.local/share/FoundryVTT/Data/worlds/";
            string path = $"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/";
            var list = new List<Worlds>();
            // string path = "/home/ricardosobral/Documents/";

            foreach (var directory in Directory.GetDirectories(path))
            {
                string dirName = new DirectoryInfo(directory).Name;
                list.Add(new Worlds()
                {
                    Path = directory,
                    World = dirName
                });
            }
            var json = JsonConvert.SerializeObject(list);
            return (json);
        }
    }
}