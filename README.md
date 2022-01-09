# FixUIXButton

A [NeosModLoader](https://github.com/zkxs/NeosModLoader) mod for [Neos VR](https://neos.com/) that adds a button to RectTransforms that refreshes the component by setting it's registered canvas to null and then calling the RegisterCanvas() method.<br>
Doing this seems to force the uix components to refresh and fix themselves after breaking.

## Installation
1. Install [NeosModLoader](https://github.com/zkxs/NeosModLoader).
1. Place [FixUIXButton.dll](https://github.com/art0007i/FixUIXButton/releases/latest/download/FixUIXButton.dll) into your `nml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\NeosVR\nml_mods` for a default install. You can create it if it's missing, or if you launch the game once with NeosModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Neos logs.