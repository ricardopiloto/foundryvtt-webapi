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

        [JsonProperty("name")]
        public string Name { get; set; }

        public Worlds? World { get; set; }
    }
}