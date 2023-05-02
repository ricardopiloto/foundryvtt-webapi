using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Repositories
{
    public class ActorService
    {
        public static string ActorFile(string world)
        {
            try
            {
                string filepath = $"{FileLocation.Location(world)}{world}/actors.db";
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