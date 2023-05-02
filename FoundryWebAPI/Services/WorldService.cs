
using FoundryWebAPI.Models;
using Newtonsoft.Json;

namespace FoundryWebAPI.Services
{
    public class WorldService
    {
        public static string GetWorlds()
        {
            try
            {
                // string path = $"/mnt/worlds";
                string path = $"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/";
                var list = new List<Worlds>();
    
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
            catch (System.Exception e)
            {
                
                return (e.ToString());
            }
        }
    }
}