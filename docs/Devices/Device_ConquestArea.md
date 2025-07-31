# Conquest Area Device

![ConquestArea Icon](../images/DeviceIcons/Device_ConquestArea.png)

## Description

Create an area that can be conquered.

## Basic

| Setting                                                      | Default Value     | Description                                                                 |
|--------------------------------------------------------------|-------------------|-----------------------------------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | The phase when the device is activated.                                      |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Specifies the target players.                                                |
| Show Area Boundary                                           | True              | Displays the boundary of the conquest area.                                  |
| Show Progress Messages                                       | True              | Shows progress messages during conquest.                                     |
| Show Ground Effects                                          | True              | Shows ground effects in the area.                                            |
| Show Icons                                                   | False             | Displays icons in the area.                                                  |
| Conquest Time (s)                                            | 10                | Time required to conquer the area.                                           |
| Conquest Time per Team Member (s)                            | 1                 | Additional time per team member for conquest.                                |
| Area Shape                                                   | Sphere            | Shape of the conquest area.                                                  |
| Sphere Radius                                                | 50                | Radius of the sphere area.                                                   |
| Area Empty Time Decrease (s)                                 | 1                 | Time decrease when area is empty.                                            |
| Maintain Conquered State                                     | True              | Maintains the conquered state after conquest.                                |
| Use Interval Trigger                                         | False             | Enables interval-based triggers.                                             |
| Interval Trigger (s)                                         | 1                 | Interval time for trigger (if enabled).                                      |
| Interval Trigger Count                                       | 3                 | Number of interval triggers (if enabled).                                    |
| Use Cooldown                                                 | True              | Enables cooldown after conquest.                                             |
| Conquest Cooldown (s)                                        | 1                 | Cooldown time after conquest.                                                |
| Use Conquer by Majority                                      | False             | Area is conquered by majority team.                                          |
| Use Neutral on Deactivate                                    | True              | Area becomes neutral when deactivated.                                       |

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
