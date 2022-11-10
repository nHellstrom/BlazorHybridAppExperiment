namespace BlazorHybridApp.Data;

public class Coordinate 
{
    public string Longitude;
    public string Latitude;

    public Coordinate(string latitude, string longitude)
    {
        Longitude= longitude;
        Latitude= latitude;
    }

    public string getCoords()
    {
        return $"{Latitude}:{Longitude}";
    }
}