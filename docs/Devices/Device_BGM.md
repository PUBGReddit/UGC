# BGM Device

![BGM Icon](../images/DeviceIcons/Device_BGM.png)

## Description

Configure background music settings.

## Basic

| Setting                                                    | Default Value      | Description                                                      |
|------------------------------------------------------------|--------------------|------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation      | The phase when the device is activated.                          |
| Select BGM                                                 | BGM_Landmark_01    | The BGM track to play when the device is activated.              |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Stop BGM            | Triggered when the BGM is stopped.                                 |
| On Speed Up            | Triggered when the BGM speed is increased.                         |
| On Slow Down           | Triggered when the BGM speed is decreased.                         |
| On Resume BGM          | Triggered when the BGM resumes playing.                            |
| On Reset Volume        | Triggered when the BGM volume is reset.                            |
| On Reset Speed         | Triggered when the BGM speed is reset.                             |
| On Play BGM            | Triggered when the BGM starts playing.                             |
| On Pause BGM           | Triggered when the BGM is paused.                                  |
| On Lower Volume        | Triggered when the BGM volume is lowered.                          |
| On All Reset           | Triggered when all BGM settings are reset.                         |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Stop BGM              | Stops the BGM.                                                     |
| Speed Up              | Increases the BGM speed.                                           |
| Slow Down             | Decreases the BGM speed.                                           |
| Resume BGM            | Resumes the BGM playback.                                          |
| Reset Volume          | Resets the BGM volume.                                             |
| Reset Speed           | Resets the BGM speed.                                              |
| Play BGM              | Starts playing the BGM.                                            |
| Pause BGM             | Pauses the BGM.                                                    |
| Lower Volume          | Lowers the BGM volume.                                             |
| All Reset             | Resets all BGM settings.                                           |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
