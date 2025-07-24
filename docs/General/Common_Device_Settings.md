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

The different game phases is documented more in detail [here](../General/GamePhases.md).

## Target

Set the target to which the effect is applied:

- **All Players**: Applies to all players.
- **Selected Team**: Applies only to the selected team.
- **Selected Player**: Applies only to the selected player.
- **Tagged Players**: Applies only to players with the specified tag.
