# USWGame Change list

## New Featues

-	Risk checks for nearby tiles in diagonal directions now
-	Add key bindings for movement
    -	Arrows keys
    -	WASD keys
-	Added Menu.cs form
-	Add event handling for closing MainWindow.cs when the game is lost or won and reopening Menu.cs
-	Add a scoreboard to Menu.cs through file I/O operations
-	Add scoreboard sorting through ListNumberSort.cs
-	Add custom grid sizes through Menu.cs
-	Add a settings save function to Menu.cs through file I/O operations
-	Add re-adding of food when all current food is collected
-	Add round counter that increments when all current food is collected
-	When player dies, the player sprite’s depth alternates with the trap to show clearly that they landed on a trap
-	Add more traps as the round counter increases
-	Change all sprites and appearance of the game
-	Add a reveal tile that shows all traps in the game for a short duration
-	Add icon to game and it’s release executable
-	Add the following sounds to the game:
-	Movement sound
    -	Title background music
    -	Explosion sound
    -	Pickup sound
    -	New round sound
    -	Reveal tile sound

## Rewrites

-	Variables and methods renamed to meet C# & .NET naming conventions
-	Player movement rewrote to use less functions
-	Movement button functions rewrote to use a single function with arguments through tags
-	Risk method rewrote to use a list of relative coordinates
-	Reorganise class constructors and properties
-	Rewrite the AddLabel method’s behaviour to construct and then return labels
-	Add an AddLabel overload for passing in Bitmaps
-	Remove PlotTraps(), and PlotFood() in favour of using dictionaries containing labels with the Show() and Hide() methods
-	Add docstrings to major methods
