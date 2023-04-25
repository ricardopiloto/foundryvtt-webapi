using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoundryWebAPI.Helpers
{
    public class PageList<T> : List<T>
    {
        public int CurrenPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrenPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count/(double)pageSize);
            this.AddRange(items);
        }

        public static async Task<PageList<T>> CreateAsync(List<T> source, int pageNumber, int pageSize)
        {
            // var count  = await source.CountAsync();
            // var items = await source.Skip((pageNumber-1) * pageSize).Take(pageSize).ToListAsync();
            var count = source.Count();
            var items = source.Skip((pageNumber-1) * pageSize).Take(pageSize).ToList();
            
            return (new PageList<T>(items, count, pageNumber, pageSize));
        }
    }
}