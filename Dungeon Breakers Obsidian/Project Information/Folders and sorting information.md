The naming convention for the folders is as following:
* All the folders will be named in the lower case.
* All the folder names should be just a one word when not applicable use the [snake case](https://en.wikipedia.org/wiki/Snake_case) naming convention | the main folder with the whole of the project is an exception

The Dungeon Breakers folder 
* **Dungeon Breakers Project** | Main folder for the project, it contains pretty much everything
	*  **addons** | Empty folder created by Godot, to be used in the future
	*  **assets** | A folder that contains all the graphics and in the future sounds
		* **logo** | it contains the logo in .svg format
		* **maps** | it contains all the files regarding maps/levels
			* **first_level** | it contains both the raw Dungeondraft file and the exported .webm file
		* **sprites** | it contains all the sprites of different entities
			* **exported** | it contains the .png files of all the sprites 
			* **raw** | it contains the .piskel files of all the sprites
	*  **scenes** | contains all the Godot related scene files (.tscn format)
		* **entity** | it contains the entities scence files like the "player" scene
		* **gameplay** | it contains the gameplay scence files like the first level
	*  **scripts** | it contains all the c# files
		* **entity** | it contains the c# files related to all the entities like the enemies, player, etc.
			* **player** | it contains the c# files related to the player like the movement controller.