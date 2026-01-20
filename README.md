[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
Ruixuan Pan, she/her  


In the MG2 breakdown activity, I planned to split the game into several main systems: player movement and jumping, coin spawning, scoring, and UI. This plan helped me stay organized while writing the code and setting up the Unity scene.  

For player movement, I used a Player script to handle jumping. In the Update() method, the player jumps when the Space key is pressed. To prevent double jumping, I added a ground check using a GroundCheck Transform and Physics2D.OverlapCircle(), so the player can only jump when touching the ground. The Player GameObject uses a Rigidbody2D and a CapsuleCollider2D to handle physics and collisions smoothly.  

To make the game infinite, I created a CoinSpawner script and attached it to a Spawner GameObject. This script uses a coroutine to continuously spawn coins with a random delay between each spawn. All coins are spawned at the same height to keep gameplay consistent and predictable, a small change from my original plan to make the game feel easier to control. For scoring, I added a CoinPickup script to the coin prefab. The coin has a trigger collider, and when the player touches it, the coin is destroyed and the score increases. The score is displayed on screen using a Canvas with a TextMeshPro text object (PointText), which updates as coins are collected.
## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
