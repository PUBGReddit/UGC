# Mover Device

![Mover Icon](../images/DeviceIcons/Device_Mover.png)

## Description

Move objects to a target location.

## Notes

Movement can only be applied to certain devices:

- TriggerArea Device

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                                      |
|----------------------------------------------|-------------------|------|-------|------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation   | | | The phase when the device is activated.                          |
| Movement Direction                          | X: 0, Y: 0, Z: 0 | Number | -1, 0, 1 per axis | The direction in which the object will move.                     |
| Movement Duration (s)                       | 0                 | Number | 0-5400 | Duration of the movement in seconds.                             |
| Movement Distance (cm)                      | 0                 | Number | 0-10000 | Distance the object will move in centimeters.                    |
| Return to Start Position When Stopped        | False         | Boolean | True, False | If checked, returns the object to its start position when stopped.|

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Movement Stop       | Triggered when movement stops.                                      |
| On Movement Start      | Triggered when movement starts.                                     |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Stop Movement         | Stops the movement of the object.                                   |
| Start Movement        | Starts the movement of the object.                                  |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
