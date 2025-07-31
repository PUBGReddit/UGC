# Damage Trigger Device

![DamageTrigger Icon](../images/DeviceIcons/Device_DamageTrigger.png)

## Description

Triggers when damage is taken.

## Notes

Setup and use of this device seems to be broken at this time.

## Basic

| Setting                                      | Default Value     | Description                                      |
|----------------------------------------------|-------------------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Specifies the target players.                     |
| Damage Amount                                | 0                 | Amount of damage required to trigger.             |
| Hit Count                                    | 0                 | Number of hits required to trigger.               |
| Allowed Damage Types                         |   | Types of damage that can trigger the device.      |
| Use Point Damage                             | True              | Allows point damage to trigger the device.        |
| Use Radial Damage                            | True              | Allows radial damage to trigger the device.       |
| Select Object                                | Cube              | The object to be damaged.                         |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Hit Count Reached   | Triggered when the hit count is reached.                           |
| On Damage Amount Reached | Triggered when the damage amount is reached.                     |
| On Damaged             | Triggered when the object is damaged.                              |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Reset Hit Count       | Resets the hit count for the device.                                |
| Reset Damage Amount   | Resets the damage amount for the device.                            |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
