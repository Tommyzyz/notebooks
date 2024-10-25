using System;

namespace ConsoleWarframeApp.Model;


public class Reward
{
    public required List<string> items { get; set; }
    public required List<CountedItem> countedItems { get; set; }
    public int credits { get; set; }
    public required string asString { get; set; }
    public required string itemString { get; set; }
    public required string thumbnail { get; set; }
    public int color { get; set; }
}

public class CountedItem
{

    public int? count { get; set; }
    public required string type { get; set; }
    public required string key { get; set; }
}