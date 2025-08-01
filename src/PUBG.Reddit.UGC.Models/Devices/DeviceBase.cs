using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PUBG.Reddit.UGC.Models
{
    // Base device class - only includes consistently documented properties
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "DeviceType")]
    [JsonDerivedType(typeof(AirDropDevice), "AirDrop")]
    [JsonDerivedType(typeof(AirplaneDevice), "Airplane")]
    [JsonDerivedType(typeof(AreaBlockingDevice), "AreaBlocking")]
    [JsonDerivedType(typeof(BGMDevice), "BGM")]
    [JsonDerivedType(typeof(BlueZoneDevice), "BlueZone")]
    [JsonDerivedType(typeof(ChanceTriggerDevice), "ChanceTrigger")]
    [JsonDerivedType(typeof(ConquestAreaDevice), "ConquestArea")]
    [JsonDerivedType(typeof(DamageTriggerDevice), "DamageTrigger")]
    [JsonDerivedType(typeof(InteractionDevice), "Interaction")]
    [JsonDerivedType(typeof(ItemProvideDevice), "ItemProvide")]
    [JsonDerivedType(typeof(ItemSpawnDevice), "ItemSpawn")]
    [JsonDerivedType(typeof(MoverDevice), "Mover")]
    [JsonDerivedType(typeof(PlayerDamageDevice), "PlayerDamage")]
    [JsonDerivedType(typeof(PlayerEventDevice), "PlayerEvent")]
    [JsonDerivedType(typeof(PlayerIconDevice), "PlayerIcon")]
    [JsonDerivedType(typeof(PlayerSpawnDevice), "PlayerSpawn")]
    [JsonDerivedType(typeof(PlayerStatusDevice), "PlayerStatus")]
    [JsonDerivedType(typeof(PlayerTagDevice), "PlayerTag")]
    [JsonDerivedType(typeof(RandomTriggerDevice), "RandomTrigger")]
    [JsonDerivedType(typeof(RedZoneDevice), "RedZone")]
    [JsonDerivedType(typeof(RoundEventDevice), "RoundEvent")]
    [JsonDerivedType(typeof(ScoreManagerDevice), "ScoreManager")]
    [JsonDerivedType(typeof(SpecialZoneDevice), "SpecialZone")]
    [JsonDerivedType(typeof(SuperJumpDevice), "SuperJump")]
    [JsonDerivedType(typeof(TeleportDevice), "Teleport")]
    [JsonDerivedType(typeof(TimerDevice), "Timer")]
    [JsonDerivedType(typeof(TriggerAreaDevice), "TriggerArea")]
    [JsonDerivedType(typeof(VehicleSpawnDevice), "VehicleSpawn")]
    [JsonDerivedType(typeof(WeaponDamageDevice), "WeaponDamage")]
    public abstract class DeviceBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public abstract DeviceType DeviceType { get; }
        
        // Trigger/Action system
        public List<DeviceTrigger> Triggers { get; set; } = new();
        public List<DeviceAction> Actions { get; set; } = new();
    }

    // Base class for devices that DO have ActivationPhase
    public abstract class ActivatableDeviceBase : DeviceBase, IActivatable
    {
        public ActivationPhase ActivationPhase { get; set; } = ActivationPhase.DeviceCreation;
    }
}
