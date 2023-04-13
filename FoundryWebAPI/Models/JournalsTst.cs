// // Generated by https://quicktype.io
// using System;
// using System.Collections.Generic;

// using System.Globalization;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Converters;

// namespace FoundryWebAPI.Models
// {
//     public partial class PurpleType
//     {
//         [JsonProperty("name")]
//         public string Name { get; }

//         [JsonProperty("pages")]
//         public Page[] Pages { get; }

//         [JsonProperty("folder")]
//         public string Folder { get; }

//         [JsonProperty("sort")]
//         public long Sort { get; }

//         [JsonProperty("ownership")]
//         public TypeOwnership Ownership { get; }

//         [JsonProperty("flags")]
//         public TypeFlags Flags { get; }

//         [JsonProperty("_stats")]
//         public Stats Stats { get; }

//         [JsonProperty("_id")]
//         public string Id { get; }
//     }

//     public partial class TypeFlags
//     {
//         [JsonProperty("scene-packer")]
//         public ScenePacker ScenePacker { get; }
//     }

//     public partial class ScenePacker
//     {
//         [JsonProperty("hash")]
//         public string Hash { get; }
//     }

//     public partial class TypeOwnership
//     {
//         [JsonProperty("default")]
//         public long Default { get; }

//         [JsonProperty("M4ktKsyE0imAeVzy")]
//         public long M4KtKsyE0ImAeVzy { get; }
//     }

//     public partial class Page
//     {
//         [JsonProperty("sort")]
//         public long Sort { get; }

//         [JsonProperty("name")]
//         public string Name { get; }

//         [JsonProperty("type")]
//         public string Type { get; }

//         [JsonProperty("_id")]
//         public string Id { get; }

//         [JsonProperty("title")]
//         public Title Title { get; }

//         [JsonProperty("image")]
//         public ImageClass Image { get; }

//         [JsonProperty("text")]
//         public Text Text { get; }

//         [JsonProperty("video")]
//         public Video Video { get; }

//         [JsonProperty("src")]
//         public object Src { get; }

//         [JsonProperty("system")]
//         public ImageClass System { get; }

//         [JsonProperty("ownership")]
//         public PageOwnership Ownership { get; }

//         [JsonProperty("flags")]
//         public ImageClass Flags { get; }
//     }

//     public partial class ImageClass
//     {
//     }

//     public partial class PageOwnership
//     {
//         [JsonProperty("default")]
//         public long Default { get; }
//     }

//     public partial class Text
//     {
//         [JsonProperty("format")]
//         public long Format { get; }

//         [JsonProperty("content")]
//         public string Content { get; }

//         [JsonProperty("markdown")]
//         public string Markdown { get; }
//     }

//     public partial class Title
//     {
//         [JsonProperty("show")]
//         public bool Show { get; }

//         [JsonProperty("level")]
//         public long Level { get; }
//     }

//     public partial class Video
//     {
//         [JsonProperty("controls")]
//         public bool Controls { get; }

//         [JsonProperty("volume")]
//         public double Volume { get; }
//     }

//     public partial class Stats
//     {
//         [JsonProperty("systemId")]
//         public string SystemId { get; }

//         [JsonProperty("systemVersion")]
//         public string SystemVersion { get; }

//         [JsonProperty("coreVersion")]
//         public string CoreVersion { get; }

//         [JsonProperty("createdTime")]
//         public long CreatedTime { get; }

//         [JsonProperty("modifiedTime")]
//         public long ModifiedTime { get; }

//         [JsonProperty("lastModifiedBy")]
//         public string LastModifiedBy { get; }
//     }

//     public partial class PurpleType
//     {
//         public static PurpleType[] FromJson(string json) => JsonConvert.DeserializeObject<PurpleType[]>(json, QuickType.Converter.Settings);
//     }

//     public static class Serialize
//     {
//         public static string ToJson(this PurpleType[] self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
//     }

//     internal static class Converter
//     {
//         public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//         {
//             MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//             DateParseHandling = DateParseHandling.None,
//             Converters = {
//                 new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//             },
//         };
//     }
// }