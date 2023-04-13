using Newtonsoft.Json;

namespace FoundryWebAPI.Services
{
    public class ReadJournalDb
    {
        public static object JournalFile()
        {
            var rawText = "[" + File.ReadAllText(@"/home/ricardosobral/Downloads/journal.db").Replace("}\n{", "}\n,{") + "]";
            if (rawText != null)
            {
                dynamic obj = JsonConvert.DeserializeObject(rawText);
                return (obj);
            }
            else
            {
                return (null);
            }

            // return ("");
        }
        // public static object ParseObj(string data)
        // {
        //     string[] name = new string[] { };
        //     string[] folder = new string[] { };
        //     string[] id = new string[] { };

        //     if (data != null)
        //     {
        //         dynamic obj = JsonConvert.DeserializeObject(data);

        //         for (int i = 0; i <= obj?.Count(); i++)
        //         {
        //             name[i] = obj[i].name;
        //             folder[i] = obj[i].folder;
        //             id[i] = obj[i]._id;
        //         }
        //         return (name, folder, id);
        //     }
        //     else
        //     {
        //         return ("File is empty!");
        //     }

        // }
    }
}