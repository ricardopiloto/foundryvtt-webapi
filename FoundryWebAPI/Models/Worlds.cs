using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FoundryWebAPI.Models
{
    public class Worlds
    {
        public Worlds () {}

        [JsonProperty("path")]
        public string? Path { get; set; }
        public string? World { get; set; }
    }
}