using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerTagDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.ActivatingTeam;

        [MaxLength(30)]
        public string Tag { get; set; } = string.Empty; // 30 characters max

        public override DeviceType DeviceType => DeviceType.PlayerTag;
    }
}
