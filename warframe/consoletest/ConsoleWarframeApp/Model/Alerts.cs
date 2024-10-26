using System;

namespace ConsoleWarframeApp.Model;
//警报
public class Alerts
{
    public const string clientString = "alerts";
        public required string id { get; set; }
        public DateTime activation { get; set; }
        public required string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public required Mission mission { get; set; }
        public required string eta { get; set; }
        public required List<string> rewardTypes { get; set; }
        public required string tag { get; set; }
}




    


