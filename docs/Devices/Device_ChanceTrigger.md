# Chance Trigger Device

![ChanceTrigger Icon](../images/DeviceIcons/Device_ChanceTrigger.png)

## Description

Trigger event based on chance.

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                      |
|----------------------------------------------|-------------------|------|-------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.           |
| Probability                                  | 50                | Number | 0-100 | The chance (percentage) for the trigger to succeed.|

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Success             | Triggered when the chance succeeds.                                 |
| On Fail                | Triggered when the chance fails.                                    |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Trigger               | Triggers the target device.                                         |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
