using Unity.VisualScripting;
using UnityEngine;

public class DesignReference
{
    //Lockdown - Tower Defense

    //Game Space: Types of Tiles

    //Middle: the area where the player is always located. it will be positioned in the middle of the screen

    //Paths: spaces existing in a straight line from the middle tile to the edge of the screen. 
    //they extend from the bottom, left, right, and top of the middle tile

    //the player is able to place towers on these spaces 

    //the Enemies are the entities that are able to move on these spaces

    //Walls: spaces that the player cannot place Towers on, nor can enemies move on these spaces

    //Towers:

    //tile gameObjects with code attached to them that allows them to perform a specific function that inhibits enemy 
    //movement

    //Enemies: GameObjects that can move on Path tiles towards the player

    //Enemy Logic:

    //at base, the enemy script will provide the functionality of moving towards the player, attacking towers
    //, death, and health related UI elements.

    //in children, Regular Zombies and Fast Zombies will vary based on inheriting their distinct speed variables
    //and health variables, as well as how they attack towers, such as the rate of attacks. These functionalities will

    //be implemented by State Machines: Moving, Attacking, Dead.

    //Regular zombies will move slower and attack less frequently than the Fast Zombies, but will have the most health

    //Fast zombies will move quickly and attack frequently, but will have less health

    //Movement: transforms with moveTowards, no Rigibodies

    //can be damaged by colliding with projectiles.

    //will not collide or push each other.

    //Projectiles: gameObjects aimed at enemies, spawned by Turret towers, and can only collide with enemies.

    //Damage value: 5 for now

    //Tower Design:

    //in base, all derived towers will have the ability to die, display their health, can be placed on any path
    //tile, takes away of alloted Energy when placed, and returns that amount when destroyed, can be retrieved from pressing a UI button, and perform a
    //specific function

    //in children, towers will vary based on functionality, and in their Health variable, which will vary in each
    //type of towers, as well as how many can be placed on paths.

    //Doors: these are basic towers that inhibit enemy movement, and possess the same amount of Health as Turrets
    //they also can be taken and placed more than turrets (2 Energy). their purpose is to simply take damage and halt 
    //enemy progress. The Turret Tower can shoot through these objects.

    //Turrets: these towers cannot inhibit enemy movement, possesses the same amount of Health as Doors, and
    //can only requires more energy to place (3 Energy). These towers possess a special functionaliy that allows
    //them to spawn projectiles, that, if they collide with an enemy, will decrease it's health by a specific amount
    //this mechanic will have a consistent firerate that will stop once the tower is destroyed. These Towers
    //will possess a child object that will be able to rotate and face towards the direction of enemies.

    //Shutters: These towers cannot be spawned and will only consist of 4 instances of this Tower. These Towers
    //will possess the most Health, and will surround the player on each side. Upon being damaged, they will send
    //out an event that emits a sound, alerting the player to being damaged. If one of the Shutters is destroyed
    //the player will be vulnerable to being damaged by an Enemy.

    //UI System:

    //Gameplay UI: 

    //toolBar: Shows buttons that allow player to select the two options for towers, the amount of energy they
    //possess, and a clock that counts down from two minutes upon the game starting, displays a health bar for player
    //health.

    //main menu: Title, Credits, Instructions, and exit functionality

    //Pause Menu: pauses gameplay and allows the player to resume, restart the level, or exit the stage

    //Victory stage: Upon staying alive when the timer reaches 0, the Victory screen will be activated

    //Game Over: upon the player object losing all of it's Health before the timer reaches 0:00

    //GameManager:

    //will maintain the amount of Energy the player can use to spawn towers (10, for now), which will possess
    //get and set properties, 

    //will be responsible for maintaining player health, through get and set properties that all

    //will tell the Object Spawners to recycle from their respective pools the enemies needed, or the towers needed

    //will utilize delegates, events, and Actions that will allow scripts to communicate with each other. all scripts
    //should disable these connections upon being disabled, and vice versa

    //Object Pools: will recycle assets, such as Towers, and Enemies, and will reset these assets to their 
    //standard health values, and spawn them correctly, so that they will navigate down the hallway

    //projectiles should be rest so as to allways maintain consistent fucntionality and fire towards an enemy.


    //Sound Direction: simple chiptune sounds and zombie sounds

    //Art Direction: Basic SNES graphics, anything less is hard to discern.
}
