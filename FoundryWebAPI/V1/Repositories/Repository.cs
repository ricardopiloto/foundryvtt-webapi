using FoundryWebAPI.Models;
using FoundryWebAPI.Services;
using Newtonsoft.Json;
using FoundryWebAPI.Repositories;
using FoundryWebAPI.Helpers;

namespace FoundryWebAPI.V1.Repositories
{
    public class Repository : IRepository
    {
        public List<Actors>? Actor(string world)
        {
            var actors = ActorService.ActorFile(world);
            if (actors != null) return (JsonConvert.DeserializeObject<List<Actors>>(actors));

            return (null);
        }

        public async Task<List<Actors>>? ActorAsync(PageParams p, string world, string type, string call)
        {
            var actors = ActorService.ActorFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Actors>>(actors);
            if (jsonObj == null) return (null);

            if (string.IsNullOrEmpty(type)) return (jsonObj);
            if (call == "byId") { jsonObj = jsonObj.FindAll(a => a.Id == type); return (jsonObj); }
            if (call == "byName") { jsonObj = jsonObj.FindAll(a => a.Name.ToLower().Contains(type.ToLower())); return (jsonObj); }
            if (call == "byType") {jsonObj = jsonObj.FindAll(a => a.Type.ToLower().Contains(type.ToLower()) && a.Name.ToLower().Contains(p.name.ToLower())); return (jsonObj);}
            if (call == "byClass") { jsonObj = jsonObj.FindAll(a => a.Type.Contains("character") && a.Items.Any(i => i.Name.ToLower().Contains(type.ToLower())) && a.Name.ToLower().Contains(p.name.ToLower())); return (jsonObj); }

            return (jsonObj);
        }

        public List<Journals>? Journal(string world)
        {
            var journal = JournalService.JournalFile(world);
            if (journal != null) return (JsonConvert.DeserializeObject<List<Journals>>(journal));

            return (null);
        }

        public async Task<List<Journals>>? JournalAsync(string world, string x, string call)
        {
            var journal = JournalService.JournalFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Journals>>(journal);
            if (jsonObj == null) return (null);

            if (string.IsNullOrEmpty(x)) return (jsonObj);
            if (call == "byId") jsonObj = jsonObj.FindAll(j => j.Id == x);
            if (call == "byName") jsonObj = jsonObj.FindAll(j => j.Name.ToLower().Contains(x.ToLower()));

            return (jsonObj);
        }
        public List<Worlds>? World()
        {
            var world = WorldService.GetWorlds();
            var jsonObj = JsonConvert.DeserializeObject<List<Worlds>>(world);

            if (jsonObj.Count > 0) return (jsonObj);

            return (null);
        }
    }
}