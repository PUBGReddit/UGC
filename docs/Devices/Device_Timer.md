# Timer Device

![Timer Icon](../.images/DeviceIcons/Device_Timer.png)

## Description

Set an in-game timer next to an item.

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                      |
|----------------------------------------------|-------------------|------|-------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.           |
| Interval (s)                                 | 1                 | Number | 1-5400 | The interval in seconds for the timer.            |
| Repeat Count                                 | 1                 | Number | 0-999 | Number of times the timer repeats.                |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Time Reached        | Triggered when the timer reaches the set interval.                  |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Stop Timer            | Stops the timer.                                                    |
| Start Timer           | Starts the timer.                                                   |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
