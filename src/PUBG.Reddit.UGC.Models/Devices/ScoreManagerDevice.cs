using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class ScoreManagerDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        
        [Range(-9999, 9999)]
        public int Score { get; set; } = 1; // -9999 to 9999

        [Range(-9999, 9999)]
        public int MaxScore { get; set; } = 9999; // -9999 to 9999

        [Range(-9999, 9999)]
        public int MinScore { get; set; } = -9999; // -9999 to 9999

        [Range(-9999, 9999)]
        public int TargetScore { get; set; } = 100; // -9999 to 9999
        
        public bool EnableActivationLimit { get; set; } = false;

        public override DeviceType DeviceType => DeviceType.ScoreManager;
    }
}
