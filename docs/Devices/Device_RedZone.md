# Red Zone Device

![RedZone Icon](../images/DeviceIcons/Device_RedZone.png)

## Description

Configure red zone settings.

## Notes

Only a single Red Zone can be active at any point in time.

## Basic

| Setting                                                      | Default Value     | Type | Range | Description                                                                 |
|--------------------------------------------------------------|-------------------|------|-------|-----------------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.                                      |
| Repeat Time (s)                                              | 1                 | Number | 1-1000 | Time interval to repeat the red zone.                                        |
| Next Zone Interval (s)                                       | 1                 | Number | 1-1000 | Interval before the next red zone starts.                                    |
| Begin Delay (s)                                              | 45                | Number | 1-1000 | Delay before the first red zone begins.                                      |
| Duration (s)                                                 | 30                | Number | 1-1000 | Duration of the red zone.                                                    |
| Radius                                                       | 50000             | Number | 1-1000000 | Radius of the red zone area.                                                 |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Request Red Zone      | Requests activation of the red zone.                                |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
