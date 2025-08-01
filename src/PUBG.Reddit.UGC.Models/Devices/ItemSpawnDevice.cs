using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class ItemSpawnDevice : ActivatableDeviceBase
    {
        public bool ShowDevice { get; set; } = false;
        
        [Range(0, 3600)]
        public int FirstSpawnTime { get; set; } = 0; // 0-3600 seconds

        [Range(0, 3600)]
        public int RespawnTime { get; set; } = 0; // 0-3600 seconds
        
        public SpawnType SpawnType { get; set; } = SpawnType.Sequential;
        public bool UseDuplicateSpawn { get; set; } = false;
        public List<string> ItemList { get; set; } = new();
        public bool UseInfiniteAmmo { get; set; } = false;
        public bool UseReloadWithoutAmmo { get; set; } = false;
        public bool UseAutoReload { get; set; } = false;

        public override DeviceType DeviceType => DeviceType.ItemSpawn;
    }
}
