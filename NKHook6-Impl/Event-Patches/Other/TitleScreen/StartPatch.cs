using System;
using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.Unity;
using Harmony;
using Assets.Main.Scenes;
using MelonLoader;
using NKHook6.API;

namespace NKHook6_Impl.Other._TitleScreen
{
    [HarmonyPatch(typeof(TitleScreen), nameof(TitleScreen.Start))]
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
                    modStart.OnModLoaded();
                }
            }
        }
    }
}