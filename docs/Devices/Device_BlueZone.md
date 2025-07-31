# Blue Zone Device

![BlueZone Icon](../images/DeviceIcons/Device_BlueZone.png)

## Description

Create a damaged zone that shrinks over time.

## Basic

| Setting | Default Value | Description |
|----------------------------------------------|-------------------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation | The phase when the device is activated. |
| Blue Zone Shape | Circle | The shape of the blue zone. |
| Blue Zone Options | See below | Array of options for each blue zone phase. |

### Blue Zone Options

| Option                | Default Value | Description |
|-----------------------|---------------|--------------------------------------------------|
| Start Delay (s)       | 60            | Delay before the blue zone starts. |
| Warning Duration (s)  | 60            | Duration of the warning before shrinking. |
| Shrink Duration (s)   | 120           | Duration of the shrinking phase. |
| Damage per Second     | 2             | Damage dealt per second inside the blue zone. |
| Shrink Ratio          | 0.6           | Ratio to shrink the blue zone. |
| Expand Ratio          | 0.56          | Ratio to expand the blue zone. |
| Land Probability      | 70            | Probability of landing in the blue zone. |

## Trigger

| Trigger | Description |
|------------------------|--------------------------------------------------------------------|
| On Stop Blue Zone | Triggered when the blue zone stops. |
| On Start Blue Zone | Triggered when the blue zone starts. |
| On Resume Blue Zone | Triggered when the blue zone resumes. |
| On Pause Blue Zone | Triggered when the blue zone pauses. |
| On Deactivate Device | Triggered when the device is deactivated. |
| On Activate Device | Triggered when the device is activated. |

## Action

| Action | Description |
|-----------------------|--------------------------------------------------------------------|
| Stop Blue Zone | Stops the blue zone. |
| Start Blue Zone | Starts the blue zone. |
| Resume Blue Zone | Resumes the blue zone. |
| Pause Blue Zone | Pauses the blue zone. |
| Deactivate Device | Disables the target device when this device is triggered. |
| Activate Device | Enables the target device when this device is triggered. |
