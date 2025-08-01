using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using PUBG.Reddit.UGC.Models;

namespace PUBG.Reddit.UGC.Models
{
    public class ItemProvideDevice : ActivatableDeviceBase
    {
        public TargetType Recipient { get; set; } = TargetType.AllPlayers;
        public ItemLocation Location { get; set; } = ItemLocation.PlayerInventory;
        public InventoryAction InventoryAction { get; set; } = InventoryAction.ResetAll;
        public FullBackpackAction FullBackpackAction { get; set; } = FullBackpackAction.DropItem;
        public string Helmet { get; set; } = "None";
        public string Vest { get; set; } = "None";
        public string Backpack { get; set; } = "None";
        public string PrimaryWeapon1 { get; set; } = "None";
        public List<string> AttachmentsPrimaryWeapon1 { get; set; } = new();
        public bool UseInfiniteAmmoPrimaryWeapon1 { get; set; } = false;
        public bool UseReloadWithoutAmmoPrimaryWeapon1 { get; set; } = false;
        public bool UseAutoReloadPrimaryWeapon1 { get; set; } = true;
        public string PrimaryWeapon2 { get; set; } = "None";
        public List<string> AttachmentsPrimaryWeapon2 { get; set; } = new();
        public bool UseInfiniteAmmoPrimaryWeapon2 { get; set; } = false;
        public bool UseReloadWithoutAmmoPrimaryWeapon2 { get; set; } = false;
        public bool UseAutoReloadPrimaryWeapon2 { get; set; } = true;
        public string Handgun { get; set; } = "None";
        public List<string> AttachmentsHandgun { get; set; } = new();
        public bool UseInfiniteAmmoHandgun { get; set; } = false;
        public bool UseReloadWithoutAmmoHandgun { get; set; } = false;
        public bool UseAutoReloadHandgun { get; set; } = true;
        public string MeleeWeapon { get; set; } = "None";
        public List<string> OtherItems { get; set; } = new();

        public override DeviceType DeviceType => DeviceType.ItemProvide;
    }
}
