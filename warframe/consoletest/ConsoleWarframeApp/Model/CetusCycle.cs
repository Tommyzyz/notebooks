using System;

namespace ConsoleWarframeApp.Model;

public class CetusCycle
{
    public required string id { get; set; }
    public DateTime expiry { get; set; }
    public DateTime activation { get; set; }
    public bool isDay { get; set; }
    public required string state { get; set; }
    public required string timeLeft { get; set; }
    public bool isCetus { get; set; }
    public required string shortString { get; set; }
}