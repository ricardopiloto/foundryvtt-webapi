using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
// using System.Text.Json;

namespace FoundryWebAPI.Services
{
    public class ReadJournalDb
    {
        public static string JournalFile()
        {
            var rawText = "[" + File.ReadAllText(@"/home/ricardosobral/Downloads/journal.db").Replace("}\n{","}\n,{") + "]";
            dynamic obj = JsonConvert.DeserializeObject(rawText);
            return (obj);
        }
    }
}