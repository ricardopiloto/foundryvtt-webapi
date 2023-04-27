using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Helpers
{
    public class PageParams
    {
        public string? id { get; set; } = string.Empty;
        public string? name { get; set; } = string.Empty;
        public string? type { get; set; } = string.Empty;
        public string? cls { get; set; } = string.Empty;
        public string? owner { get; set; } = string.Empty;
    }
}