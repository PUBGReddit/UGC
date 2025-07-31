# Round Event Device

![RoundEvent Icon](../images/DeviceIcons/Device_RoundEvent.png)

## Description

Set conditions for round-based events.
The Round Event Device automaticly sends out a trigger based on the setting Send Round Event's configuration.

## Basic

| Setting                        | Default Value                | Description                                      |
|--------------------------------|------------------------------|--------------------------------------------------|
| Send Round Event               | Round Start After Spawn      | Determine whether this device sends out a round event. Options: Standby Before Spawn - Activates during the standby phase before players spawn; Standby After Spawn - Activates during the standby phase after players spawn; Round Start Before Spawn - Activates at round start, before players spawn; Round Start After Spawn - Activates at round start, after players spawn; Round Start After Delay - Activates after a delay following the round start; Round End - Activates when the round ends. |
| Specific Round                 | All Rounds                   | Specifies which round(s) the event applies to.    |

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
