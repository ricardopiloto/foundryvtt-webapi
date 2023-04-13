using Newtonsoft.Json;

namespace FoundryWebAPI.Models
{
    public class Journals
    {
        public Journals() { }

        public Journals(string folder, string _Id, string name)
        {
            this.Folder = folder;
            // this.Sort = sort;
            // this.Stats = stats;
            this._Id = _Id;
            this.Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set;}

        [JsonProperty("folder")]
        public string? Folder { get; set;}

        [JsonProperty("_id")]
        public string? _Id { get; set;}

        public Journals? Journal { get; set;}
        public IEnumerable<ActorsJournals>? ActorJournal { get; set;}
    }
}