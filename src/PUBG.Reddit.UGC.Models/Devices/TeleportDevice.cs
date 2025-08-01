using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class TeleportDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.ActivatingPlayer;
        public AreaColor VisualizationColor { get; set; } = AreaColor.White;

        public override DeviceType DeviceType => DeviceType.Teleport;
    }
}
