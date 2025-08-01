using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class InteractionDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        
        [Range(0, 3600)]
        public int InteractionDuration { get; set; } = 5; // 0-3600 seconds
        
        public bool RestrictMovement { get; set; } = false;
        public InteractableObject SelectObject { get; set; } = InteractableObject.Controller;

        public override DeviceType DeviceType => DeviceType.Interaction;
    }
}
