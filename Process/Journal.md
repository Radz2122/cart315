# Game Analysis: Hades

Hades is an interesting game because of its dynamic combat system, which encourages experimentation through a mix of weapons and abilities, making each playthrough unique and engaging. The game's roguelike design, characterized by randomized levels and enemies, enhances replayability. This unpredictability keeps the gameplay fresh and encourages players to devise strategies based on their current resources. 

Hades also features a well-designed progression system that allows players to acquire permanent upgrades and unlocks, fostering a sense of ongoing improvement. To maintain balance, the level of difficulty escalates when players attain a specific number of upgrades. The game's narrative is seamlessly woven into the gameplay, with non-playable characters reacting to the player's progress and offering insights into the lore of the main character. However, Hades is not without its flaws. Some weapons and abilities lack balance, with certain ones being noticeably more powerful and others significantly weaker.

For future projects, some intriguing concepts to incorporate could include the randomization of abilities while still granting players autonomy in their gameplay style. This would necessitate a variety of weapons to accommodate different combat styles, such as close-range, long range, offensive, and defensive combat. Each weapon should also have upgrade options to ensure that players who favor a particular weapon can still enjoy a varied experience.


# Conceptualizing: Ideation process

## Initial brainstorm and problem statement:
How can we make a challenging puzzle game while keeping it engaging?
Puzzles-> layers-> steps->completion-> prize-> satisfaction-> solving-> challenge-> putting pieces together-> analyzing-> conclusion-> outcome

Challenge-> difficult-> clues-> constraints-> paths-> multiples ways to solve-> variety-> creativity-> loopholes-> hacks-> speedrun-> replayability

Engagement-> fun vs frustration-> trial and error-> loops

## Design values: 
Challenge-> mental challenge

Decision-making-> in puzzles (limited chances), or chosing routes

## Keyword for class activity: Layers
Idea  1: Layers and language
Made up language in layers-> steps to learning-> complexity

In this game concept, players explore a multi-dimensional world. Each dimension is linked, but to move to a new one, players must decipher the meaning of a special symbol in their current area. Clues guide them to discover new words. The ultimate goal is to collect all symbols and their definitions to communicate with a threatening entity endangering their land. 

Idea 2: Layers and Lost
Labyrinth-> Trial and error-> repetitive-> challenge-> patience

In this game concept, players explore a massive shifting labyrinth. As they complete missions or solve puzzles, the paths change dynamically. Visual cues guide them, but the overall environment is dark and atmospheric, creating a sense of distortion and disorientation. 

Idea 3: Layers and Puzzles
Complexity-> steps to solving-> solving across different levels-> one big puzzle

In this game concept, players descend into a bottomless pit (an ancient crater) and encounter puzzles along their journey. But here’s the twist: some puzzles are interconnected, and changes made for one puzzle may impact another. As players progress, they uncover the story of a forgotten civilization that once inhabited the pit.


# Prototyping Stage 1 

Initially, my focus with this prototype was to experiment with lighting effects. I aimed to create an immersive experience by dimming the game environment and restricting the player's vision to a small circular range. However, I also wanted to explore the possibility of dynamically restoring light during gameplay, a feature that I successfully implemented. Another aspect I wanted to assess was the use of popup dialogues. I designed dialogues to appear when players interacted with specific objects, such as the light switch that illuminates the room when activated. Visually, I constructed a dungeon-like room using online sprites for both the environment and characters. While the prototype's aesthetics lean towards the higher fidelity end, they will be worked on soon.

