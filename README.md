# Jumper Frog
[itch.io](https://tornifrog.itch.io/homwork-4-2-ilan)

Created a simple game of jumper frog, the player needs to reach the other side of the road.

The game contains:

1. The player, that recieves input from the user to move. It has a rigid body and collider2D to check if it hits the cars or the finish line. [Player.cs](https://github.com/Tornifrog-Interactive/Homework-4_2-Ilan/blob/main/Assets/Scripts/Player.cs)

2. Spawner, we have 3 spanwers in the game, one for each road. It spawns the every few seconds at a desired speed. [Spawner.cs](https://github.com/Tornifrog-Interactive/Homework-4_2-Ilan/blob/main/Assets/Scripts/CarSpawner.cs)

3. Cars, Created a prefab of a car. It has a rigid body and collider2D to check if it hits the player. [Car](https://github.com/Tornifrog-Interactive/Homework-4_2-Ilan/blob/main/Assets/Scripts/Car.cs)

If the player reaches the other side, a "You Won" text will appear. If the player gets hit by a car a "Game Over" text will appear.

![lGllUgY](https://user-images.githubusercontent.com/74298243/230334930-c6fec48c-2bf4-4781-92c6-8d54ae6b8b68.png)


In the Player code, I check for collision between the cars / finish line to know which message to show.

In the car code, I made it so the cars are destroyed after 10 seconds.

In the Spawner code, I used the invoke repeating function instead of the IEnumerate (didn't work for me).
