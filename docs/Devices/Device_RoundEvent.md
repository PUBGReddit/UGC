# Round Event Device

![RoundEvent Icon](../images/DeviceIcons/Device_RoundEvent.png)

## Description

Set conditions for round-based events.
The Round Event Device automaticly sends out a trigger based on the setting Send Round Event's configuration.

## Basic

| Setting                        | Default Value                | Type | Range | Description                                      |
|--------------------------------|------------------------------|------|-------|--------------------------------------------------|
| Send Round Event               | Round Start After Spawn      | Option | Standby Before Spawn, Standby After Spawn, Round Start Before Spawn, Round Start After Spawn, Round Start After Delay, Round End | Determine whether this device sends out a round event. |
| Specific Round                 | All Rounds                   | Option | All Rounds, Specific Round | Specifies which round(s) the event applies to.    |

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
