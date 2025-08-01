using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class WeaponDamageDevice : ActivatableDeviceBase
    {
        public TargetType Target { get; set; } = TargetType.ActivatingTeam;

        [Range(0, 1000)]
        public int ThrowableDamage { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int BulletDamageHead { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int BulletDamageUpperBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int BulletDamageLowerBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int BulletDamageArms { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int BulletDamageLegs { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int MeleeDamageHead { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int MeleeDamageUpperBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int MeleeDamageLowerBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int MeleeDamageArms { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int MeleeDamageLegs { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int PunchDamageHead { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int PunchDamageUpperBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int PunchDamageLowerBody { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int PunchDamageArms { get; set; } = 100; // 0-1000

        [Range(0, 1000)]
        public int PunchDamageLegs { get; set; } = 100; // 0-1000

        public override DeviceType DeviceType => DeviceType.WeaponDamage;
    }
}
