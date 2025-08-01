# Player Event Device

![PlayerEvent Icon](../images/DeviceIcons/Device_PlayerEvent.png)

## Description

Set conditions related to players and teams.

## Basic

| Setting                                      | Default Value     | Type | Range | Description                                      |
|----------------------------------------------|-------------------|------|-------|--------------------------------------------------|
| [Activation Phase](../General/Common_Device_Settings.md#activation-phase) | Device Creation    | | | The phase when the device is activated.           |
| [Target](../General/Common_Device_Settings.md#target)                     | All Players        | Options | All Players, Selected Team, Selected Player, Tagged Players | Specifies the target players.                     |
| Trigger on Spawn                            | False         | Boolean | True, False | Triggers when a player spawns.                    |
| Trigger on Score Gain                       | False         | Boolean | True, False | Triggers when a player gains score.               |
| Trigger on Score Loss                       | False         | Boolean | True, False | Triggers when a player loses score.               |
| Trigger on Enemy Kill                       | False         | Boolean | True, False | Triggers when a player kills an enemy.            |
| Trigger on Headshot Kill                    | False         | Boolean | True, False | Triggers when a player kills an enemy with a headshot. |
| Trigger on Player Icon Enemy Kill           | False         | Boolean | True, False | Triggers when a player kills an enemy with a player icon. |
| Trigger on Final Enemy Kill                 | False         | Boolean | True, False | Triggers when a player kills the final enemy.     |
| Trigger on Death by Enemy                   | False         | Boolean | True, False | Triggers when a player dies by an enemy.          |
| Trigger on Headshot Death                   | False         | Boolean | True, False | Triggers when a player dies by a headshot.        |
| Trigger on Death by Player Icon Enemy       | False         | Boolean | True, False | Triggers when a player dies by a player icon enemy. |
| Trigger on Final Death                      | False         | Boolean | True, False | Triggers when a player dies for the final time.   |
| Trigger on Enemy DBNO                       | False         | Boolean | True, False | Triggers when a player puts an enemy into DBNO (Down But Not Out). |
| Trigger on DBNO by Enemy                    | False         | Boolean | True, False | Triggers when a player is put into DBNO by an enemy. |
| Trigger on Last Survival                    | False         | Boolean | True, False | Triggers when a player is the last survivor.      |

## Trigger

| Trigger                | Description                                                        |
|------------------------|--------------------------------------------------------------------|
| On Condition Met       | Triggered when the set condition is met.                           |
| On Deactivate Device   | Triggered when the device is deactivated.                          |
| On Activate Device     | Triggered when the device is activated.                            |

## Action

| Action                | Description                                                        |
|-----------------------|--------------------------------------------------------------------|
| Deactivate Device     | Disables the target device when this device is triggered.           |
| Activate Device       | Enables the target device when this device is triggered.            |
