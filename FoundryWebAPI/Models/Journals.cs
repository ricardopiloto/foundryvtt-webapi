using System.Collections;
using System.Collections.Generic;

namespace FoundryWebAPI.Models
{
    public class Journals
    {
        public Journals() { }
        public Journals(string name, string id, string pages, string folder, string flags)
        {
            this.Name = name;
            this._Id = id;
            this.Folder = folder;
            this.Flags = flags;

        }
        public string? Name { get; }
        public string? Folder { get; }
        public string? Sort { get; }
        public string? _Id { get; }
        public string? Flags { get; }

        public Journals? Journal { get; }
        public IEnumerable<ActorsJournals>? ActorJournal { get; }
    }
}