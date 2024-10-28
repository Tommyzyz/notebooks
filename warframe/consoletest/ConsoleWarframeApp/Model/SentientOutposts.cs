namespace ConsoleWarframeApp.Model;

public class sentientOutposts
{
    public const string clientString = "sentientOutposts";
    public required Mission mission { get; set; }
    public DateTime activation { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public required string id { get; set; }
}