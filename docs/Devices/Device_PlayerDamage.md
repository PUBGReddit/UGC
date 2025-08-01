# Player Damage Device

![PlayerDamage Icon](../../images/DeviceIcons/Device_PlayerDamage.png)

## Description

Deal damage to players.

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                      |
|----------------------------------------------|-------------------|------|-------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | | | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | Selected Player    | Options | Activating Team, Activating Player, All Players, Selected Team, Selected Player, Tagged Players | Specifies the target player.                      |
| Damage Amount                                | 10                | Number | 0-1000000 | Amount of damage dealt to the player.             |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Damage Player       | Triggered when the device deals damage to a player.                |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Damage Player         | Deals damage to the target player.                                  |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
