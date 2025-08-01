using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class AirplaneDevice : ActivatableDeviceBase, ITargetable
    {
        public TargetType Target { get; set; } = TargetType.ActivatingTeam;
        public RouteType RouteType { get; set; } = RouteType.Center;

        [Range(10, 80)]
        public int MinFallDistance { get; set; } = 20; // 10-80

        [Range(10, 100)]
        public int AirplaneStartingRadius { get; set; } = 100; // 10-100

        [Range(1, 100000)]
        public int AirplaneSpeed { get; set; } = 4000; // 1-100000

        [Range(1, 100000)]
        public int AirplaneDistanceToTarget { get; set; } = 10000; // 1-100000

        [Range(1, 100000)]
        public int AirplaneAltitude { get; set; } = 100000; // 1-100000

        [Range(100, 100000)]
        public int ParachuteStartDeployAltitude { get; set; } = 30000; // 100-100000

        [Range(100, 100000)]
        public int ParachuteAutoDeployAltitude { get; set; } = 15000; // 100-100000

        public override DeviceType DeviceType => DeviceType.Airplane;
    }
}
