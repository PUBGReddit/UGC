# PUBG UGC AI Knowledge Base

**Generated**: 2025-07-25  
**Purpose**: AI-optimized knowledge base for PUBG UGC (User-Generated Content) system

---

## CORE CONCEPTS

### UGC Map Specifications

- **Map Code**: MOD_Main
- **Dimensions**: 2x2 km total, 400x400m central island at 11m elevation
- **Boundaries**: Invisible walls on X/Y axes, height limit several km
- **Rendering**: 1km Z render distance, dynamic asset loading
- **Constraints**: 1000 device limit per map

### Game Structure

**Phases**: Creation → Standby (Before/After Spawn) → Round (Before/After Spawn)  
**Teams**: Configurable count and size  
**Rounds**: Target-based or time-limited with scoring system

---

## SETTINGS CONFIGURATION

### Rule Set Options

| Category | Setting | Default | Purpose |
|----------|---------|---------|---------|
| Mode | Mode Type | NONE | SHOOTING: BATTLE ROYALE/DEATHMATCH/CONQUEST, NON-SHOOTING: PARKOUR/TRAINING |
| Rounds | Round Count | 3 | Total rounds, winner needs >50% |
| Rounds | Target Score | 50 | Score to win round |
| Rounds | Time Limit | 600s | Round duration |
| Rounds | Warm-up Time | 10s | Pre-match warmup |
| Rounds | Round Warm-up | 5s | Pre-round warmup |
| Match | Team Count | 2 | Number of teams |
| Match | Team Size | 4 | Players per team |
| Match | Friendly Fire Ratio | 0 | Damage modifier |
| Match | Use DBNO | False | Down But Not Out system |
| Match | Camera View | FPS+TPS | View restrictions |
| Match | Use Respawn | False | Enable respawning |
| Match | Respawn Time | 3s | Respawn delay |
| Match | Invincibility Duration | 3s | Post-respawn protection |

### Game Options

- **Team Select**: Manual team assignment
- **Overflow Assign**: Handle extra players (Assign/Spectator/Observer)
- **Device Edit**: In-game device editing
- **Object Placement**: Free object placement
- **Fill Test Players**: AI player distribution
- **Observer Voice Chat**: Observer communication
- **Use Log**: Debug/record logging

---

## DEVICE SYSTEM

### Common Device Properties

**Activation Phases**:

- None: Event-triggered only
- Device Creation: Immediate activation
- Standby Before/After Spawn: Pre-game phases
- Round Start Before/After Spawn: Round phases

**Target Types**:

- All Players: Universal effect
- Selected Team: Team-specific
- Selected Player: Individual targeting
- Tagged Players: Tag-based filtering

### Device Categories & Functions

#### SPAWNING & PLACEMENT

| Device | Function | Key Features |
|--------|----------|-------------|
| Player Spawn | Player/respawn locations | Phase-based activation |
| Item Spawn | Predetermined item placement | Location-specific |
| Vehicle Spawn | Vehicle placement | Location-specific |
| Air Drop | Supply drop spawning | Targeted delivery |

#### PLAYER MANAGEMENT

| Device | Function | Key Features |
|--------|----------|-------------|
| Player Event | Player/team conditions | Event-based triggers |
| Player Damage | Direct damage dealing | Configurable damage |
| Player Status | Status modification | Buff/debuff application |
| Player Tag | Tag assignment/removal | Categorization system |
| Player Icon | Visual indicators | Duration-based display |

#### AREA CONTROL

| Device | Function | Key Features |
|--------|----------|-------------|
| Trigger Area | Condition-based activation | Area monitoring |
| Area Blocking | Movement restriction | Access control |
| Blue Zone | Shrinking damage zone | Time-based progression |
| Red Zone | Bombardment zone | Single instance limit |
| Special Zone | Custom effect areas | Unique mechanics |
| Conquest Area | Capturable territories | Team control |

#### INTERACTION & MECHANICS

| Device | Function | Key Features |
|--------|----------|-------------|
| Interaction | Object interaction | Player activation |
| Teleport | Location transport | Instant movement |
| Mover | Object movement | Target-based motion |
| Super Jump | Enhanced jumping | Jump pad mechanics |
| Timer | In-game timing | Visual countdown |

#### TRIGGERS & LOGIC

| Device | Function | Key Features |
|--------|----------|-------------|
| Chance Trigger | Probability-based events | Random activation |
| Random Trigger | Random selection | Predetermined options |
| Damage Trigger | Damage-based activation | Threshold monitoring |
| Round Event | Round-based conditions | Phase-specific |

#### SYSTEMS & UTILITIES

| Device | Function | Key Features |
|--------|----------|-------------|
| Score Manager | Score tracking | Min/max limits, targets |
| Item Provide | Direct item giving | Player inventory |
| Airplane | Match start transport | Initial positioning |
| Weapon Damage | Damage modification | Weapon-specific |
| BGM | Background music | Audio control |

---

## DEVICE TRIGGER-ACTION SYSTEM

### Core Principle

**IF** Device A triggers **THEN** Device B performs action

- Devices cannot trigger actions on themselves
- Cross-device event chain system
- Event-driven gameplay logic

### Common Trigger Types

- **Condition Met**: Goal achievement
- **Activate/Deactivate**: State changes
- **Player Events**: Entry/exit/interaction
- **Time Events**: Duration/countdown
- **Damage Events**: Health thresholds

### Common Action Types

- **State Control**: Activate/deactivate devices
- **Value Modification**: Change scores/stats
- **Position Control**: Teleport/move objects
- **Status Application**: Apply effects to players
- **System Control**: Reset/initialize states

---

## TECHNICAL CONSTRAINTS

### Performance Limits

- **Device Limit**: 1000 devices maximum
- **Red Zone**: Single instance only
- **Render Distance**: 1km Z-axis
- **Map Boundaries**: 2x2km with invisible walls

### File Management

- **Format**: .pugc files
- **Location**: %localappdata%/tslGame/Saved/UGC
- **Loading**: F10 in-game or P→LOAD
- **No restart required**: Hot-swappable files

### Access Controls

- **Device Settings**: F key or [ Event Manager
- **Edit Manager**: P key
- **Name Limits**: 30 alphanumeric characters
- **Host Permissions**: Device editing, object placement

---

## GAMEPLAY APPLICATIONS

### Mode Types

**Battle Royale**: Shrinking zones, survival mechanics  
**Deathmatch**: Respawn-based combat, score targets  
**Conquest**: Territory control, team objectives  
**Parkour**: Movement challenges, checkpoint systems  
**Training**: Skill development, practice scenarios

### Design Patterns

**Event Chains**: Trigger→Action sequences  
**Area Control**: Zone-based gameplay  
**Resource Management**: Item distribution  
**Team Dynamics**: Spawn coordination, objectives  
**Progressive Difficulty**: Escalating challenges

This knowledge base provides comprehensive coverage of PUBG UGC systems optimized for AI understanding and reference.