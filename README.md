# Neurorama Pre-Alpha Release 12 #

Neurorama is an open source, Creative Commons-licensed software to provide assets and binaries to aid in neuroanatomy and neuroliteracy education. Neurorama aims to make the job of learning neuroanatomy geometry and region functions more comprehendable and memorable through intuitive interactive models the student can explore at their own pace. Neurorama currently runs on desktop PCs, is built on Unreal Engine 4, and features VR compatibility (Oculus Rift and HTC Vive). You may [view a recent demo here](https://www.youtube.com/watch?v=dr8vEybB8vs).

The software is written in the UE4 Blueprints visual scripting language for ease of accessibility. The paradigm of game objects and functions is explained below. This project is licensed as Creative Commons 3.0 Attribution-Sharealike, and utilizes Creative Commons assets from the Brain for Blender project (https://brainder.org/research/brain-for-blender/) as well as public domain models from NASA (https://nasa3d.arc.nasa.gov/models).

![Screenshot of desktop mode](/Screenshot.PNG)

## Instructions to run ##

This software requires the free [Unreal Engine 4](http://unrealengine.com/) to use. Due to it being in the prototyping phase, these instructions are best supplemented by your exploration of the source code:
- Right-click or use the right Oculus Touch A button to select on-screen elements.
- Use the space bar to cycle between model display models.
- Use 1 and 2 to switch between pawns in each level. Most of the pawns are currently in the process of being reworked and may be missing functionality, especially in the Flyaround level.

## Working index of application file structures ##

    /Content
       /Neurorama
          /Blueprints/
          ...Nothing currently.
          /Core/
             BP_GameInstance
             ...Contains reference array of what InfoActors are in the scene; InfoActors add themselves to this array when play begins.
             BP_PlayerController
             ...complex controller functions for all player pawns and game modes are stored here. manages "Diplay Modes," or the hiding of different parts of the brain upon player input. hidden infoActors are stored in an array here.
          /FX/
          ...Contains assets related to audio and visual effects.
          /Geometry/
          ...Contains all meshes and non-interactive scenic actors.
          /Import/
          ...Default UE4 import directory
          /InfoActors/
             BP_ia_* (InfoActors)
             ...infoActors are actors in the scene that contain a mesh and some information about what the mesh represents (used for parts of the brain and their descriptions).
             BP_Diorama_*
             ...Dioramas are collections of infoActors, and contain methods for retrieving and displaying infoActor information, passing it to the UI of the player's currently-possessed pawn.
          /Maps/
             TitleMenu
             ...The menu screen map.
             FlightMap
             ...A map where you fly around a giant model of the brain.
             ExhibitMap
             ...A map where you may explore the model brain on foot.
          /MaterialLibrary/
          ...Materials, textures, and Allegorithmic Substance assets used in the project.
          /UX/
          ...Assets related to UX and UI.

> Written with [StackEdit](https://stackedit.io/).
