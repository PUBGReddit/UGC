# Item Provide Device

![ItemProvide Icon](../images/DeviceIcons/Device_ItemProvide.png)

## Description

Directly give items to players.

## Basic

| Setting                                                | Default Value     | Description                                                      |
|--------------------------------------------------------|-------------------|------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Specifies the target players.                     |
| Location                                               | Player Inventory  | Where the item is provided.                        |
| Inventory Action                                       | Reset All         | Action to perform on inventory before providing item. |
| Full Backpack Action                                   | Drop Item         | Action when backpack is full.                      |
| Helmet                                                 | None              | Provided helmet item.                             |
| Vest                                                   | None              | Provided vest item.                               |
| Backpack                                               | None              | Provided backpack item.                           |
| Primary Weapon 1                                       | None              | Provided primary weapon 1.                        |
| Attachments (Primary Weapon 1)                         | None              | Attachments for primary weapon 1.                 |
| Use Infinite Ammo (Primary Weapon 1)                   | False             | Gives infinite ammo for primary weapon 1.         |
| Use Reload Without Ammo (Primary Weapon 1)             | False             | Allows reload without ammo for primary weapon 1.  |
| Use Auto Reload (Primary Weapon 1)                     | True              | Enables auto reload for primary weapon 1.         |
| Primary Weapon 2                                       | None              | Provided primary weapon 2.                        |
| Attachments (Primary Weapon 2)                         | None              | Attachments for primary weapon 2.                 |
| Use Infinite Ammo (Primary Weapon 2)                   | False             | Gives infinite ammo for primary weapon 2.         |
| Use Reload Without Ammo (Primary Weapon 2)             | False             | Allows reload without ammo for primary weapon 2.  |
| Use Auto Reload (Primary Weapon 2)                     | True              | Enables auto reload for primary weapon 2.         |
| Handgun                                                | None              | Provided handgun item.                            |
| Attachments (Handgun)                                  | None              | Attachments for handgun.                          |
| Use Infinite Ammo (Handgun)                            | False             | Gives infinite ammo for handgun.                  |
| Use Reload Without Ammo (Handgun)                      | False             | Allows reload without ammo for handgun.           |
| Use Auto Reload (Handgun)                              | True              | Enables auto reload for handgun.                  |
| Melee Weapon                                           | None              | Provided melee weapon.                            |
| Other Items                                            | None              | Other provided items.                             |

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
