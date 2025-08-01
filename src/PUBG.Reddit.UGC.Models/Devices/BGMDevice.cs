using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class BGMDevice : ActivatableDeviceBase
    {
        public BGMTrack SelectBGM { get; set; } = BGMTrack.BGM_Landmark_01;

        public override DeviceType DeviceType => DeviceType.BGM;
    }
}