![prototype1sample1](https://github.com/Radz2122/cart315/assets/70171361/6cd11d1c-32db-47a8-a461-aba157f839a5)
![prototype1sample2](https://github.com/Radz2122/cart315/assets/70171361/ed50a96e-0e4b-4820-9e52-dc71852db123)
![prototype1sample3](https://github.com/Radz2122/cart315/assets/70171361/b14f2a5a-6f01-49f2-9e99-47ceaebce2c1)
![prototype1sample4](https://github.com/Radz2122/cart315/assets/70171361/49efbda3-0f6d-4ddf-919d-38c647c5eedf)

Feedback from testing highlighted an issue where it wasn't immediately clear that the light surrounding the character emanated from their "flame friend." Consequently, I plan to adjust the light tint in the next iteration. Despite this, the controls were deemed intuitive and will remain unchanged for now, although I intend to enhance the character's walking animations and overall smoothness.

The players were drawn to the pile of coins within the darkened room, validating my experiment to lure them with a potential trap, which proved successful.  Overall, I think I got the information I needed concerning the lighting, now I want to try integrating a puzzle into the next prototype.

# Prototyping Stage 2

For this experimental prototype, I aimed to create a moving maze level. Initially, I sketched out the concept on paper to test out various components. The maze incorporates several elements: a designated set of enemies highlighted in pink, two movable walls denoted by blue markings, and an exit that, indicated in purple (refer to Figure 1). To manipulate the walls and the exit, players must pull corresponding switches, color-coded to match each element. Thus, players navigate the maze, locating and activating switches to unlock doors and ultimately escape. Failure to trigger the switches and discover the exit prompts a notification (refer to Figure 2).

![figure1](https://github.com/Radz2122/cart315/assets/70171361/524c57e0-f8dd-42d2-9e2d-a44c6e00476c)
Figure 1.

 ![figure2](https://github.com/Radz2122/cart315/assets/70171361/169f1019-4ddc-43b4-8d01-781cbdc03350)
Figure 2.

During playtesting, I observed that when players had a full view of the maze, escaping and solving the puzzle became overly simple. To counteract this, I implemented a method to obstruct their vision: a piece of paper with a central cutout, allowing only partial visibility of the map (refer to Figure 3). This adjustment proved effective, as players now took longer to discover both the maze's exit and its switches. Notably, players were not provided with initial guidance; they were merely instructed to locate the maze's exit. To provide guidance akin to in-game pop-ups, I introduced cards at specific points during their progress (refer to Figure 4). For instance, upon reaching a switch, I handed them a "You unlocked a door" card, accompanied by an explanation of its significance.

![figure3](https://github.com/Radz2122/cart315/assets/70171361/3fb757fc-7d63-44d9-b5d5-1486368662df)
Figure 3.

![figure4](https://github.com/Radz2122/cart315/assets/70171361/aba2bd32-7331-43f5-b6b9-7e9b66b7f3a9)
Figure 4.

The primary purpose of this prototype was to test the maze, its various components, and its mechanics. Through testing, I gained valuable insights into its layout and was inspired to incorporate elements such as moving walls, which were not initially part of the design. Moving forward, my aim is to integrate these new ideas into Unity. I plan to focus on implementing the maze, enemies, and obstructed vision to observe how players navigate through it and to gauge the difficulty level effectively.

# Prototyping Stage 3
## Unity integration

In this iteration of the prototype, I've implemented the maze design into Unity. To enhance the overall design, I included background tiles. (See Figure 1) The coins positioned at the far right side of the map are the player's ultimate objective. To finish the puzzle and the game, the player has to navigate through the maze to reach these coins.

![prototype2-iteration1](https://github.com/Radz2122/cart315/assets/70171361/54f61fd9-a7a2-4428-892a-e75144ddbe4f)

Figure 1

I also introduced enemies from my previous prototype to evaluate their placements and lay the groundwork for a combat system in upcoming iterations. (Figure 2) Scaling objects posed a challenge, particularly ensuring the walls were large enough to obstruct certain paths without intersecting each other. Similarly, sizing the enemies was a hard task, as they couldn't be overly big, yet they needed to be noticeable enough for players to react promptly.

![prototype2-iteration-v2](https://github.com/Radz2122/cart315/assets/70171361/d2e146fb-4ccf-4130-a5b1-d5a57901b15f)
Figure 2

In the last phase, I experimented with utilizing light sources and their attributes to impede the player's visibility, similar to my earlier prototype. My objective was to assess its impact within a maze environment and whether it would overly complicate navigation. (See Figure 3) Following testing, it became apparent that players might struggle to navigate the maze, especially when the light source is limited. This could lead to frustration, considering the inherent complexity of maze navigation. To address this, for the next iteration, I plan to fine-tune the lighting properties or introduce a power-up mechanic that enhances visibility. Also, I want to start working on the combat system.

![prototype2-iteration](https://github.com/Radz2122/cart315/assets/70171361/f5fda19b-c002-40af-a2e6-5fce3564427e)
Figure 3

# Prototyping Stage 4
## Theme change, character tweaking and start of combat system

In this iteration, I tried to redo the design theme of my game, so I opted for a chess-inspired motif because of the background tiles. (See Figure 1) Enemies now take the form of chess pieces and adhere to chess movement rules. The player embodies a pawn trying to reach the opposite end of the chessboard to resurrect the queen. Accumulating a specific amount of currency is necessary to reach her, thus the player must gather all coins scattered throughout the maze before rescue becomes feasible. At present, player interaction with objects or foes is not possible.

![prot2it2](https://github.com/Radz2122/cart315/assets/70171361/f8da1148-ddfe-4758-b8db-7d36b8ac4474)

Figure 1

Additionally, I introduced a shooting mechanism where the player’s fire companion launches fireballs upon pressing the spacebar. (Refer to Figure 2) These projectiles eliminate enemy pieces. However, it is restricted to the X-axis for targeting, so I had to ensure that the enemy placement would adapt to the constraint.

![prot2it2projectile](https://github.com/Radz2122/cart315/assets/70171361/b9758d7b-d829-49fa-a41c-5ea81ea80568)

Figure 2 (the map is shown with light here to show the projectile but it will be dark).

Lastly, I implemented maze wall manipulation, experimenting with various configurations to control player access across the map while obstructing certain paths. This process was time-consuming, necessitating thorough consideration of potential player routes. Currently, the maze has two configurations (Figures 3 and 4), with walls adjustable between configurations via the Q key (for testing). Ultimately, players will engage with a lever in-game to shift the walls.

![prot2it2notiles](https://github.com/Radz2122/cart315/assets/70171361/e45e396c-01a8-4a8d-9ae2-333bba56c748)

Figure 3 (The maze tiles are hidden to show the objects on the map better).

![prot2it2mazevar2](https://github.com/Radz2122/cart315/assets/70171361/543e8940-a3de-4dfa-835d-f1783020ce05)

Figure 4

Looking ahead, my focus for the upcoming week would be refining the enemies, including their movement and their combat mechanics. Additionally, I want to integrate player interactions with the coins and the lever. If time permits, I would like to incorporate interactive items dropped by defeated enemies and rework the lighting, because the current one makes navigating the maze difficult. (Refer to Figure 5)

![prot2it2currentlook](https://github.com/Radz2122/cart315/assets/70171361/1b9724f9-9fe4-4094-b1c9-6ca0b181e34e)

Figure 5 featuring a hidden enemy on the left, the player, and some coins on the right.

# Presentation
## Link: https://xd.adobe.com/view/aef95ff6-55a3-4b28-a237-f245cb84db45-fbaa/?fullscreen

# Final prototype - Chessboard Maze: Pawn in Shining Armor 
(Refer to “Start” scene in GitHub for the final game version)

## The Pawn in Shining Armor is a puzzle strategy game where you have to travel across a maze on a chessboard as a pawn to free your queen on the other side. You win by collecting all the coins scattered across the maze to bribe the bishop guarding the queen and setting her free.

The final prototype of my game is fully functional. While it incorporates all vital gameplay elements, it lacks the visual finesse I had envisioned for it. The final version included the addition of a combat system, enemy pathfinding, maze shifting through levers, and new screens to signify victory or defeat. Further improvements included helpful pop-ups for player guidance, animated camera movements to reveal maze changes, and additional lighting to accentuate those changes.

The most challenging aspect of coding was animating the walls and synchronizing them with the camera's zoom. It required extensive research and the application of functions that were new to me. While my original concept included a simple minimap to assist players, I decided against it to maintain the game's difficulty level. It was rewarding to take on this challenge, as it significantly expanded my knowledge. Among the various aspects I explored, experimenting with Unity's lighting features was particularly enjoyable and aligned perfectly with my initial objectives for the project.

Post-presentation, I enhanced the game by integrating atmospheric music, sound effects, and constraints on lever interactions. I also introduced a start screen and additional pop-up messages. The feedback I received from a student suggested the intriguing idea of integrating turn-based chess strategies into the combat system, an aspect that piqued my interest for future updates.

Overall, I am pleased with the final prototype’s performance, having brought all the planned features to life and added extra elements. In the future, I would like to enhance the game's visual charm and improve its combat mechanics to make it even more engaging.

# Playtests
Throughout the prototype’s development, many playtests were done, yet two were particularly important in advancing the prototype. During the initial playtest, I observed a participant interacting with the game in stage four without prior instructions. They navigated the map but lacked direction because of no prompt for the space bar attack. Initially, I assigned wall movement to the Q button, since the lever mechanism wasn’t integrated yet. The participant remained unaware of its function until informed. Even then, the purpose of the wall movement was unclear as they couldn’t discern the changes, leading me to introduce a zoom-out feature and an auditory signal. Additionally, the absence of instructions on collecting coins prompted me to design an introductory screen with guidelines for the final version.

The second significant playtest occurred after my presentation but before the integration of previously mentioned features in the Final prototype section. In this session, I briefed the player on their objectives and the mechanics of firing fireballs. With this knowledge, they explored the map and quickly deducted that they need to operate the lever to navigate the maze and gather coins. As highlighted in the conclusion of my presentation, there were no limitations on lever usage, which allowed the player to activate it repeatedly in order to decipher the maze’s configuration. This observation led to the implementation of a usage timer. During an earlier playtest, I gained insight into a player’s ability to move while the camera is zoomed out, which was an unintended possibility that I then rectified to prevent in future gameplay.

# Link to final game build
https://github.com/Radz2122/cart315/blob/master/prototype/Build/prototype.exe



