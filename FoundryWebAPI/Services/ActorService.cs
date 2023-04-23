using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Repositories
{
    public class ActorService
    {
        public static string ActorFile(string world)
        {
            // string filepath = $"/home/ubuntu/.local/share/FoundryVTT/Data/worlds/{world}/data/actors.db";
            string filepath = $"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/{world}/data/actors.db";
            // test with localfile
            // string filepath = "/home/ricardosobral/Downloads/journal.db";

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
    }
}