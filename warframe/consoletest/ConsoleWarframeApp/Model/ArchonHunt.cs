using System;

namespace ConsoleWarframeApp.Model;

public class ArchonHunt
{
    public const string clientString = "archonHunt";
    
        public required string id { get; set; }
        public DateTime activation { get; set; }
        public required string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public required string rewardPool { get; set; }
        public required List<object> variants { get; set; }
        public required List<Mission> missions { get; set; }
        public required string boss { get; set; }
        public required string faction { get; set; }
        public bool expired { get; set; }
        public required string eta { get; set; }
}

