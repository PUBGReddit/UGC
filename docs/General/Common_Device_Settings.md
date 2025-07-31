# Common Device Settings

## Activation Phase

Set the phase during which the device is activated:

- **None**: Activates only when triggered by an event.
- **Device Creation**: Activates immediately when the device is created.
- **Standby Before Spawn**: Activates during the standby phase before players spawn.
- **Standby After Spawn**: Activates during the standby phase after players spawn.
- **Round Start Before Spawn**: Activates at round start, before players spawn.
- **Round Start After Spawn**: Activates at round start, after players spawn.

> [!NOTE]  
> Activation phase is not to be confused with when the devices does something.  
> This setting is when the device itself is available (powered ON) to perform actions & trigger events.  

Activation Phases only determine when the device becomes active, not when it performs an action or triggers.
Setting Activation Phase to Device Creation does NOT automatic trigger devices when the match starts.
If a Device receives a trigger to active it's Action, and the device is not yet Activated it will not do anything.
A device MUST be active, either by phase, or a dedicated `Activate Device` Trigger before it can perform any Action.

## Target

Set the target to which the effect is applied:

- **All Players**: Applies to all players.
- **Selected Team**: Applies only to the selected team.
- **Selected Player**: Applies only to the selected player.
- **Tagged Players**: Applies only to players with the specified tag.
