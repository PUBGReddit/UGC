# Player Tag Device

![PlayerTag Icon](../.images/DeviceIcons/Device_PlayerTag.png)

## Description

Apply and remove player tags.

## Basic

| Setting            | Default Value      | Type | Range | Description                       |
|--------------------|-------------------|------|-------|-----------------------------------|
| [Activation Phase](Common_Device_Settings.md#activation-phase)         | Device Creation | Option | | The phase when the device is activated. |
| [Target](../General/Common_Device_Settings.md#target)                     | Activation Team        | Option | Activating Team, Activating Player, All Players, Selected Team, Selected Player, Tagged Players | Specifies the target players.                     |
| Tag                |                   | Text | | The tag to apply or remove.       |

## Trigger

| Trigger                | Description                       |
|------------------------|-----------------------------------|
| On Deactivate Device   | Triggered when device deactivates |
| On Activate Device     | Triggered when device activates   |

## Action

| Action           | Description                                 |
|------------------|---------------------------------------------|
| Remove Tag       | Removes the specific tag from the target.              |
| Clear All Tags   | Removes all tags from the target.           |
| Add Tag          | Applies a tag to the target.                   |
| Deactivate Device| Deactivates the device.                     |
| Activate Device  | Activates the device.                       |
