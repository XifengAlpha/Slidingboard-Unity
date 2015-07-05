# Slidingboard
## An open-source, modular, abstract skating game


**This document is not what you'd call good. It's a work in progress.**


Slidingboard is designed with ease of contribution in mind. New assets and prefabs can be submitted as pull requests, ideas can be posted as issues. The goal is to build a simple core game that can be expanded indefinitely. 


This game is very much a work in progress, simple things like an menus have not been implemented yet. See the issues for a full list of what we need, or try out the demo and you'll find out pretty quick. 


## The Game


This is an abstract game based on traversal games like Mirror's Edge, focused on exploration with some speedrun elements. The main influences are the game Zineth and the Counter Strike map surf_lt_omnific.


The player controls from the first person perspective. They can push themselves in any direction using the left-side controls. There is no upper limit to how fast you can go, but eventually you will not be able to interact with the environment. 


The distinguishing feature of the game is how steering works, which is somewhat similar to ice skating. Whether on the ground or in the air, rotating the player with the right-side controls causes their movement vector to rotate by the same amount. If you are skating or flying forward and you turn, you will end up skating in the new direction you are facing. If you are skating sideways, you will continue skating sideways, and likewise for skating backwards. This allows for a great deal of control. 


## Guiding principles 


### Player freedom 


The game is meant to be highly configurable. I want players to be able to set their own checkpoints, modify their physics, as much as possible let them do whatever they want. To that end, I've in some places prioritized freedom over ease of use, for example by allowing the player to turn all the way upside down, skate backwards, and skate fast enough to clip through walls. 


One major development goal is to have a Goat Simulator-style mutators system where players can add or remove functionality and maps. 


### Exploration 


The primary challenge of the game is, "how do I get from here to there?" and success is rewarded by accessing new areas to explore. The overall structure of the world will be similar to the game *World's Biggest Pac Man*, with each area having multiple exits to different other areas.


### Aesthetics


This game has deep roots in spectator gaming: the project lead is a let's player and speedrunner, and the game was inspired by a speedrun video. Having the game be very watchable is a big priority.


The end goal is for each location to have a coherent aesthetic, with an associated piece of music similar to the way that music changes based on location in the game HyperRogue.


The overall impression should be joyful, pleasant, and friendly. This doesn't mean it can't be challenging, but challenges should be presented as "good job you did something hard" and not as "you suck for not being able to do this."


## Contributing


### Levels
The easiest way to contribute is by building levels. Download the project, create a new scene, fill it with objects, and submit it as a pull request. Make sure you leave room for five exits, the prefabs for these are not built yet.


### Assets
More interesting shapes to skate along and more interesting decorations for our level-designers to use, music to go along with existing levels, and textures are all welcome. Prefab level elements are also very valuable.


### Mutators
One planned feature is the ability to add and remove components from the character object (whose name, by the way, is Mirabella): things like the ability to roll, alter gravity, basically anything that could possibly happen when you press a button is fair game.


### Housekeeping
We still need a lot of the essentials: entrances and exits that link up other scenes, basic menus, stuff like that.


## Style Hints


**Entrance/Exits** Every level should have five entrance/exits: one primary entrance, two primary goals, and two side-paths.


**Named vistas** are a design element that will play a prominent role in Slidingboard. They should be somewhat difficult to reach, and they should offer access to new areas, or provide an informative vantage point. Names should be abstract and friendly.


**Models** should tend toward the abstract. Currently everything is rectilinear blocks of flat color, new assets should at the very least be compatible with this. It's ok to suggest elements from the real world, but imitating them should be avoided. In all cases, interactivity should be the primary motive.


For example, a vertical element with branching platforms, colored green, might be suggestive of a tree, but should stand on its own as something interesting to skate on. This impression could be strengthened if skating on the object involved climbing it, for instance a conic spiral of bounce pads leading to the pinnacle. On the other hand, an asset that just plain looks like a tree would not be appropriate.


**Textures** should likewise be abstract. Keep them simple and geometric, and make sure they look good at distance. They should be compatible with the untextured, solid-color materials that are already in place.


**Music** should be loopable, but fairly long. It should generally not be aggressive. Each track should in some way complement the environment in which it plays. Tracks may be re-used to thematically link different areas that are conceptually linked in some other way, similar to how the different kinds of caves in HyperRogue have the same music.

Music should reflect the games emphasis on smoothness. Sectional transitions are appropriate, but should be gradual and not jarring.