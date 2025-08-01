using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class RoundEventDevice : DeviceBase
    {
        public SendRoundEventType SendRoundEvent { get; set; } = SendRoundEventType.RoundStartAfterSpawn;
        public SpecificRoundType SpecificRound { get; set; } = SpecificRoundType.AllRounds;

        // [Range(1, int.MaxValue)]
        // public int RoundNumber { get; set; } = 1; // Used when SpecificRound is SpecificRound

        public override DeviceType DeviceType => DeviceType.RoundEvent;
    }
}
