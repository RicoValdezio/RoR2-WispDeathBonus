# Wisp Possession
Wisp variants now have a chance to grant a nearby monster a buff when they die, but there is also a small chance that the player may capture that buff.
Enemy buffs are 10x as strong as player buffs, but player buffs are permanent (items).
All buff chances and behaviors are configurable.

Known Bugs
------------
SoulWisps write the damage number that killed them to the log: Cause unknown.
Turrets and Drones may capture player buffs: Cause known, planned fix later.

Changelog
------------
1.1.0 - Fixed bugs related to updating to R2API v2.4.29
1.0.2 - Fixed a bug that would prevent multiplayer play (bytes be wierd, use ints instead)
1.0.1 - Fixed a bug that prevented itemized buffs from persisting between levels
1.0.0 - Initial upload

Installation
------------
Place the .dll in Risk of Rain 2\BepInEx\plugins

Contact
------------
If you have issues/suggestions, leave them on the github as an issue/suggestion.