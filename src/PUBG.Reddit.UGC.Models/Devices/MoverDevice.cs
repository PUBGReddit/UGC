using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class MoverDevice : ActivatableDeviceBase
    {
        public Vector3 MovementDirection { get; set; } = new(0, 0, 0); // -1, 0, 1 per axis
        
        [Range(0, 5400)]
        public int MovementDuration { get; set; } = 0; // 0-5400 seconds

        [Range(0, 10000)]
        public int MovementDistance { get; set; } = 0; // 0-10000 cm
        
        public bool ReturnToStartPositionWhenStopped { get; set; } = false;

        public override DeviceType DeviceType => DeviceType.Mover;
    }
}
