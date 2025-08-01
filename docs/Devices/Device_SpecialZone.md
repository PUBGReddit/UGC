# Special Zone Device

![SpecialZone Icon](../../images/DeviceIcons/Device_SpecialZone.png)

## Description

Create a special zone with unique effects.

## Notes

Only a single Special Zone Type can be active at any point in time.
Combination of differen Types can be active at the same time.

## Basic

| Setting                                                      | Default Value     | Type | Range | Description                                                                 |
|--------------------------------------------------------------|-------------------|------|-------|-----------------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.                                      |
| Special Zone Type                                            | Blizzard          | Option | None, Blizzard, Sandstorm, EMP | Type of special zone effect.                                                |
| Zone Repeat Time                                             | 1                 | Number | 1-1000 | Time interval to repeat the special zone.                                   |
| Next Zone Interval                                           | 1                 | Number | 1-1000 | Interval before the next special zone starts.                               |
| Zone Begin Delay                                             | 45                | Number | 1-1000 | Delay before the first special zone begins.                                 |
| Zone Duration                                                | 30                | Number | 1-1000 | Duration of the special zone.                                               |
| Zone Radius                                                  | 50000             | Number | 2000-1000000 | Radius of the special zone area.                                            |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Request Special Zone  | Requests activation of the special zone.                           |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
