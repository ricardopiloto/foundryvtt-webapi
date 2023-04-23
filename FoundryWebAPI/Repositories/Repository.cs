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
            if (actors != null)
            {
                return (JsonConvert.DeserializeObject<List<Actors>>(actors));
            }
            else
            {
                return (null);
            }
        }

        public List<Journals>? Journal(string world)
        {
            var journal = JournalService.JournalFile(world);
            if (journal != null)
            {
                return (JsonConvert.DeserializeObject<List<Journals>>(journal));
            }
            else
            {
                return (null);
            };
        }
        public List<Worlds>? World()
        {
            var world = WorldService.GetWorlds();
            if (world != null)
            {
                return (JsonConvert.DeserializeObject<List<Worlds>>(world));
            }
            else
            {
                return (null);
            };
        }
    }
}