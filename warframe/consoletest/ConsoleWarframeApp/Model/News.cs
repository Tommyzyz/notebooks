using System;

namespace ConsoleWarframeApp.Model;


public class news
{
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
    public string? en { get; set; }
    public string? fr { get; set; }
    public string? it { get; set; }
    public string? de { get; set; }
    public string? es { get; set; }
    public string? pt { get; set; }
    public string? ru { get; set; }
    public string? pl { get; set; }
    public string? uk { get; set; }
    public string? tr { get; set; }
    public string? ja { get; set; }
    public string? zh { get; set; }
    public string? ko { get; set; }
    public string? tc { get; set; }
}

