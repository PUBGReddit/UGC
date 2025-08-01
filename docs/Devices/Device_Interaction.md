# Interaction Device

![Interaction Icon](../images/DeviceIcons/Device_Interaction.png)

## Description

Allow players to interact with an object.

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                      |
|----------------------------------------------|-------------------|------|-------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Option | All Players, Selected Team, Selected Player, Tagged Players | Specifies the target players.                     |
| Interaction Duration                         | 5                 | Number | 0-3600 | Duration of the interaction in seconds.           |
| Restrict Movement                            | False             | Boolean | True, False | Restricts player movement during interaction.     |
| Select Object                                | Controller        | Option | Controller, Computer, Device, Generator, Pot | The object to be interacted with.                 |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Start Interact      | Triggered when a player starts interacting with the object.         |
| On Finish Interact     | Triggered when a player finishes interacting with the object.       |
| On Cancel Interact     | Triggered when a player cancels the interaction.                   |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
