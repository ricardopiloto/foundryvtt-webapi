using System.Collections;
using System.Collections.Generic;

namespace FoundryWebAPI.Models
{
    public class Journals
    {
        public Journals() { }
        public Journals(string name, string id, string folder, string owner)
        {
            this.Name = name;
            this.Id = id;
            this.Folder = folder;
            this.Owner = owner;

        }
        public string Name { get; set; } = string.Empty;
        public string Folder { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;

        public Journals? Journal { get; set; }
        public IEnumerable<ActorsJournals>? ActorJournal { get; set; }
    }
}