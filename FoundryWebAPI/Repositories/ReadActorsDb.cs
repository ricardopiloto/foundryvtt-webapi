using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Repositories
{
    public class ReadActorsDB
    {
        public static string ActorFile(string world)
        {
            // string filepath = "/home/ubuntu/.local/share/FoundryVTT/Data/worlds/" + world + "/data/actors.db";
            // test with localfile
            string filepath = "/home/ricardosobral/Downloads/actors.db";

            // adjust the string (file) to properly read it as a json
            var rawText = "[" + File.ReadAllText(@filepath).Replace("}\n{", "}\n,{") + "]";
            return (rawText);
        }
    }
}