using System;
using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.Unity;
using Harmony;
using Assets.Main.Scenes;
using MelonLoader;

namespace NKHook6_Impl.Other._TitleScreen
{
    [HarmonyPatch(typeof(TitleScreen), "Start")]
    internal class StartPatch
    {
        [HarmonyPostfix]
        internal static void Postfix(TitleScreen __instance)
        {
            List<MelonMod> loadedMods = MelonHandler.Mods;
            foreach (MelonMod mod in loadedMods)
            {
                if (mod is BTDModStart)
                {
                    BTDModStart modStart = (BTDModStart)mod;
                    modStart.onGameLoaded(Game.instance);
                }
            }
        }
    }
}