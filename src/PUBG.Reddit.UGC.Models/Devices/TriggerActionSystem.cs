using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PUBG.Reddit.UGC.Models
{
    // Trigger/Action system
    public class DeviceTrigger
    {
        public string TriggerName { get; set; } = string.Empty;
        public List<DeviceAction> ConnectedActions { get; set; } = new();
    }

    public class DeviceAction
    {
        public string DeviceId { get; set; } = string.Empty;
        public string ActionName { get; set; } = string.Empty;
        public Dictionary<string, object> Parameters { get; set; } = new();
    }
}
