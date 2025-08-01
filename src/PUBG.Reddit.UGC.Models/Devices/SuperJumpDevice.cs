using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class SuperJumpDevice : ActivatableDeviceBase
    {
        [Range(1, 1000)]
        public int UpwardSpeedRatio { get; set; } = 200; // 1-1000

        public SuperJumpType Type { get; set; } = SuperJumpType.CallerUp;

        public override DeviceType DeviceType => DeviceType.SuperJump;
    }
}
