using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Models
{
    public class ActorsJournals
    {
        public ActorsJournals() { }
        public string? ActorId { get; set; }
        public Actors? Actor { get; set; }
        public string? JournalId { get; set; }
        public Journals? Journal { get; set; }

    }
}