
using FoundryWebAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FoundryWebAPI.Services
{
    public class ReadWorlds
    {
        public static string GetWorlds(){
            // string path = "/home/ubuntu/.local/share/FoundryVTT/Data/worlds/";
            var list = new List<Worlds>();
            string path = "/home/ricardosobral/Documents/";
            
            string[] directories = Directory.GetDirectories(path);
            foreach(string foldername in directories)
            {
                list.Add(new Worlds(){Name = foldername});
            }
            
            var json = JsonConvert.SerializeObject(list);
            return (json);
        }
    }
}