using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerSpawnDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        public bool DefaultSpawnLocation { get; set; } = true;

        [Range(0, 500000)]
        public int EnemyDetectionRange { get; set; } = 0; // 0-500000 cm

        public override DeviceType DeviceType => DeviceType.PlayerSpawn;
    }
}
