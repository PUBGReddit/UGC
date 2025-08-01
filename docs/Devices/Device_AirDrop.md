# Air Drop Device

![AirDrop Icon](../images/DeviceIcons/Device_AirDrop.png)

## Description

Spawn AirDrop items at a specific location.

## Basic

| Setting                  | Default Value | Type | Range | Description |
|--------------------------|---------------|------|------|-------------|
| [Activation Phase](Common_Device_Settings.md#activation-phase)         | Device Creation | Options | | The phase when the device is activated. |
| Items                    |               | Item Selector| All| Items to be dropped. |
| Drop Location Type       | Center        | Option | Center, Device | Type of drop location. |
| Random X Offset Range    | 0             | Number | 0 - 100000 | Range for random X offset. |
| Random Y Offset Range    | 0             | Number | 0 - 100000 | Range for random Y offset. |
| Flight Time to Drop Location | 10        | Number | 1 - 3600 | Time for air drop to reach location. |

## Trigger

| Trigger                | Description |
|------------------------|-------------|
| On Air Drop            | Triggered when air drop occurs. |
| On Deactivate Device   | Triggered when the device is deactivated. |
| On Activate Device     | Triggered when the device is activated. |

## Action

| Action                | Description |
|-----------------------|-------------|
| Air Drop              | Initiates air drop. |
| Deactivate Device     | Disables the target device when this device is triggered. |
| Activate Device       | Enables the target device when this device is triggered. |
