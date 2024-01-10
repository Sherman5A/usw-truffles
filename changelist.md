# USWGame Changelist

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
- Add a settings save function to `Menu.cs` through file I/O operatons
- Add condition when the user collects all of the food 
- When player died sprite death is swapped to show clearly they landed on a trap
- Add round counter
- Add repopulation of food
- Add more traps as rounds increase

## Rewrites

- Variables and methods renamed to meet `C#` & `.NET` naming conventions
- Player movement rewrote to use less functions
- Movement button functions rewrote to use a single function with arguments
- Risk method rewrote to use a list of relative coordinates
- Reorganise constructor and class properties
- Rewrite the `AddLabel` function
- Add an `AddLabel` overload for passing Bitmaps
- Remove `PlotTraps()`, and `PlotFood()` in favour using `Show()` and `Hide()` with `Label` within the `Dictionary` class
- Add docstrings to major methods
- Add sprites to arrows
