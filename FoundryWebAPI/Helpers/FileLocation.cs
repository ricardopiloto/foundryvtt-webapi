using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Helpers
{
    public class FileLocation
    {
        public static string Location(string world)
        {
            if (!String.IsNullOrEmpty(world))
            {
                string filepath = $"/mnt/worlds/{world}/data/";
                return (filepath);
            }
            else
            {
                string path = $"/mnt/worlds";
                return (path);
            }
        }
    }
}