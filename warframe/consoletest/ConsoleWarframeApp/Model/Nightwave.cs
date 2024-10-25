using System;

namespace ConsoleWarframeApp.Model;

public class Nightwave
{
    public const string clientString = "nightwave";


    public required string id { get; set; }
    public DateTime activation { get; set; }
    public required string startString { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public int season { get; set; }
    public required string tag { get; set; }
    public int phase { get; set; }
    public required Params @params { get; set; }
    public required List<object> possibleChallenges { get; set; }
    public required List<ActiveChallenge> activeChallenges { get; set; }
    public required List<string> rewardTypes { get; set; }
}


public class ActiveChallenge
{
    public required string id { get; set; }
    public DateTime activation { get; set; }
    public required string startString { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public bool isDaily { get; set; }
    public bool isElite { get; set; }
    public required string desc { get; set; }
    public required string title { get; set; }
    public int reputation { get; set; }
}

public class Params
{
}