using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class PlayerEventDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.AllPlayers;
        public bool TriggerOnSpawn { get; set; } = false;
        public bool TriggerOnScoreGain { get; set; } = false;
        public bool TriggerOnScoreLoss { get; set; } = false;
        public bool TriggerOnEnemyKill { get; set; } = false;
        public bool TriggerOnHeadshotKill { get; set; } = false;
        public bool TriggerOnPlayerIconEnemyKill { get; set; } = false;
        public bool TriggerOnFinalEnemyKill { get; set; } = false;
        public bool TriggerOnDeathByEnemy { get; set; } = false;
        public bool TriggerOnHeadshotDeath { get; set; } = false;
        public bool TriggerOnDeathByPlayerIconEnemy { get; set; } = false;
        public bool TriggerOnFinalDeath { get; set; } = false;
        public bool TriggerOnEnemyDBNO { get; set; } = false;
        public bool TriggerOnDBNOByEnemy { get; set; } = false;
        public bool TriggerOnLastSurvival { get; set; } = false;

        public override DeviceType DeviceType => DeviceType.PlayerEvent;
    }
}
