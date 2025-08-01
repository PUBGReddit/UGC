using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerDamageDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.SelectedPlayer;

        [Range(0, 1000000)]
        public int DamageAmount { get; set; } = 10; // 0-1000000

        public override DeviceType DeviceType => DeviceType.PlayerDamage;
    }
}
