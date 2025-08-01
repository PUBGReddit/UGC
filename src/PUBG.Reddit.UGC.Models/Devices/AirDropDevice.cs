using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class AirDropDevice : ActivatableDeviceBase
    {
        public List<string> Items { get; set; } = new();
        public DropLocationType DropLocationType { get; set; } = DropLocationType.Center;

        [Range(0, 100000)]
        public int RandomXOffsetRange { get; set; } = 0; // 0-100000

        [Range(0, 100000)]
        public int RandomYOffsetRange { get; set; } = 0; // 0-100000

        [Range(1, 3600)]
        public int FlightTimeToDropLocation { get; set; } = 10; // 1-3600 seconds

        public override DeviceType DeviceType => DeviceType.AirDrop;
    }
}
