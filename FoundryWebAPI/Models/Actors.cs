using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FoundryWebAPI.Models
{
    public class Actors
    {
        public Actors() { }
        
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("effects")]
        public object[] Effects { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("sort")]
        public long? Sort { get; set; }

        [JsonProperty("flags")]
        public ActorFlags Flags { get; set; }

        [JsonProperty("system")]
        public ActorSystem System { get; set; }

        [JsonProperty("ownership")]
        public Dictionary<string, long> Ownership { get; set; }

        [JsonProperty("prototypeToken")]
        public PrototypeToken PrototypeToken { get; set; }

        [JsonProperty("_stats")]
        public Stats Stats { get; set; }
    }

    public partial class ActorFlags
    {
        [JsonProperty("core")]
        public Core Core { get; set; }

        [JsonProperty("scene-packer")]
        public ScenePacker ScenePacker { get; set; }
    }

    public partial class Core
    {
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }
    }

    public partial class ScenePacker
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("effects")]
        public object[] Effects { get; set; }

        [JsonProperty("folder")]
        public object Folder { get; set; }

        [JsonProperty("sort")]
        public long? Sort { get; set; }

        [JsonProperty("flags")]
        public ClassClass Flags { get; set; }

        [JsonProperty("system")]
        public ItemSystem System { get; set; }

        [JsonProperty("ownership")]
        public Ownership Ownership { get; set; }

        [JsonProperty("_stats")]
        public Stats Stats { get; set; }
    }

    public partial class ClassClass
    {
    }

    public partial class Ownership
    {
        [JsonProperty("default")]
        public long? Default { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("systemId")]
        public string SystemId { get; set; }

        [JsonProperty("systemVersion")]
        public string SystemVersion { get; set; }

        [JsonProperty("coreVersion")]
        public string CoreVersion { get; set; }

        [JsonProperty("createdTime")]
        public object CreatedTime { get; set; }

        [JsonProperty("modifiedTime")]
        public long? ModifiedTime { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }
    }

    public partial class ItemSystem
    {
        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("activation")]
        public Activation Activation { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("cover")]
        public object Cover { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }

        [JsonProperty("range")]
        public Range Range { get; set; }

        [JsonProperty("uses")]
        public Uses? Uses { get; set; }

        [JsonProperty("consume")]
        public Consume Consume { get; set; }

        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("attackBonus")]
        public long? AttackBonus { get; set; }

        [JsonProperty("chatFlavor")]
        public string ChatFlavor { get; set; }

        [JsonProperty("critical")]
        public Critical Critical { get; set; }

        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("save")]
        public Save Save { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public SystemType Type { get; set; }

        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public string Requirements { get; set; }

        [JsonProperty("recharge", NullValueHandling = NullValueHandling.Ignore)]
        public Recharge Recharge { get; set; }

        [JsonProperty("attunement")]
        public long? Attunement { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Quantity { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Weight { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("equipped", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Equipped { get; set; }

        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public string Rarity { get; set; }

        [JsonProperty("identified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Identified { get; set; }

        [JsonProperty("armor", NullValueHandling = NullValueHandling.Ignore)]
        public Xp Armor { get; set; }

        [JsonProperty("hp", NullValueHandling = NullValueHandling.Ignore)]
        public SystemHp Hp { get; set; }

        [JsonProperty("weaponType", NullValueHandling = NullValueHandling.Ignore)]
        public string WeaponType { get; set; }

        [JsonProperty("baseItem", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseItem { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> Properties { get; set; }

        [JsonProperty("proficient", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Proficient { get; set; }
    }

    public partial class Activation
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cost")]
        public long? Cost { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public partial class Xp
    {
        [JsonProperty("value")]
        public long? Value { get; set; }
    }

    public partial class Consume
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("amount")]
        public object Amount { get; set; }
    }

    public partial class Critical
    {
        [JsonProperty("threshold")]
        public object Threshold { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }
    }

    public partial class Damage
    {
        [JsonProperty("parts")]
        public string[][] Parts { get; set; }

        [JsonProperty("versatile")]
        public string Versatile { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("chat")]
        public string Chat { get; set; }

        [JsonProperty("unidentified")]
        public string Unidentified { get; set; }
    }

    public partial class Duration
    {
        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class SystemHp
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }

        [JsonProperty("dt")]
        public object Dt { get; set; }

        [JsonProperty("conditions")]
        public string Conditions { get; set; }
    }

    public partial class Range
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("long")]
        public object Long { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public partial class Recharge
    {
        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("charged")]
        public bool? Charged { get; set; }
    }

    public partial class Save
    {
        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("dc")]
        public object Dc { get; set; }

        [JsonProperty("scaling")]
        public string Scaling { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public partial class Target
    {
        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("width")]
        public object Width { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class SystemType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }
    }

    public partial class Uses
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }

        [JsonProperty("per")]
        public string? Per { get; set; }

        [JsonProperty("recovery")]
        public string? Recovery { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }
    }

    public partial class PrototypeToken
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public long? DisplayName { get; set; }

        [JsonProperty("actorLink")]
        public bool ActorLink { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }

        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("lockRotation")]
        public bool LockRotation { get; set; }

        [JsonProperty("rotation")]
        public long? Rotation { get; set; }

        [JsonProperty("disposition")]
        public long? Disposition { get; set; }

        [JsonProperty("displayBars")]
        public long? DisplayBars { get; set; }

        [JsonProperty("bar1")]
        public Bar Bar1 { get; set; }

        [JsonProperty("bar2")]
        public Bar Bar2 { get; set; }

        [JsonProperty("flags")]
        public ClassClass Flags { get; set; }

        [JsonProperty("randomImg")]
        public bool RandomImg { get; set; }

        [JsonProperty("alpha")]
        public long? Alpha { get; set; }

        [JsonProperty("light")]
        public Light Light { get; set; }

        [JsonProperty("texture")]
        public Texture Texture { get; set; }

        [JsonProperty("sight")]
        public Sight Sight { get; set; }

        [JsonProperty("detectionModes")]
        public object[] DetectionModes { get; set; }
    }

    public partial class Bar
    {
        [JsonProperty("attribute")]
        public string Attribute { get; set; }
    }

    public partial class Light
    {
        [JsonProperty("alpha")]
        public long? Alpha { get; set; }

        [JsonProperty("angle")]
        public long? Angle { get; set; }

        [JsonProperty("bright")]
        public long? Bright { get; set; }

        [JsonProperty("coloration")]
        public long? Coloration { get; set; }

        [JsonProperty("dim")]
        public long? Dim { get; set; }

        [JsonProperty("luminosity")]
        public double Luminosity { get; set; }

        [JsonProperty("saturation")]
        public long? Saturation { get; set; }

        [JsonProperty("contrast")]
        public long? Contrast { get; set; }

        [JsonProperty("shadows")]
        public long? Shadows { get; set; }

        [JsonProperty("animation")]
        public Animation Animation { get; set; }

        [JsonProperty("darkness")]
        public Darkness Darkness { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("attenuation")]
        public double Attenuation { get; set; }
    }

    public partial class Animation
    {
        [JsonProperty("speed")]
        public long? Speed { get; set; }

        [JsonProperty("intensity")]
        public long? Intensity { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }

        [JsonProperty("reverse")]
        public bool Reverse { get; set; }
    }

    public partial class Darkness
    {
        [JsonProperty("min")]
        public long? Min { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }
    }

    public partial class Sight
    {
        [JsonProperty("angle")]
        public long? Angle { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("range")]
        public long? Range { get; set; }

        [JsonProperty("brightness")]
        public long? Brightness { get; set; }

        [JsonProperty("visionMode")]
        public string VisionMode { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("attenuation")]
        public double Attenuation { get; set; }

        [JsonProperty("saturation")]
        public long? Saturation { get; set; }

        [JsonProperty("contrast")]
        public long? Contrast { get; set; }
    }

    public partial class Texture
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("tint")]
        public object Tint { get; set; }

        [JsonProperty("scaleX")]
        public double ScaleX { get; set; }

        [JsonProperty("scaleY")]
        public double ScaleY { get; set; }

        [JsonProperty("offsetX")]
        public long? OffsetX { get; set; }

        [JsonProperty("offsetY")]
        public long? OffsetY { get; set; }

        [JsonProperty("rotation")]
        public long? Rotation { get; set; }
    }

    public partial class ActorSystem
    {
        [JsonProperty("abilities")]
        public SystemAbilities Abilities { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("traits")]
        public Traits Traits { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("skills")]
        public Dictionary<string, Init> Skills { get; set; }

        [JsonProperty("spells")]
        public Spells Spells { get; set; }

        [JsonProperty("bonuses")]
        public SystemBonuses Bonuses { get; set; }

        [JsonProperty("resources")]
        public Resources Resources { get; set; }
    }

    public partial class SystemAbilities
    {
        [JsonProperty("str")]
        public Cha Str { get; set; }

        [JsonProperty("dex")]
        public Cha Dex { get; set; }

        [JsonProperty("con")]
        public Cha Con { get; set; }

        [JsonProperty("int")]
        public Cha Int { get; set; }

        [JsonProperty("wis")]
        public Cha Wis { get; set; }

        [JsonProperty("cha")]
        public Cha Cha { get; set; }
    }

    public partial class Cha
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("proficient")]
        public long? Proficient { get; set; }

        [JsonProperty("bonuses")]
        public ChaBonuses Bonuses { get; set; }

        [JsonProperty("min")]
        public long? Min { get; set; }

        [JsonProperty("mod")]
        public long? Mod { get; set; }

        [JsonProperty("save")]
        public long? Save { get; set; }

        [JsonProperty("prof")]
        public long? Prof { get; set; }

        [JsonProperty("saveBonus")]
        public long? SaveBonus { get; set; }

        [JsonProperty("checkBonus")]
        public long? CheckBonus { get; set; }

        [JsonProperty("dc")]
        public long? Dc { get; set; }
    }

    public partial class ChaBonuses
    {
        [JsonProperty("check")]
        public string Check { get; set; }

        [JsonProperty("save")]
        public string Save { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("ac")]
        public Ac Ac { get; set; }

        [JsonProperty("hp")]
        public AttributesHp Hp { get; set; }

        [JsonProperty("init")]
        public Init Init { get; set; }

        [JsonProperty("movement")]
        public Movement Movement { get; set; }

        [JsonProperty("attunement")]
        public Attunement Attunement { get; set; }

        [JsonProperty("senses")]
        public Senses Senses { get; set; }

        [JsonProperty("spellcasting")]
        public string Spellcasting { get; set; }

        [JsonProperty("prof")]
        public long? Prof { get; set; }

        [JsonProperty("spelldc")]
        public long? Spelldc { get; set; }

        [JsonProperty("spellLevel")]
        public long? SpellLevel { get; set; }

        [JsonProperty("encumbrance")]
        public Encumbrance Encumbrance { get; set; }
    }

    public partial class Ac
    {
        [JsonProperty("flat")]
        public long? Flat { get; set; }

        [JsonProperty("calc")]
        public string Calc { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("min")]
        public long? Min { get; set; }
    }

    public partial class Attunement
    {
        [JsonProperty("max")]
        public long? Max { get; set; }
    }

    public partial class Encumbrance
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }

        [JsonProperty("pct")]
        public long? Pct { get; set; }

        [JsonProperty("encumbered")]
        public bool Encumbered { get; set; }
    }

    public partial class AttributesHp
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }

        [JsonProperty("temp")]
        public object Temp { get; set; }

        [JsonProperty("tempmax")]
        public object Tempmax { get; set; }

        [JsonProperty("formula")]
        public string Formula { get; set; }

        [JsonProperty("min")]
        public long? Min { get; set; }
    }

    public partial class Init
    {
        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("bonus")]
        public string? Bonus { get; set; }

        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("mod")]
        public string? Mod { get; set; }

        [JsonProperty("total")]
        public long? Total { get; set; }

        [JsonProperty("prof")]
        public long? Prof { get; set; }

        [JsonProperty("bonuses", NullValueHandling = NullValueHandling.Ignore)]
        public InitBonuses Bonuses { get; set; }

        [JsonProperty("passive", NullValueHandling = NullValueHandling.Ignore)]
        public long? Passive { get; set; }
    }

    public partial class InitBonuses
    {
        [JsonProperty("check")]
        public string Check { get; set; }

        [JsonProperty("passive")]
        public string Passive { get; set; }
    }

    public partial class Movement
    {
        [JsonProperty("burrow")]
        public long? Burrow { get; set; }

        [JsonProperty("climb")]
        public long? Climb { get; set; }

        [JsonProperty("fly")]
        public long? Fly { get; set; }

        [JsonProperty("swim")]
        public long? Swim { get; set; }

        [JsonProperty("walk")]
        public long? Walk { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("hover")]
        public bool Hover { get; set; }
    }

    public partial class Senses
    {
        [JsonProperty("darkvision")]
        public long? Darkvision { get; set; }

        [JsonProperty("blindsight")]
        public long? Blindsight { get; set; }

        [JsonProperty("tremorsense")]
        public long? Tremorsense { get; set; }

        [JsonProperty("truesight")]
        public long? Truesight { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("special")]
        public string Special { get; set; }
    }

    public partial class SystemBonuses
    {
        [JsonProperty("mwak")]
        public Msak Mwak { get; set; }

        [JsonProperty("rwak")]
        public Msak Rwak { get; set; }

        [JsonProperty("msak")]
        public Msak Msak { get; set; }

        [JsonProperty("rsak")]
        public Msak Rsak { get; set; }

        [JsonProperty("abilities")]
        public BonusesAbilities Abilities { get; set; }

        [JsonProperty("spell")]
        public Spell Spell { get; set; }
    }

    public partial class BonusesAbilities
    {
        [JsonProperty("check")]
        public string Check { get; set; }

        [JsonProperty("save")]
        public string Save { get; set; }

        [JsonProperty("skill")]
        public string Skill { get; set; }
    }

    public partial class Msak
    {
        [JsonProperty("attack")]
        public string Attack { get; set; }

        [JsonProperty("damage")]
        public string Damage { get; set; }
    }

    public partial class Spell
    {
        [JsonProperty("dc")]
        public string Dc { get; set; }
    }

    public partial class Currency
    {
        [JsonProperty("pp")]
        public long? Pp { get; set; }

        [JsonProperty("gp")]
        public long? Gp { get; set; }

        [JsonProperty("ep")]
        public long? Ep { get; set; }

        [JsonProperty("sp")]
        public long? Sp { get; set; }

        [JsonProperty("cp")]
        public long? Cp { get; set; }
    }

    public partial class Details
    {
        [JsonProperty("biography")]
        public Biography Biography { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }

        [JsonProperty("race")]
        public object Race { get; set; }

        [JsonProperty("type")]
        public DetailsType Type { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("cr")]
        public long? Cr { get; set; }

        [JsonProperty("spellLevel")]
        public long? SpellLevel { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("xp")]
        public Xp Xp { get; set; }

        [JsonProperty("class")]
        public ClassClass Class { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("eyes")]
        public string Eyes { get; set; }

        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("hair")]
        public string Hair { get; set; }

        [JsonProperty("notes1name")]
        public string Notes1Name { get; set; }

        [JsonProperty("notes2name")]
        public string Notes2Name { get; set; }

        [JsonProperty("notes3name")]
        public string Notes3Name { get; set; }

        [JsonProperty("notes4name")]
        public string Notes4Name { get; set; }
    }

    public partial class Biography
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }
    }

    public partial class DetailsType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("swarm")]
        public string Swarm { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }
    }

    public partial class Resources
    {
        [JsonProperty("legact")]
        public Legact Legact { get; set; }

        [JsonProperty("legres")]
        public Legact Legres { get; set; }

        [JsonProperty("lair")]
        public Lair Lair { get; set; }
    }

    public partial class Lair
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("initiative")]
        public long? Initiative { get; set; }
    }

    public partial class Legact
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }
    }

    public partial class Spells
    {
        [JsonProperty("spell1")]
        public Pact Spell1 { get; set; }

        [JsonProperty("spell2")]
        public Pact Spell2 { get; set; }

        [JsonProperty("spell3")]
        public Pact Spell3 { get; set; }

        [JsonProperty("spell4")]
        public Pact Spell4 { get; set; }

        [JsonProperty("spell5")]
        public Pact Spell5 { get; set; }

        [JsonProperty("spell6")]
        public Pact Spell6 { get; set; }

        [JsonProperty("spell7")]
        public Pact Spell7 { get; set; }

        [JsonProperty("spell8")]
        public Pact Spell8 { get; set; }

        [JsonProperty("spell9")]
        public Pact Spell9 { get; set; }

        [JsonProperty("pact")]
        public Pact Pact { get; set; }

        [JsonProperty("spell0")]
        public Legact Spell0 { get; set; }
    }

    public partial class Pact
    {
        [JsonProperty("value")]
        public long? Value { get; set; }

        [JsonProperty("override")]
        public object Override { get; set; }

        [JsonProperty("max")]
        public long? Max { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }
    }

    public partial class Traits
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("di")]
        public Di Di { get; set; }

        [JsonProperty("dr")]
        public Di Dr { get; set; }

        [JsonProperty("dv")]
        public Di Dv { get; set; }

        [JsonProperty("ci")]
        public Ci Ci { get; set; }

        [JsonProperty("languages")]
        public Ci Languages { get; set; }
    }

    public partial class Ci
    {
        [JsonProperty("value")]
        public object[] Value { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }
    }

    public partial class Di
    {
        [JsonProperty("value")]
        public object[] Value { get; set; }

        [JsonProperty("bypasses")]
        public object[] Bypasses { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }
    }

    public partial class Actor
    {
        public static Actor FromJson(string json) => JsonConvert.DeserializeObject<Actor>(json, FoundryWebAPI.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Actor self) => JsonConvert.SerializeObject(self, FoundryWebAPI.Models.Converter.Settings);
    }

    internal static class Converter
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
}