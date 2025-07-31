# Game Phases

The game progresses through several distinct phases. Understanding these is crucial for configuring Device Activation Phases correctly.

## Creation

This is the initialization phase of the game mode, where all objects are loaded into the map.
If Devices are configured to be Activated during **Device Creation**, this is where they will be actived.

## Standby

Once all objects are loaded, the game enters the Standby phase. This is often referred to as the "Warm-up Time" and has two sub-phases:

- **Before Spawn**: Activates during the standby phase before players spawn.
If Devices are configured to be Activated during **Standby Before Spawn**, this is where they will be actived.
- **After Spawn**: Activates during the standby phase after players have spawned.
If Devices are configured to be Activated during **Standby After Spawn**, this is where they will be actived.

## Round

A match can consist of multiple rounds. At the start of each round, the following sub-phases occur:

- **Before Spawn**: Activates at the beginning of a round, before players spawn.
 If Devices are configured to be Activated during **Round Start After Spawn**, this is where they will be actived.
- **After Spawn**: Activates at the beginning of a round, after players have spawned. This is often referred to as the "Round Warm-up Time"
 If Devices are configured to be Activated during **Round Start After Spawn**, this is where they will be actived.
 