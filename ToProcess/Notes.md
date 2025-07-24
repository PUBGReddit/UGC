# Parachutes
Players spawn without an parachute.
To provide this to players, just like in the game, the `Utility Parachute` item must be provided on each spawn.
When a player dies all equipment and inventory gets reset, resulting in loosing the Parachute equipment as well.

Best practice setup:
Item Provider Device
- Activation Phase: `Round Start Before Spawn`
- Inventory Action: `Preserve All`
- Other Items: `Utility Parachute`

This setup will ensure all players recieve the `Utility Parachute` at the start of each (re)spawn.


# Performance

Can cause crashes:

Over usage of Smokes, by enabling Infitine Ammo on the M79 (Smoke Gun), a single player can spam smokes. Which will result in an eventual crash of the client.
Only applicable if you are visible looking at the smokes / in proximity.



