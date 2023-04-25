using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Helpers
{
    public class PaginationHeader
    {
        public PaginationHeader(int currenPage, int totalItems, int itemsPerPage, int totalPages)
        {
            this.CurrenPage = currenPage;
            this.TotalItems = totalItems;
            this.ItemsPerPage = itemsPerPage;
            this.TotalPages = totalPages;
        }
        public int CurrenPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }
}