# TriggerArea Device

![TriggerArea Icon](../images/DeviceIcons/Device_TriggerArea.png)

# Name
Trigger Area Device

# Description

Triggers when conditions are met within a designated area.

# Basic

| Setting                                      | Default Value     | Description                                      |
|----------------------------------------------|-------------------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Specifies the target players.                     |
| Area Shape                                   | Sphere            | Shape of the trigger area.                        |
| Area Color                                   | White             | Color of the trigger area.                        |
| Sphere Radius (cm)                           | 50                | Radius of the sphere area in centimeters.         |
| Check Interval (s)                           | 0.1               | Interval for checking conditions in seconds.      |
| Trigger Type                                 | Both              | Type of trigger (Enter, Exit, or Both).           |

# Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Exit                | Triggered when a target exits the area.                            |
| On Enter               | Triggered when a target enters the area.                           |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

# Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Stop Movement         | Stops the movement of the object.                                   |
| Start Movement        | Starts the movement of the object.                                  |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
