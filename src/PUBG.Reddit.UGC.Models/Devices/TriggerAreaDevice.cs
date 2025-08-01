using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class TriggerAreaDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        public BlockAreaShape AreaShape { get; set; } = BlockAreaShape.Sphere;
        public AreaColor AreaColor { get; set; } = AreaColor.White;

        [Range(0, 100000)]
        public int SphereRadius { get; set; } = 50; // 0-100000 cm

        public Vector3 AreaSize { get; set; } = new(50, 50, 50); // 0-100000 per axis

        [Range(0.1, 3600)]
        public float CheckInterval { get; set; } = 0.1f; // 0.1-3600 seconds

        public TriggerType TriggerType { get; set; } = TriggerType.Both;

        public override DeviceType DeviceType => DeviceType.TriggerArea;
    }
}
