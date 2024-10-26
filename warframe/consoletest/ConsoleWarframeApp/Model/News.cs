using System;

namespace ConsoleWarframeApp.Model;


public class News
{
    public const string clientString = "news";
    
    public required string id { get; set; }
    public required string message { get; set; }
    public required string link { get; set; }
    public required string imageLink { get; set; }
    public bool priority { get; set; }
    public DateTime date { get; set; }
    public required string eta { get; set; }
    public bool update { get; set; }
    public bool primeAccess { get; set; }
    public bool stream { get; set; }
    public required Translations translations { get; set; }
    public required string asString { get; set; }
    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
}

public class Translations
{
    public required string en { get; set; }
    public required string fr { get; set; }
    public required string it { get; set; }
    public required string de { get; set; }
    public required string es { get; set; }
    public required string pt { get; set; }
    public required string ru { get; set; }
    public required string pl { get; set; }
    public required string uk { get; set; }
    public required string tr { get; set; }
    public required string ja { get; set; }
    public required string zh { get; set; }
    public required string ko { get; set; }
    public required string tc { get; set; }
}

