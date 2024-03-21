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

Figure 1.
 
Figure 2.

During playtesting, I observed that when players had a full view of the maze, escaping and solving the puzzle became overly simple. To counteract this, I implemented a method to obstruct their vision: a piece of paper with a central cutout, allowing only partial visibility of the map (refer to Figure 3). This adjustment proved effective, as players now took longer to discover both the maze's exit and its switches. Notably, players were not provided with initial guidance; they were merely instructed to locate the maze's exit. To provide guidance akin to in-game pop-ups, I introduced cards at specific points during their progress (refer to Figure 4). For instance, upon reaching a switch, I handed them a "You unlocked a door" card, accompanied by an explanation of its significance.


Figure 3.

Figure 4.

The primary purpose of this prototype was to test the maze, its various components, and its mechanics. Through testing, I gained valuable insights into its layout and was inspired to incorporate elements such as moving walls, which were not initially part of the design. Moving forward, my aim is to integrate these new ideas into Unity. I plan to focus on implementing the maze, enemies, and obstructed vision to observe how players navigate through it and to gauge the difficulty level effectively.


