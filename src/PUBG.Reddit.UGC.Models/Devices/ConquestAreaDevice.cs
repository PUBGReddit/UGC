using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class ConquestAreaDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        public bool ShowAreaBoundary { get; set; } = true;
        public bool ShowProgressMessages { get; set; } = true;
        public bool ShowGroundEffects { get; set; } = true;
        public bool ShowIcons { get; set; } = false;

        [Range(0, 600)]
        public int ConquestTime { get; set; } = 10; // 0-600 seconds

        [Range(0, 10)]
        public int ConquestTimePerTeamMember { get; set; } = 1; // 0-10 seconds

        public AreaShape AreaShape { get; set; } = AreaShape.Sphere;

        [Range(0, 3600)]
        public int AreaEmptyTimeDecrease { get; set; } = 1; // 0-3600 seconds

        public bool MaintainConqueredState { get; set; } = true;
        public bool UseIntervalTrigger { get; set; } = false;

        [Range(0, 3600)]
        public int IntervalTrigger { get; set; } = 1; // 0-3600 seconds

        [Range(0, 1000000)]
        public int IntervalTriggerCount { get; set; } = 3; // 0-1000000

        public bool UseCooldown { get; set; } = true;

        [Range(0, 3600)]
        public int ConquestCooldown { get; set; } = 1; // 0-3600 seconds

        public bool UseConquerByMajority { get; set; } = false;
        public bool UseNeutralOnDeactivate { get; set; } = true;

        public override DeviceType DeviceType => DeviceType.ConquestArea;
    }
}
