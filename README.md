# Neurorama Pre-Alpha #

Neurorama is an open source, Creative Commons-licensed software to provide assets and binaries to aid in neuroanatomy and neuroliteracy education. Neurorama aims to make the job of learning neuroanatomy geometry and region functions more comprehendable and memorable through intuitive interactive models the student can explore at their own pace. Neurorama currently runs on desktop PCs, is built on Unreal Engine 4, and features VR compatibility (Oculus Rift and HTC Vive). You may [view a recent demo here](https://www.youtube.com/watch?v=dr8vEybB8vs).

[Compiled binaries for Windows 10 are now available at the itch.io page!](https://jellocube.itch.io/neurorama)

The software is written in the UE4 Blueprints visual scripting language for ease of accessibility. The paradigm of game objects and functions is explained below. This project is licensed as Creative Commons 3.0 Attribution-Sharealike, and utilizes Creative Commons assets from the Brain for Blender project (https://brainder.org/research/brain-for-blender/) as well as public domain models from NASA (https://nasa3d.arc.nasa.gov/models).

![Screenshot of desktop mode](/Screenshot.PNG)

## Instructions to run ##

This software requires the free [Unreal Engine 4](http://unrealengine.com/) to use. Due to it being in the prototyping phase, these instructions are best supplemented by your exploration of the source code:
- Right-click or use the right Oculus Touch A button to select on-screen elements.
- Use the space bar to cycle between model display models.
- Use 1 and 2 to switch between pawns in each level. Most of the pawns are currently in the process of being reworked and may be missing functionality, especially in the Flyaround level.

## Working index of application file structures ##

	/Content/
	   /Neurorama/
		  /Core/
			/Menus/
			/Player/
				/AnaglyphCamera/
				...custom dual cameras in the desktop player pawn project to L_Render and R_Render, which are combined in M_AnaglyphMat, which is then mapped onto the player pawn default camera as a postprocessing effect
					L_Render
					R_Render
					M_AnaglyphMat
				Pointers/
				...contains content related to VR hand controls/pointer controls
				TestingPawns/
				TestingVR/
			BP_Desktop_Pawn
			...pawn which inhabits walkable maps
			BP_Diorama_Master
			...Dioramas are collections of infoActors, and contain methods for retrieving and displaying infoActor information, passing it to the UI of the player's currently-possessed pawn.
			BP_GameInstance
			...Contains reference array of what InfoActors are in the scene; InfoActors add themselves to this array when play begins.
			BP_ia_Master
			...infoActors (abbreviated "ia") are actors in the scene that contain a mesh and some information about what the mesh represents (used for parts of the brain and their descriptions).
			BP_PlayerController
			...complex controller functions for all player pawns and game modes are stored here. manages "Display Modes," or the hiding of different parts of the brain upon player input. hidden infoActors are stored in an array here.
			BP_GameMode
			BP_GameState
			BP_infoInterfaces
			DT_iaData
			...datatable for all of the infoActors, containing all descriptive information
			S_iaStructure
			...data structure for the infoActor datatable
				 
		  /Geometry/
		  ...Contains all meshes and non-interactive scenic actors, which are not listed here in full, but whose categories are given
			/Brainstem/
			/Cortex/
			/Hindbrain/
			/Limbic/
			/Midbrain/
			/Visual/
			
		  /Import/
		  ...UE4 import directory, stray things that need to be sorted
		  
		  /InfoActors/
			...Contains all InfoActors, which are not listed here in full, but whose categories are given
			/Brainstem/
			/Cortex/
			/Hindbrain/
			/Limbic/
			/Midbrain/
			/Visual/
			BP_Diorama_Brain
			
		  /Maps/
			Title
			...The menu screen map
			Flyaround
			...A map where you fly around a giant model of the brain
			Exhibit
			...A map where you may explore the model brain on foot
			 
		  /MaterialLibrary/
			...Materials, textures
			/TextureMaps/
			/Testing/
			/Masks/
		  
		  /SFX/
			...Sound effects and audio
		  
		  /UX/
		  ...Assets related to UX and UI.

> Written with [StackEdit](https://stackedit.io/).
