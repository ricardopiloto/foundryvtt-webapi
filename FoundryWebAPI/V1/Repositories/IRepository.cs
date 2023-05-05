using FoundryWebAPI.Helpers;
using FoundryWebAPI.Models;

namespace FoundryWebAPI.V1.Repositories
{
    public interface IRepository
    {
        List<Actors>? Actor(string world);
        Task<List<Actors>>? ActorAsync(PageParams p, string world, string x, string call);
        List<Journals>? Journal(string world);
        Task<List<Journals>>? JournalAsync(string world, string x, string call);
        List<Worlds>? World();
        // Task<List<Worlds>>? WorldAsync();
    }
}