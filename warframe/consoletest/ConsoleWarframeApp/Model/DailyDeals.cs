using System;

namespace ConsoleWarframeApp.Model;

public class dailyDeals
{
    public required string item { get; set; }
    public required string uniqueName { get; set; }
    public DateTime expiry { get; set; }
    public DateTime activation { get; set; }
    public int originalPrice { get; set; }
    public int salePrice { get; set; }
    public int total { get; set; }
    public int sold { get; set; }
    public required string id { get; set; }
    public required string eta { get; set; }
    public int discount { get; set; }
}
