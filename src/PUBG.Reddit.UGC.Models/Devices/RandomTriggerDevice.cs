using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class RandomTriggerDevice : ActivatableDeviceBase
    {
        [Range(1, 100000)]
        public int TargetCount { get; set; } = 1; // 1-100000 
        
        public override DeviceType DeviceType => DeviceType.RandomTrigger;
    }
}
