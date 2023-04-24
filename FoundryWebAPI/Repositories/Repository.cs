using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Newtonsoft.Json;

namespace FoundryWebAPI.Repositories
{
    public class Repository : IRepository
    {
        public List<Actors>? Actor(string world)
        {
            var actors = ActorService.ActorFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Actors>>(actors);
            
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }

        public async Task<List<Actors>>? ActorAsync(string world)
        {
            var actors = ActorService.ActorFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Actors>>(actors);
            
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }

        public List<Journals>? Journal(string world)
        {
            var journal = JournalService.JournalFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Journals>>(journal);
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }

        public async Task<List<Journals>>? JournalAsync(string world)
        {
            var journal = JournalService.JournalFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Journals>>(journal);
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }
        public List<Worlds>? World()
        {
            var world = WorldService.GetWorlds();
            var jsonObj = JsonConvert.DeserializeObject<List<Worlds>>(world);
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }
    }
}