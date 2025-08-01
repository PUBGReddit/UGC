using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class AreaBlockingDevice : ActivatableDeviceBase
    {
        public bool BlockThrowables { get; set; } = false;
        public bool BlueEffect { get; set; } = false;
        public bool BlockArea { get; set; } = false;
        public BlockAreaShape BlockAreaShape { get; set; } = BlockAreaShape.Box;
        public Vector3 BlockAreaSize { get; set; } = new(50, 50, 50); // 0-100000 per axis

        public override DeviceType DeviceType => DeviceType.AreaBlocking;
    }
}
