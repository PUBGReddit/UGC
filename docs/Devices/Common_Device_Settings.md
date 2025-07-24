# Common Device Settings

## Activation Phase

Set the phase during which the device is activated:

- **None**: Activates only when triggered by an event.
- **Device Creation**: Activates immediately when the device is created.
- **Standby Before Spawn**: Activates during the standby phase before players spawn.
- **Standby After Spawn**: Activates during the standby phase after players spawn.
- **Round Start Before Spawn**: Activates at round start, before players spawn.
- **Round Start After Spawn**: Activates at round start, after players spawn.

### Game Phases

The game progresses through several distinct phases. Understanding these is crucial for configuring Device Activation Phases correctly.

#### Creation

This is the initialization phase of the game mode, where all objects are loaded into the map.

#### Standby

Once all objects are loaded, the game enters the Standby phase. This is often referred to as the "Warm-up Time" and has two sub-phases:

- **Before Spawn**: Activates during the standby phase before players spawn.
- **After Spawn**: Activates during the standby phase after players have spawned.

#### Round

A match can consist of multiple rounds. At the start of each round, the following sub-phases occur:

- **Before Spawn**: Activates at the beginning of a round, before players spawn.
- **After Spawn**: Activates at the beginning of a round, after players have spawned. This is often referred to as the "Round Warm-up Time"

> [!NOTE]  
> Activation phase is not to be confused with when the devices does something.  
> This setting is when the device itself is available to perform actions & trigger events.  

## Target

Set the target to which the effect is applied:

- **All Players**: Applies to all players.
- **Selected Team**: Applies only to the selected team.
- **Selected Player**: Applies only to the selected player.
- **Tagged Players**: Applies only to players with the specified tag.
