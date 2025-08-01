# Item Provide Device

![ItemProvide Icon](../images/DeviceIcons/Device_ItemProvide.png)

## Description

Directly give items to players.

## Basic

| Setting                                                | Default Value     | Type | Range | Description                                                      |
|--------------------------------------------------------|-------------------|------|-------|------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.           |
| [Recipient](../General/Common_Device_Settings.md#target)                     | All Players        | Option | Activating Player, All Players, Selected Team, Selected Player, Tagged Players | Specifies the target players.                     |
| Location                                               | Player Inventory  | Option | Player Inventory, Player Location | Where the item is provided.                        |
| Inventory Action                                       | Reset All         | Option | Reset All, Reset Inventory, Preserve All | Action to perform on inventory before providing item. |
| Full Backpack Action                                   | Drop Item         | Option | Drop Item, Do Not Provide | Action when backpack is full.                      |
| Helmet                                                 | None              | Item Selector | Helmet Items | Provided helmet item.                             |
| Vest                                                   | None              | Item Selector | Vest Items | Provided vest item.                               |
| Backpack                                               | None              | Item Selector | Backpack Items | Provided backpack item.                           |
| Primary Weapon 1                                       | None              | Item Selector | Weapon Items | Provided primary weapon 1.                        |
| Attachments (Primary Weapon 1)                         | None              | Item Selector | Attachment Items | Attachments for primary weapon 1.                 |
| Use Infinite Ammo (Primary Weapon 1)                   | False             | Boolean | True, False | Gives infinite ammo for primary weapon 1.         |
| Use Reload Without Ammo (Primary Weapon 1)             | False             | Boolean | True, False | Allows reload without ammo for primary weapon 1.  |
| Use Auto Reload (Primary Weapon 1)                     | True              | Boolean | True, False | Enables auto reload for primary weapon 1.         |
| Primary Weapon 2                                       | None              | Item Selector | Weapon Items | Provided primary weapon 2.                        |
| Attachments (Primary Weapon 2)                         | None              | Item Selector | Attachment Items | Attachments for primary weapon 2.                 |
| Use Infinite Ammo (Primary Weapon 2)                   | False             | Boolean | True, False | Gives infinite ammo for primary weapon 2.         |
| Use Reload Without Ammo (Primary Weapon 2)             | False             | Boolean | True, False | Allows reload without ammo for primary weapon 2.  |
| Use Auto Reload (Primary Weapon 2)                     | True              | Boolean | True, False | Enables auto reload for primary weapon 2.         |
| Handgun                                                | None              | Item Selector | Handgun Items | Provided handgun item.                            |
| Attachments (Handgun)                                  | None              | Item Selector | Attachment Items | Attachments for handgun.                          |
| Use Infinite Ammo (Handgun)                            | False             | Boolean | True, False | Gives infinite ammo for handgun.                  |
| Use Reload Without Ammo (Handgun)                      | False             | Boolean | True, False | Allows reload without ammo for handgun.           |
| Use Auto Reload (Handgun)                              | True              | Boolean | True, False | Enables auto reload for handgun.                  |
| Melee Weapon                                           | None              | Item Selector | Melee Items | Provided melee weapon.                            |
| Other Items                                            | None              | Item Selector | Ammunition Items, Use Items | Other provided items.                             |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Provide             | Triggered when the item is provided.                               |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Provide Item          | Provides the item to the target.                                   |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
