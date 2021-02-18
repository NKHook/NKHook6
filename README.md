# NKHook6
NKHook6 is a high level and portable BTD6 API while not compromising versatility or ease of use.

## Purpose
Our plan here with NKHook6 is to provide novice programmers with the tools necessary to get them started.

## Why NKHook6
Most other mod "Apis" for Bloons TD 6 really don't do much for the mod maker. NKHook6 on the other hand, follows a standard set by the [NKHook6 API](https://github.com/NKHook/NKHook6-API) repository. Every other "api" at the time of writing this README does not have such a standard, and as a result leads to some rather... "interesting" "api" design. You may have noticed that I've put quotes around every time I've mentioned "api" when talking about other projects. This is because, in reality, most of these projects are true Apis in the sense that its a new layer for interecting with the game, rather its just a collection of functions and such to make work on the same level as the game code a little easier. **This doesn't help modders.** Since this structure doesn't actually help new modders create mods easily, not only are these "apis" not "true" apis, but they also fail at their intended goal of helping new (and experienced) modders create mods.

If you still don't understand what this means, take a look at this:
How NKHook6 works:
```
        | <-> NKHook6 API <-> NKHook6 Implementation <-> |
Mod <-> |                                                | <-> Game
        |-------------------(Optional)-------------------|
```
How other "apis" work:
```
       Game
Mod <-> |
       "Api"
```

The second graph how the "Api" puts itself on the same level as the game code, meaning you *must* have your mod interact with the game directly. This can be problematic for cases where the game updates and changes a large amount of functions or classes. The mod will be broken and need to be updated. On the other hand, the NKHook6 graph shows how the NKHook6 API and Implementation act as a middle man between the mod and the game, this was if the game updates a lot of things, NKHook6 can be updated and adapt to the new game changes without affecting the mod's code. This also doesn't limit the usability of the game's code directly either, if you want to use the game code with NKHook6, you still have all of that functionality exposed to your mod.

## Roadmap
|Feature|Supported|
|-------|---------|
|Tower Management|🔄|
|Bloon Management|🔄|
|Tower Implementations|🔄|
|Bloon Implementations|✔|
|Additional Behaviors|❌|
|Event Patches|🔄|
|Future Proofing|✔|
|Dynamic Asset Loading|❌|
|Network Interactions|❌|
|Custom GUI|❌|
|Best API|✔|

Key:
✔ - Completed
🔄 - In Progress
❌ - Incomplete/To Do/Unsupported

## Credits
Developers - https://github.com/DisabledMallis & https://github.com/KosmicShovel

## Contributing
We are constantly looking for new developers, if at any point you wish to contribute to the project you can do so by creating a [Pull Request](https://docs.github.com/en/free-pro-team@latest/github/collaborating-with-issues-and-pull-requests/about-pull-requests). If at any given point you contribute frequently we will consider inviting you to the team!
