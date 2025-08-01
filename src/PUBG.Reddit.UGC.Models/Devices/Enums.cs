using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PUBG.Reddit.UGC.Models
{
    // ENUMS

    [JsonConverter(typeof(JsonStringEnumConverter<DeviceType>))]
    public enum DeviceType
    {
        AirDrop,
        Airplane,
        AreaBlocking,
        BGM,
        BlueZone,
        ChanceTrigger,
        ConquestArea,
        DamageTrigger,
        Interaction,
        ItemProvide,
        ItemSpawn,
        Mover,
        PlayerDamage,
        PlayerEvent,
        PlayerIcon,
        PlayerSpawn,
        PlayerStatus,
        PlayerTag,
        RandomTrigger,
        RedZone,
        RoundEvent,
        ScoreManager,
        SpecialZone,
        SuperJump,
        Teleport,
        Timer,
        TriggerArea,
        VehicleSpawn,
        WeaponDamage
    }

    [JsonConverter(typeof(JsonStringEnumConverter<ActivationPhase>))]
    public enum ActivationPhase
    {
        None,
        DeviceCreation,
        StandbyBeforeSpawn,
        StandbyAfterSpawn,
        RoundStartBeforeSpawn,
        RoundStartAfterSpawn
    }

    [JsonConverter(typeof(JsonStringEnumConverter<SendRoundEventType>))]
    public enum SendRoundEventType
    {
        StandbyBeforeSpawn,
        StandbyAfterSpawn,
        RoundStartBeforeSpawn,
        RoundStartAfterSpawn,
        RoundStartAfterDelay,
        RoundEnd
    }

    [JsonConverter(typeof(JsonStringEnumConverter<SpecificRoundType>))]
    public enum SpecificRoundType
    {
        AllRounds,
        SpecificRound
    }

    [JsonConverter(typeof(JsonStringEnumConverter<TargetType>))]
    public enum TargetType
    {
        AllPlayers,
        SelectedTeam,
        SelectedPlayer,
        TaggedPlayers,
        ActivatingTeam,
        ActivatingPlayer
    }

    [JsonConverter(typeof(JsonStringEnumConverter<SpawnType>))]
    public enum SpawnType
    {
        Sequential,
        Random,
        NoRepeatsRandom
    }
 

    [JsonConverter(typeof(JsonStringEnumConverter<AreaShape>))]
    public enum AreaShape
    {
        Sphere,
        Box,
        Cube
    }

    [JsonConverter(typeof(JsonStringEnumConverter<BlockAreaShape>))]
    public enum BlockAreaShape
    {
        Box,
        Sphere
    }

    [JsonConverter(typeof(JsonStringEnumConverter<AreaColor>))]
    public enum AreaColor
    {
        None,
        White,
        Black,
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta,
        Orange,
        Purple,
        Turquoise,
        Silver,
        Emerald
    }

    [JsonConverter(typeof(JsonStringEnumConverter<TriggerType>))]
    public enum TriggerType
    {
        OnEnter,
        OnExit,
        Both
    }

    [JsonConverter(typeof(JsonStringEnumConverter<ZoneShape>))]
    public enum ZoneShape
    {
        Circle,
        Rectangle
    }

    [JsonConverter(typeof(JsonStringEnumConverter<DropLocationType>))]
    public enum DropLocationType
    {
        Center,
        Device
    }

    [JsonConverter(typeof(JsonStringEnumConverter<RouteType>))]
    public enum RouteType
    {
        Center,
        BlueZoneCenter,
        Device,
        Random
    }

    [JsonConverter(typeof(JsonStringEnumConverter<BGMTrack>))]
    public enum BGMTrack
    {
        BGM_Landmark_01,
        BGM_Christmas_01,
        BGM_Christmas_02,
        ReadyToBattle_EarlyAccess,
        BGM_Halloween_01,
        LoneSurvivorsDream_BizarreBattleRoyale,
        BGM_POBG_01,
        BGM_SLB_01,
        BGM_TDM_01,
        BGM_TDM_02
    }

    [JsonConverter(typeof(JsonStringEnumConverter<DamageType>))]
    public enum DamageType
    {
        Damage_None,
        Damage_Instant,
        Damage_Gun,
        Damage_Melee,
        Damage_Punch,
        Damage_ZombiePunch,
        Damage_Groggy,
        Damage_BlueZone,
        Damage_VehicleHit,
        Damage_VehicleCrashHit,
        Damage_Molotov,
        Damage_Explosion,
        Damage_Explosion_Grenade,
        Damage_Explosion_RedZone,
        Damage_Explosion_Vehicle,
        Damage_Explosion_PlantedTimeBomb,
        Damage_Instant_Fall
    }

    [JsonConverter(typeof(JsonStringEnumConverter<DamageableObject>))]
    public enum DamageableObject
    {
        Cube,
        Cupboard,
        RedBall,
        RedLight,
        RangeTarget1,
        RangeTarget2,
        RangeTarget3,
        RangeTarget4,
        RangeTarget5,
        RangeTarget6,
        RangeTarget7
    }

    [JsonConverter(typeof(JsonStringEnumConverter<InteractableObject>))]
    public enum InteractableObject
    {
        Controller,
        Computer,
        Device,
        Generator,
        Pot
    }

    [JsonConverter(typeof(JsonStringEnumConverter<ItemLocation>))]
    public enum ItemLocation
    {
        PlayerInventory,
        PlayerLocation
    }

    [JsonConverter(typeof(JsonStringEnumConverter<InventoryAction>))]
    public enum InventoryAction
    {
        ResetAll,
        ResetInventory,
        PreserveAll
    }

    [JsonConverter(typeof(JsonStringEnumConverter<FullBackpackAction>))]
    public enum FullBackpackAction
    {
        DropItem,
        DoNotProvide
    }

    [JsonConverter(typeof(JsonStringEnumConverter<IconType>))]
    public enum IconType
    {
        None,
        NumberOne,
        NumberTwo,
        NumberThree,
        NumberFour,
        NumberFive,
        NumberSix,
        NumberSeven,
        NumberEight,
        NumberNine,
        Cross,
        Reinforced,
        Zombie,
        Defense,
        Target,
        Commander
    }

    [JsonConverter(typeof(JsonStringEnumConverter<SpecialZoneType>))]
    public enum SpecialZoneType
    {
        None,
        Blizzard,
        Sandstorm,
        EMP
    }

    [JsonConverter(typeof(JsonStringEnumConverter<SuperJumpType>))]
    public enum SuperJumpType
    {
        CallerUp,
        Reflect
    }

    [JsonConverter(typeof(JsonStringEnumConverter<TeleportType>))]
    public enum TeleportType
    {
        Device,
        RandomLocation
    }

    [JsonConverter(typeof(JsonStringEnumConverter<VehicleType>))]
    public enum VehicleType
    {
        UAZ,
        Dacia,
        Buggy,
        CoupeRB,
        Motorbike,
        PickupTruck,
        Mirado,
        MiniBus,
        Dirtbike,
        PonyCoupe,
        Porter,
        Jima,
        Rony,
        Pillar_Car,
        Food_Truck,
        Blanc,
        PicoBus,
        AquaRail,
        Boat,
        Motorglider,
        Bicycle
    }

}
