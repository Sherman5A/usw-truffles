# USWGame Change list

## New Featues

- Risk checks for nearby tiles in diagonal directions now
- Add keybindings for movement
	- Arrows keys
	- WASD keys
- Added `Menu.cs` form
- Add event handling for closing `MainWindow.cs` when the game is lost or won and reopening `Menu.cs`
- Add a scoreboard to `Menu.cs` through file I/O operations
- Add scoreboard sorting through `ListNumberSort.cs`
- Add custom grid sizes through `Menu.cs`
- Add a settings save function to `Menu.cs` through file I/O operations
- Add condition when the user collects all of the food 
- When player died sprite death is swapped to show clearly they landed on a trap
- Add round counter
- Add repopulation of food
- Add more traps as round counter increases
- Change sprites and appearance of game
- Add sound to the game
	- Movement sound
	- Title background music
	- Explosion sound
	- Pickup sound
	- New round sound
	- Reveal tile sound
- Add a reveal tile
- Add icon to game

## Rewrites

- Variables and methods renamed to meet `C#` & `.NET` naming conventions
- Player movement rewrote to use less functions
- Movement button functions rewrote to use a single function with arguments
- Risk method rewrote to use a list of relative coordinates
- Reorganise class constructors properties
- Rewrite the `AddLabel` function to construct and return labels
- Add an `AddLabel` overload for passing Bitmaps
- Remove `PlotTraps()`, and `PlotFood()` in favour of using dictionaries containing labels with the `Show()` and `Hide()` methods
- Add docstrings to major methods
- Add sprites to movement arrows
