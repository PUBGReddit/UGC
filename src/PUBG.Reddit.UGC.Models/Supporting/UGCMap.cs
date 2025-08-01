using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

// Split into multiple files. See Supporting and Devices folders for logical separation.
namespace PUBG.Reddit.UGC.Models
{

    // Container for complete UGC map
    public class UGCMap
    {
        public string MapName { get; set; } = string.Empty;
        public string MapCode { get; set; } = "MOD_Main";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public List<DeviceBase> Devices { get; set; } = new();
        public GameSettings Settings { get; set; } = new();

        // Documented limits
        public const int MaxDevices = 1000;
        public const int MaxVehicles = 25;
        public const int MaxProps = 3000;

        public class GameSettings
        {
            // Rule Set
            public string ModeType { get; set; } = "NONE";
            public int RoundCount { get; set; } = 3;
            public int TargetScore { get; set; } = 50;
            public int TimeLimit { get; set; } = 600; // seconds
            public int WarmupTime { get; set; } = 10; // seconds
            public int RoundWarmupTime { get; set; } = 5; // seconds
            public int TargetRoundCount { get; set; } = 0;

            // Match settings
            public int TeamCount { get; set; } = 2;
            public int TeamSize { get; set; } = 4;
            public float FriendlyFireDamageRatio { get; set; } = 0f;
            public bool UseDBNO { get; set; } = false;
            public string CameraView { get; set; } = "FPS and TPS";
            public bool UseRespawn { get; set; } = false;
            public int RespawnTime { get; set; } = 3; // seconds
            public bool UseRespawnInvincibility { get; set; } = false;
            public int InvincibilityDuration { get; set; } = 3; // seconds
            public bool UseDeathboxes { get; set; } = false;
            public int DeathboxDuration { get; set; } = 90; // seconds
            public bool ShowKillfeedTeamNumbers { get; set; } = true;

            // Game Options
            public bool AllowTeamSelect { get; set; } = false;
            public string OverflowAssign { get; set; } = "Overflow Assign";
            public bool EnableDeviceEdit { get; set; } = false;
            public bool EnableObjectPlacement { get; set; } = false;
            public string FillTestPlayers { get; set; } = "None";
            public bool EnableObserverVoiceChat { get; set; } = false;
            public bool UseLog { get; set; } = true;
        }
    }
}