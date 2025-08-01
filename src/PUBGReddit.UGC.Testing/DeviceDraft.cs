using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

// Split into multiple files. See Supporting and Devices folders for logical separation.
namespace PUBG.UGC.Devices
{ 
    // JSON serialization context
    [JsonSerializable(typeof(UGCMap))]
    [JsonSerializable(typeof(List<DeviceBase>))]
    [JsonSerializable(typeof(AirDropDevice))]
    [JsonSerializable(typeof(AirplaneDevice))]
    [JsonSerializable(typeof(AreaBlockingDevice))]
    [JsonSerializable(typeof(BGMDevice))]
    [JsonSerializable(typeof(BlueZoneDevice))]
    [JsonSerializable(typeof(ChanceTriggerDevice))]
    [JsonSerializable(typeof(ConquestAreaDevice))]
    [JsonSerializable(typeof(DamageTriggerDevice))]
    [JsonSerializable(typeof(InteractionDevice))]
    [JsonSerializable(typeof(ItemProvideDevice))]
    [JsonSerializable(typeof(ItemSpawnDevice))]
    [JsonSerializable(typeof(MoverDevice))]
    [JsonSerializable(typeof(PlayerDamageDevice))]
    [JsonSerializable(typeof(PlayerEventDevice))]
    [JsonSerializable(typeof(PlayerIconDevice))]
    [JsonSerializable(typeof(PlayerSpawnDevice))]
    [JsonSerializable(typeof(PlayerStatusDevice))]
    [JsonSerializable(typeof(PlayerTagDevice))]
    [JsonSerializable(typeof(RandomTriggerDevice))]
    [JsonSerializable(typeof(RedZoneDevice))]
    [JsonSerializable(typeof(RoundEventDevice))]
    [JsonSerializable(typeof(ScoreManagerDevice))]
    [JsonSerializable(typeof(SpecialZoneDevice))]
    [JsonSerializable(typeof(SuperJumpDevice))]
    [JsonSerializable(typeof(TeleportDevice))]
    [JsonSerializable(typeof(TimerDevice))]
    [JsonSerializable(typeof(TriggerAreaDevice))]
    [JsonSerializable(typeof(VehicleSpawnDevice))]
    [JsonSerializable(typeof(WeaponDamageDevice))]
    public partial class UGCSerializationContext : JsonSerializerContext
    {
    }
     
     // Factory Pattern for Device Creation
    public static class DeviceFactory
    {
        private static readonly Dictionary<DeviceType, Func<DeviceBase>> DeviceCreators = new()
        {
            [DeviceType.AirDrop] = () => new AirDropDevice(),
            [DeviceType.Airplane] = () => new AirplaneDevice(),
            [DeviceType.AreaBlocking] = () => new AreaBlockingDevice(),
            [DeviceType.BGM] = () => new BGMDevice(),
            [DeviceType.BlueZone] = () => new BlueZoneDevice(),
            [DeviceType.ChanceTrigger] = () => new ChanceTriggerDevice(),
            [DeviceType.ConquestArea] = () => new ConquestAreaDevice(),
            [DeviceType.DamageTrigger] = () => new DamageTriggerDevice(),
            [DeviceType.Interaction] = () => new InteractionDevice(),
            [DeviceType.ItemProvide] = () => new ItemProvideDevice(),
            [DeviceType.ItemSpawn] = () => new ItemSpawnDevice(),
            [DeviceType.Mover] = () => new MoverDevice(),
            [DeviceType.PlayerDamage] = () => new PlayerDamageDevice(),
            [DeviceType.PlayerEvent] = () => new PlayerEventDevice(),
            [DeviceType.PlayerIcon] = () => new PlayerIconDevice(),
            [DeviceType.PlayerSpawn] = () => new PlayerSpawnDevice(),
            [DeviceType.PlayerStatus] = () => new PlayerStatusDevice(),
            [DeviceType.PlayerTag] = () => new PlayerTagDevice(),
            [DeviceType.RandomTrigger] = () => new RandomTriggerDevice(),
            [DeviceType.RedZone] = () => new RedZoneDevice(),
            [DeviceType.RoundEvent] = () => new RoundEventDevice(),
            [DeviceType.ScoreManager] = () => new ScoreManagerDevice(),
            [DeviceType.SpecialZone] = () => new SpecialZoneDevice(),
            [DeviceType.SuperJump] = () => new SuperJumpDevice(),
            [DeviceType.Teleport] = () => new TeleportDevice(),
            [DeviceType.Timer] = () => new TimerDevice(),
            [DeviceType.TriggerArea] = () => new TriggerAreaDevice(),
            [DeviceType.VehicleSpawn] = () => new VehicleSpawnDevice(),
            [DeviceType.WeaponDamage] = () => new WeaponDamageDevice()
        };

        public static DeviceBase CreateDevice(DeviceType deviceType)
        {
            return DeviceCreators.TryGetValue(deviceType, out var creator) 
                ? creator() 
                : throw new ArgumentException($"Unknown device type: {deviceType}");
        }

        public static DeviceBase CreateDevice(string deviceType)
        {
            if (Enum.TryParse<DeviceType>(deviceType, out var enumValue))
            {
                return CreateDevice(enumValue);
            }
            throw new ArgumentException($"Unknown device type: {deviceType}");
        }

        public static T CreateDevice<T>() where T : DeviceBase, new() => new();

        public static IEnumerable<DeviceType> GetSupportedDeviceTypes() => DeviceCreators.Keys;
    }
}
