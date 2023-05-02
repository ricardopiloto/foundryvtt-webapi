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
                string filepath = $"{GetFileInfo.Location(world)}{world}/journal.db";
    
                // adjust the string (file) to properly read it as a json
                if (File.Exists(filepath))
                {
                    return (GetFileInfo.AdjustFileToJson(filepath));
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