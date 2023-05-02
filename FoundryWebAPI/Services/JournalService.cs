using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;
using Newtonsoft.Json;

namespace FoundryWebAPI.Services
{
    public class JournalService
    {
        public static string JournalFile(string world)
        {
            try
            {
                string filepath = $"{FileLocation.Location(world)}{world}/journal.db";
    
                // adjust the string (file) to properly read it as a json
                if (File.Exists(filepath))
                {
                    var rawText = "[" + File.ReadAllText(@filepath).Replace("}\n{", "}\n,{") + "]";
                    return (rawText);
                }
                else
                {
                    return (null);
                }
            }
            catch (System.Exception e)
            {
                
                return (e.ToString());
            }
        }
    }
}