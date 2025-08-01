using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class TimerDevice : ActivatableDeviceBase
    {
        [Range(1, 5400)]
        public int Interval { get; set; } = 1; // 1-5400 seconds

        [Range(0, 999)]
        public int RepeatCount { get; set; } = 1; // 0-999

        public override DeviceType DeviceType => DeviceType.Timer;
    }
}
