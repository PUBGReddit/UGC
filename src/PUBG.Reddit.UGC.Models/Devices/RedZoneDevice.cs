using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class RedZoneDevice : ActivatableDeviceBase
    {
        [Range(1, 1000)]
        public int RepeatTime { get; set; } = 1; // 1-1000 seconds

        [Range(1, 1000)]
        public int NextZoneInterval { get; set; } = 1; // 1-1000 seconds

        [Range(1, 1000)]
        public int BeginDelay { get; set; } = 45; // 1-1000 seconds

        [Range(1, 1000)]
        public int Duration { get; set; } = 30; // 1-1000 seconds

        [Range(1, 1000000)]
        public int Radius { get; set; } = 50000; // 1-1000000

        public override DeviceType DeviceType => DeviceType.RedZone;
    }
}
