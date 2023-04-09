using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Models
{
    public class Actors
    {
        public Actors() { }
        public Actors(string name, string type, string id)
        {
            this.Name = name;
            this.Type = type;
            this.Id = id;

        }
        public string Name { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public Actors? Actor { get; set; }
        public IEnumerable<ActorsJournals>? ActorJournal { get; set; }
    }
}