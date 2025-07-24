# Devices

## Description

Devices are tools that add logic and interaction to your game modes.
They enable dynamic gameplay elements such as triggers, spawn locations, items, and more.

Devices are a core element of any game mode to be created.  
Currently, there is a limit of 1000 devices in a single UGC map.

## Accessing the Device List

To access the device list:

- Press `P` to open the edit manager.
- In the **Object List** tab, navigate to the **Device** subtab.

<img src="images/Device_List.png" alt="Device List" style="max-height: 550px"/>

## Device Settings

Each device has multiple settings to configure its behavior, you can access these settings in two ways:

- Press `F` while looking at the device in the world.
- Press `[` to open the Event Manager, select the device you want to edit, and click **Edit**.

All devices have the following configuration sections:

<img src="images/Device_Settings.png" alt="Device List" style="max-height: 550px"/>

### Name

The name of the device, which defaults to its type and an incrementing number (e.g., `Player Spawn 1`).  
You can customize this name for clarity, limited to 30 alphanumeric characters.

---

### Basic

This tab contains all the main adjustable settings for the specific device.  
Some common settings are described [here](Common_Device_Settings.md).

---

### Change

This tab shows only the settings that you have changed from their default values, this allows for a quick review of your adjustments.

---

### Trigger

A trigger is an event from this device that can start an action on another device.

> If **this device** does `Trigger`, do `Action` on **another device**.

---

### Action

An action is a task that this device can perform when it receives a trigger from another device.

> Do `Action` on **this device** when a `Trigger` happens on **another device**.

---

*Note: A device can never Trigger an Action on itself.*

## Device List

| Device Icon | Device Name          | Description |
|-------------|----------------------|-------------|
| <img src="images/DeviceIcons/Device_ScoreManager.png" alt="drawing" width="50"/> | [Score Manager Device](Device_ScoreManager.md) | Manage score addition and subtraction. |
| <img src="images/DeviceIcons/Device_PlayerSpawn.png" alt="drawing" width="50"/> | [Player Spawn Device](Device_PlayerSpawn.md)   | Spawn and respawn players. |
| <img src="images/DeviceIcons/Device_PlayerEvent.png" alt="drawing" width="50"/> | [Player Event Device](Device_PlayerEvent.md)   | Set conditions related to players and teams. |
| <img src="images/DeviceIcons/Device_Mover.png" alt="drawing" width="50"/> | [Mover Device](Device_Mover.md)                | Move objects to a target location. |
| <img src="images/DeviceIcons/Device_AreaBlocking.png" alt="drawing" width="50"/> | [Area Blocking Device](Device_AreaBlocking.md) | Block area to restrict player movement. |
| <img src="images/DeviceIcons/Device_TriggerArea.png" alt="drawing" width="50"/> | [Trigger Area Device](Device_TriggerArea.md)   | Triggers when conditions are met within a designated area. |
| <img src="images/DeviceIcons/Device_AirDrop.png" alt="drawing" width="50"/> | [Air Drop Device](Device_AirDrop.md)           | Spawn AirDrop items at a specific location. |
| <img src="images/DeviceIcons/Device_PlayerTag.png" alt="drawing" width="50"/> | [Player Tag Device](Device_PlayerTag.md)       | Apply and remove player tags. |
| <img src="images/DeviceIcons/Device_RoundEvent.png" alt="drawing" width="50"/> | [Round Event Device](Device_RoundEvent.md)     | Set conditions for round-based events. |
| <img src="images/DeviceIcons/Device_Timer.png" alt="drawing" width="50"/> | [Timer Device](Device_Timer.md)                | Set an in-game timer next to an item. |
| <img src="images/DeviceIcons/Device_ItemSpawn.png" alt="drawing" width="50"/> | [Item Spawn Device](Device_ItemSpawn.md)       | Spawn items in a predetermined location. |
| <img src="images/DeviceIcons/Device_ItemProvide.png" alt="drawing" width="50"/> | [Item Provide Device](Device_ItemProvide.md)   | Directly give items to players. |
| <img src="images/DeviceIcons/Device_Teleport.png" alt="drawing" width="50"/> | [Teleport Device](Device_Teleport.md)          | Teleports players or objects to a specific location. |
| <img src="images/DeviceIcons/Device_BlueZone.png" alt="drawing" width="50"/> | [Blue Zone Device](Device_BlueZone.md)         | Create a damaged zone that shrinks over time. |
| <img src="images/DeviceIcons/Device_PlayerDamage.png" alt="drawing" width="50"/> | [Player Damage Device](Device_PlayerDamage.md) | Deal damage to players. |
| <img src="images/DeviceIcons/Device_Interaction.png" alt="drawing" width="50"/> | [Interaction Device](Device_Interaction.md)    | Allow players to interact with an object. |
| <img src="images/DeviceIcons/Device_DamageTrigger.png" alt="drawing" width="50"/> | [Damage Trigger Device](Device_DamageTrigger.md) | Triggers when damage is taken. |
| <img src="images/DeviceIcons/Device_PlayerStatus.png" alt="drawing" width="50"/> | [Player Status Device](Device_PlayerStatus.md) | Set or change player statuses. |
| <img src="images/DeviceIcons/Device_ChanceTrigger.png" alt="drawing" width="50"/> | [Chance Trigger Device](Device_ChanceTrigger.md) | Trigger event based on chance. |
| <img src="images/DeviceIcons/Device_RandomTrigger.png" alt="drawing" width="50"/> | [Random Trigger Device](Device_RandomTrigger.md) | Execute a trigger randomly from a predetermined list. |
| <img src="images/DeviceIcons/Device_ConquestArea.png" alt="drawing" width="50"/> | [Conquest Area Device](Device_ConquestArea.md) | Create an area that can be conquered. |
| <img src="images/DeviceIcons/Device_RedZone.png" alt="drawing" width="50"/> | [Red Zone Device](Device_RedZone.md)           | Configure red zone settings. |
| <img src="images/DeviceIcons/Device_VehicleSpawn.png" alt="drawing" width="50"/> | [Vehicle Spawn Device](Device_VehicleSpawn.md) | Spawn vehicles at a specific location. |
| <img src="images/DeviceIcons/Device_SpecialZone.png" alt="drawing" width="50"/> | [Special Zone Device](Device_SpecialZone.md)   | Create a special zone with unique effects. |
| <img src="images/DeviceIcons/Device_PlayerIcon.png" alt="drawing" width="50"/> | [Player Icon Device](Device_PlayerIcon.md)     | Display an icon above players. |
| <img src="images/DeviceIcons/Device_SuperJump.png" alt="drawing" width="50"/> | [Super Jump Device](Device_SuperJump.md)       | Enable players to jump higher via jump pads. |
| <img src="images/DeviceIcons/Device_Airplane.png" alt="drawing" width="50"/> | [Airplane Device](Device_Airplane.md)          | Put players inside an airplane at the beginning of the match. |
| <img src="images/DeviceIcons/Device_WeaponDamage.png" alt="drawing" width="50"/> | [Weapon Damage Device](Device_WeaponDamage.md) | Adjust the damage values of various weapons. |
| <img src="images/DeviceIcons/Device_BGM.png" alt="drawing" width="50"/> | [BGM Device](Device_BGM.md)                    | Configure background music settings. |
