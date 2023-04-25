using System.Linq;
using FoundryWebAPI.Helpers;
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

        public async Task<PageList<Actors>>? ActorAsync(PageParams p, string world)
        {
            var actors = ActorService.ActorFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Actors>>(actors);
;
            
            if (jsonObj == null) return (null);
            if (!string.IsNullOrEmpty(p.name)) jsonObj = jsonObj.FindAll(actor => actor.Name.ToLower().Contains(p.name.ToLower()));
            if (!string.IsNullOrEmpty(p.id)) jsonObj = jsonObj.FindAll(actor => actor.Id == p.id);
            if (!string.IsNullOrEmpty(p.type)) jsonObj = jsonObj.FindAll(actor => actor.Type == p.type);
            
            // Got to adjust this one to filter both character and character class (don't know how to do it yet so I left it on the controller)
            if (p.type.ToLower() == "character") jsonObj = (List<Actors>)jsonObj.FindAll(actor => actor.Type.Contains("character"));
            // return (jsonObj);
            return await PageList<Actors>.CreateAsync(jsonObj, p.pageNumber, p.PageSize);
        }

        public List<Journals>? Journal(string world)
        {
            var journal = JournalService.JournalFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Journals>>(journal);
            if (jsonObj == null) return (null);
            
            return (jsonObj);
        }

        public async Task<List<Journals>>? JournalAsync(PageParams p, string world)
        {
            var journal = JournalService.JournalFile(world);
            var jsonObj = JsonConvert.DeserializeObject<List<Journals>>(journal);
            if (jsonObj == null) return (null);
            
            // return (jsonObj);
            return await PageList<Journals>.CreateAsync(jsonObj, p.pageNumber, p.PageSize);
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