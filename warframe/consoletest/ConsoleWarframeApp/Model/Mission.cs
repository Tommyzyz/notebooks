using System;

namespace ConsoleWarframeApp.Model;

    public record Mission
    {
        public string? description { get; set; }
        public required string node { get; set; }
        public required string nodeKey { get; set; }
        public required string type { get; set; }
        public required string typeKey { get; set; }
        public string? faction { get; set; }
        public string? factionKey { get; set; }
        public Reward? reward { get; set; }
        public int? minEnemyLevel { get; set; }
        public int? maxEnemyLevel { get; set; }
        public int? maxWaveNum { get; set; }
        public bool nightmare { get; set; }
        public bool archwingRequired { get; set; }
        public bool isSharkwing { get; set; }
        public string? levelOverride { get; set; }
        public string? enemySpec { get; set; }
        public required List<object> advancedSpawners { get; set; }
        public required List<object> requiredItems { get; set; }
        public required List<object> levelAuras { get; set; }
    }
