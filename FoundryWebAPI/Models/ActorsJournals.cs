using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundryWebAPI.Models
{
    public class ActorsJournals
    {
        public ActorsJournals() { }
        public ActorsJournals(string actorId, string journalId)
        {
            this.ActorId = actorId;
            this.JournalId = journalId;

        }
        public string ActorId { get; set; } = string.Empty;
        public Actors? Actor { get; set; }
        public string JournalId { get; set; } = string.Empty;
        public Journals? Journal { get; set; }

    }
}