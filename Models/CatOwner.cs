namespace BlazorHybridApp.Models;

public class CatOwner
{
    public int CatOwnerID { get; set; }
    public int CatID { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public Cat Cat { get; set; }
}