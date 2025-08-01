using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class BlueZoneDevice : ActivatableDeviceBase
    {
        public ZoneShape BlueZoneShape { get; set; } = ZoneShape.Circle;
        public List<BlueZoneOption> BlueZoneOptions { get; set; } = new();

        public override DeviceType DeviceType => DeviceType.BlueZone;

        public class BlueZoneOption
        {
            [Range(0, 300)]
            public int StartDelay { get; set; } = 60; // 0-300 seconds

            [Range(0, 300)]
            public int WarningDuration { get; set; } = 60; // 0-300 seconds

            [Range(0, 300)]
            public int ShrinkDuration { get; set; } = 120; // 0-300 seconds

            [Range(0, 100)]
            public int DamagePerSecond { get; set; } = 2; // 0-100

            [Range(0, 0.99)]
            public float ShrinkRatio { get; set; } = 0.6f; // 0-0.99

            [Range(0, 15)]
            public float ExpandRatio { get; set; } = 0.56f; // 0-15

            [Range(0, 100)]
            public int LandProbability { get; set; } = 70; // 0-100
        }
    }
}
