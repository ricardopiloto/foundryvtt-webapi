using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Helpers
{
    public class GetFileInfo
    {
        public static string Location(string world)
        {
            if (!String.IsNullOrEmpty(world))
            {
                // string filepath = $"/mnt/worlds/{world}/data/";
                // Testing with localfile
                string filepath = $"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/{world}/data/";
                return (filepath);
            }
            else
            {
                // string path = $"/mnt/worlds";
                // Testing with localfile
                string path = $"/home/ricardosobral/Data_Jiban/FoundryVTT-Code/Mock_server/";
                return (path);
            }
        }

        public static string AdjustFileToJson(string filepath)
        {
            string data = "[" + File.ReadAllText(filepath).Replace("}\n{", "}\n,{") + "]";
            return (data);
        }
    }
}