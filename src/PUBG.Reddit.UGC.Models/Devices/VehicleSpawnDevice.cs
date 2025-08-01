using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class VehicleSpawnDevice : ActivatableDeviceBase
    {
        public VehicleType SpawnVehicle { get; set; } = VehicleType.UAZ;

        [Range(1, 5000)]
        public int VehicleHealth { get; set; } = 3000; // 1-5000

        public bool RemoveOnDestruction { get; set; } = true;
        public bool UseFuel { get; set; } = true;

        [Range(0, 100)]
        public int InitialFuel { get; set; } = 50; // 0-100

        public bool UseAutoRespawn { get; set; } = false;
        public AreaShape AreaShape { get; set; } = AreaShape.Sphere;

        [Range(0, 100000)]
        public int AreaSize { get; set; } = 50;

        public override DeviceType DeviceType => DeviceType.VehicleSpawn;
    }
}
