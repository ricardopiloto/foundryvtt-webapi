using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FoundryWebAPI.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse response, int currenPage,int itemsPerPage,int totalItems,int totalPages) 
        {
            var paginationheader = new PaginationHeader(currenPage, itemsPerPage, totalItems, totalPages);
            
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationheader, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Header", "Pagination");
        }
    }
}