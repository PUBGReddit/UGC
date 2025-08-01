using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class DamageTriggerDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;

        [Range(0, 1000)]
        public int DamageAmount { get; set; } = 0; // 0-1000

        [Range(0, 100)]
        public int HitCount { get; set; } = 0; // 0-100

        public List<DamageType> AllowedDamageTypes { get; set; } = new();
        public bool UsePointDamage { get; set; } = true;
        public bool UseRadialDamage { get; set; } = true;
        public DamageableObject SelectObject { get; set; } = DamageableObject.Cube;

        public override DeviceType DeviceType => DeviceType.DamageTrigger;
    }
}
