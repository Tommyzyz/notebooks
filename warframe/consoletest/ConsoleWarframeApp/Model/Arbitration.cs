using System;

namespace ConsoleWarframeApp.Model;

// arbitration: 仲裁
public class Arbitration
{
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public required string enemy { get; set; }
        public required string type { get; set; }
        public bool archwing { get; set; }
        public bool sharkwing { get; set; }
        public required string node { get; set; }
        public required string nodeKey { get; set; }
        public required string typeKey { get; set; }
        public required string id { get; set; }
        public bool expired { get; set; }
}
