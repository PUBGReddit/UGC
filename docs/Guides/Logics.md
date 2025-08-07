## Give Every Player item(s) when they (re)spawn

**Goal:**  
Every player receives Item(s) immediately upon spawning.

### Devices Used

- **Player Spawn Device**
- **Item Provide Device**

### How It Works

1. The Player Spawn Device triggers on each player spawn or respawn.
2. This trigger sends a signal to the connected Item Provide Device.
3. The Item Provide Device provides item(s) to the activating player.

### Setup Instructions

1. **Place a Player Spawn Device**
2. **Place an Item Provide Device**
   - Set **Activation Phase** to: Round Start Before Spawn
   - Set **Item** to: Items wanted
   - Set **Target** to: Activating Player
3. **Connect the Devices**
   - From: Player Spawn Device → On Player Spawn
   - To: Item Provide Device → Provide Item

## Spawn Vehicles at the start of the round

**Goal:**  
Have all Vehicle Spawn devices spawn a vehicle when the round starts.

### Devices Used

- **Round Event Device**
- **Vehicle Spawn Device**

### How It Works

1. The Round Event Device triggers when the round starts.
2. This trigger sends a signal to the connected Vehicle Spawn Device.
3. The Vehicle Spawn Device spawns the vehicle.

### Setup Instructions

1. **Place a Spawn Vehicle Device**
2. **Place a Round Event Device**  
3. **Connect the Devices**
   - From: Round Event → On Condition Met
   - To: Vehicle Spawn → Spawn Vehicle
