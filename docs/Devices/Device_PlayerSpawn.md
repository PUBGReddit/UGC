# Player Spawn Device

![PlayerSpawn Icon](../images/DeviceIcons/Device_PlayerSpawn.png)

## Description

Spawn and respawn players.

## Note

`On Player Spawn` trigger is also triggered during Stand-By Phase.

## Basic

| Setting                        | Default Value     | Description                                      |
|--------------------------------|-------------------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Specifies the target players.                     |
| Default Spawn Location         | Checked           | Whether this is the default spawn location.       |
| Enemy Detection Range (cm)     | 0                 | Range to detect enemies near the spawn location.  |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Player Spawn        | Triggered when a player (re)spawns. |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
