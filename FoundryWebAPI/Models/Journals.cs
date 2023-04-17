using Newtonsoft.Json;

namespace FoundryWebAPI.Models
{
    public class Journals
    {
        public Journals() { }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("folder")]
        public string? Folder { get; set; }

        [JsonProperty("_id")]
        public string? Id { get; set; }

        [JsonProperty("pages")]
        public Pages[]? Page { get; set; }

        public Journals? Journal { get; set; }
        public IEnumerable<ActorsJournals>? ActorJournal { get; set; }
    }
    public partial class Pages
    {
        [JsonProperty("sort")]
        public long Sort { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("_id")]
        public string? _Id { get; set; }

        [JsonProperty("title")]
        public Title? Title { get; set; }

        [JsonProperty("text")]
        public Text? Text { get; set; }
    }
    public partial class Title
    {
        [JsonProperty("show")]
        public bool Show { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }
    }
    public partial class Text
    {
        [JsonProperty("format")]
        public long Format { get; set; }

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonProperty("markdown")]
        public string? Markdown { get; set; }
    }
}