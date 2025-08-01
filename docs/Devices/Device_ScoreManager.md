# Score Manager Device

![Score Manager Icon](../images/DeviceIcons/Device_ScoreManager.png)

## Description

Manage score addition and subtraction.

## Basic

| Setting                  | Default Value         | Type | Range | Description         |
|--------------------------|-----------------------|------|-------|---------------------|
| [Activation Phase](Common_Device_Settings.md#activation-phase)        | Device Creation       | Option | | The phase when the device is activated. |
| [Target](Common_Device_Settings.md#target)                  | All Players           | Option | | Specifies the target players. |
| Score                   | 1                     | Number | -9999-9999 | The initial score value. |
| Max Score               | 9999                  | Number | -9999-9999 | The maximum score limit. |
| Min Score               | -9999                 | Number | -9999-9999 | The minimum score limit. |
| Target Score            | 100                   | Number | -9999-9999 | The score required to achieve the target. |
| Enable Activation Limit | False             | Boolean | True, False | Whether activation limit is enabled. |

## Trigger

- **On Condition Met**
- **On Deactivate Device**
- **On Activate Device**

## Action

- **Reset Score**
- **Change Score**
- **Deactivate Device**
- **Activate Device**
