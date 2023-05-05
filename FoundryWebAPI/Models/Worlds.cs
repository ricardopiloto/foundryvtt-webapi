using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FoundryWebAPI.Models
{

    public class WorldsModel
    {
        public WorldsModel() { }
        
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("system")]
        public string? System { get; set; }

        [JsonProperty("background")]
        public string? Background { get; set; }

        [JsonProperty("coreVersion")]
        public string? CoreVersion { get; set; }

        [JsonProperty("resetKeys")]
        public bool ResetKeys { get; set; }

        [JsonProperty("safeMode")]
        public bool SafeMode { get; set; }

        [JsonProperty("systemVersion")]
        public string? SystemVersion { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("compatibility")]
        public Compatibility Compatibility { get; set; }
    }

    public partial class Compatibility
    {
        [JsonProperty("verified")]
        public string? Verified { get; set; }

        [JsonProperty("minimum")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Minimum { get; set; }
    }

    public partial class Worlds
    {
        public static Worlds FromJson(string json) => JsonConvert.DeserializeObject<Worlds>(json, FoundryWebAPI.Models.WConverter.Settings);
    }

    public static class WSerialize
    {
        public static string ToJson(this Worlds self) => JsonConvert.SerializeObject(self, FoundryWebAPI.Models.WConverter.Settings);
    }

    internal static class WConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
