using System.Text.Json.Serialization;

namespace BlazorHybridApp.Models;

public class Hero
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("hair_color")]
    public string HairColor { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("height")]
    public string Height { get; set; }
}
