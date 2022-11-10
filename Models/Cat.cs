using System.ComponentModel.DataAnnotations;
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

    public int CatID { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public CatSize Size { get; set; }
    [DisplayFormat(NullDisplayText = "")]
    public string AdditionalInfo { get; set; }
    public Coordinate LastSeen { get; set; }

    public CatOwner CatOwner { get; set; }
}