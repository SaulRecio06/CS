using System.Text.Json.Serialization;

namespace CS.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Berserker = 4,
        Paladin =  5
    }
}