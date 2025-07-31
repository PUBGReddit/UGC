# Super Jump Device

![SuperJump Icon](../images/DeviceIcons/Device_SuperJump.png)

## Description

Enable players to jump higher via jump pads.

## Basic

| Setting                                      | Default Value     | Description                                      |
|----------------------------------------------|-------------------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.           |
| Upward Speed Ratio                           | 200               | The ratio of upward speed applied to the jump.    |
| Type                                         | Caller Up         | The type of jump applied.                         |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Jump Started        | Triggered when a jump is started.                                  |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Launch                | Launches the player with the configured jump.                      |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
