# Conquest Area Device

![ConquestArea Icon](../images/DeviceIcons/Device_ConquestArea.png)

## Description

Create an area that can be conquered.

## Basic

| Setting                                                      | Default Value     | Type | Range | Description                                                                 |
|--------------------------------------------------------------|-------------------|------|-------|-----------------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | Option | | The phase when the device is activated.                                      |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Option | All Players, Selected Team, Selected Player, Tagged Players | Specifies the target players.                                                |
| Show Area Boundary                                           | True              | Boolean | True, False | Displays the boundary of the conquest area.                                  |
| Show Progress Messages                                       | True              | Boolean | True, False | Shows progress messages during conquest.                                     |
| Show Ground Effects                                          | True              | Boolean | True, False | Shows ground effects in the area.                                            |
| Show Icons                                                   | False             | Boolean | True, False | Displays icons in the area.                                                  |
| Conquest Time (s)                                            | 10                | Number | 0-600 | Time required to conquer the area.                                           |
| Conquest Time per Team Member (s)                            | 1                 | Number | 0-10 | Additional time per team member for conquest.                                |
| Area Shape                                                   | Sphere            | Option |  Box, Cube, Sphere | Shape of the conquest area.                                                  |
| Area Empty Time Decrease (s)                                 | 1                 | Number | 0-3600 | Time decrease when area is empty.                                            |
| Maintain Conquered State                                     | True              | Boolean | True, False | Maintains the conquered state after conquest.                                |
| Use Interval Trigger                                         | False             | Boolean | True, False | Enables interval-based triggers.                                             |
| Interval Trigger (s)                                         | 1                 | Number | 0-3600 | Interval time for trigger (if enabled).                                      |
| Interval Trigger Count                                       | 3                 | Number | 0-1000000 | Number of interval triggers (if enabled).                                    |
| Use Cooldown                                                 | True              | Boolean | True, False | Enables cooldown after conquest.                                             |
| Conquest Cooldown (s)                                        | 1                 | Number | 0-3600 | Cooldown time after conquest.                                                |
| Use Conquer by Majority                                      | False             | Boolean | True, False | Area is conquered by majority team.                                          |
| Use Neutral on Deactivate                                    |  False             | Boolean | True, False | Area becomes neutral when deactivated.                                       |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Stalemate           | Triggered when a stalemate occurs in the conquest area.            |
| On Conquest Progress   | Triggered when conquest progress is made.                          |
| On Neutral             | Triggered when the area becomes neutral.                           |
| On Cooldown Finished   | Triggered when the cooldown period ends.                           |
| On Conquest Completed  | Triggered when the area is fully conquered.                        |
| On Interval Trigger    | Triggered at each interval if enabled.                             |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Activate X-Ray        | Activates X-Ray for the area.                                      |
| Show Map Icon         | Displays the map icon for the area.                                |
| Deactivate X-Ray      | Deactivates X-Ray for the area.                                    |
| Hide Map Icon         | Hides the map icon for the area.                                   |
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
