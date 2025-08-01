using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class SpecialZoneDevice : ActivatableDeviceBase
    {
        public SpecialZoneType SpecialZoneType { get; set; } = SpecialZoneType.Blizzard;

        [Range(1, 1000)]
        public int ZoneRepeatTime { get; set; } = 1; // 1-1000 seconds

        [Range(1, 1000)]
        public int NextZoneInterval { get; set; } = 1; // 1-1000 seconds

        [Range(1, 1000)]
        public int ZoneBeginDelay { get; set; } = 45; // 1-1000 seconds

        [Range(1, 1000)]
        public int ZoneDuration { get; set; } = 30; // 1-1000 seconds

        [Range(2000, 1000000)]
        public int ZoneRadius { get; set; } = 50000; // 2000-1000000

        public override DeviceType DeviceType => DeviceType.SpecialZone;
    }
}
