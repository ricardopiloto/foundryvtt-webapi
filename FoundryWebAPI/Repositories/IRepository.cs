using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.Repositories
{
    public interface IRepository
    {
        List<Actors>? Actor(string world);
        Task<PageList<Actors>>? ActorAsync(PageParams p, string world);
        List<Journals>? Journal(string world);
        Task<List<Journals>>? JournalAsync(PageParams p, string world);
        List<Worlds>? World();
    }
}