
using FoundryWebAPI.Helpers;
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
                string path = $"{GetFileInfo.Location(null)}";
                var list = new List<WorldsModel>();
    
                foreach (var directory in Directory.GetDirectories(path))
                {
                    string dirName = new DirectoryInfo(directory).Name;
                    string worldFile = $"{path}{dirName}/world.json";
                    var jsonObj = JsonConvert.DeserializeObject<WorldsModel>(File.ReadAllText(worldFile));
                    list.Add(new WorldsModel()
                    {
                        Id = jsonObj.Id,
                        Title = jsonObj.Title,
                        Background = jsonObj.Background,
                        Description = jsonObj.Description,
                        System = jsonObj.System,
                        Version = jsonObj.Version,
                        CoreVersion = jsonObj.CoreVersion,
                        ResetKeys = jsonObj.ResetKeys,
                        SafeMode = jsonObj.SafeMode,
                        SystemVersion = jsonObj.SystemVersion
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