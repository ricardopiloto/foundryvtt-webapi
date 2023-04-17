using FoundryWebAPI.Models;
using Newtonsoft.Json;

namespace FoundryWebAPI.Services
{
    public class ReadJournalDb
    {
        public static string JournalFile(string world)
        {
            // string filepath = "/home/ubuntu/.local/share/FoundryVTT/Data/worlds/" + world + "/data";
            // test with localfile
            string filepath = "/home/ricardosobral/Downloads/journal.db";

            // adjust the string (file) to properly read it as a json
            var rawText = "[" + File.ReadAllText(@filepath).Replace("}\n{", "}\n,{") + "]";
            return (rawText);
        }
    }
}