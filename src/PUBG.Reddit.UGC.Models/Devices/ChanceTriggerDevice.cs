using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class ChanceTriggerDevice : ActivatableDeviceBase
    {
        [Range(0, 100)]
        public int Probability { get; set; } = 50; // 0-100

        public override DeviceType DeviceType => DeviceType.ChanceTrigger;
    }
}
