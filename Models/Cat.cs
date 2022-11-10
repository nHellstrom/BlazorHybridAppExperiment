using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BlazorHybridApp.Data;

namespace BlazorHybridApp.Models;

public enum CatSize
{
    VerySmall,
    Small,
    Medium,
    Large,
    VeryLarge
};

public class Cat
{
    [JsonPropertyName("id")]
    public int CatID { get; set; }
	[JsonPropertyName("name")]
	public string Name { get; set; }
	[JsonPropertyName("colour")]
	public string Colour { get; set; }
	[JsonPropertyName("size")]
	public int Size { get; set; }
	[JsonPropertyName("additionalInfo")]
	public string AdditionalInfo { get; set; }
	[JsonPropertyName("coordinate")]
	public string Coordinate { get; set; }
	[JsonPropertyName("ownerContact")]
	public string OwnerContact { get; set; }
}