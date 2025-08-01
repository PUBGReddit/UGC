using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerIconDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.ActivatingTeam;
        public IconType IconType { get; set; } = IconType.None;

        public override DeviceType DeviceType => DeviceType.PlayerIcon;
    }
}
