using System;
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
        // Don't know how to use the one below yet
        // public Item[]? Items { get; set; } = null;
        public const int MaxPageSize = 100;
        public int pageNumber { get; set; } = 1;
        private int pageSize = 20;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
    }
}