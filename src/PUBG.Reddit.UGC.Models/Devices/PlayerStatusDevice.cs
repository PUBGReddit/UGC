using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerStatusDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        
        [Range(1, 1000000)]
        public int Health { get; set; } = 100; // 1-1000000

        [Range(1, 1000000)]
        public int MaxHealth { get; set; } = 100; // 1-1000000
        
        public bool ShowHealthBarText { get; set; } = false;
        public bool GodMode { get; set; } = false;
        public bool UseFallDamage { get; set; } = true;
        
        [Range(50, 150)]
        public int CharacterScale { get; set; } = 100; // 50-150

        [Range(10, 200)]
        public int GravityRatio { get; set; } = 100; // 10-200

        [Range(10, 200)]
        public int JumpRatio { get; set; } = 100; // 10-200

        [Range(10, 200)]
        public int SpeedRatio { get; set; } = 100; // 10-200

        public override DeviceType DeviceType => DeviceType.PlayerStatus;
    }
}
