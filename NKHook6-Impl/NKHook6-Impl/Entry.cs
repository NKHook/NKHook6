using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Assets.Main.Scenes;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using Assets.Scripts.Unity.UI_New.Main;
using Harmony;
using MelonLoader;
using NKHook6.API.Events;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl
{
    public class Entry : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("Starting NKHook6 API Implementation");

            new EventRegistry(); //Initialize EventRegistry

            Logger.Log("Google translate of NKHook6 API to TARGET has begun".Replace("TARGET", "BloonsTD6"));
        }

        public static void OnSafeGameStart()
        {
            Game game = Game.instance;
            List<BloonModel> models = game.getAllBloonModels();
            foreach (var model in models)
            {
                Logger.Log(model.name);
            }
        }
        
        [HarmonyPatch(typeof(TitleScreen), "Start")]
        class LoadHook
        {
            [HarmonyPostfix]
            internal static void Postfix(TitleScreen __instance)
            {
                OnSafeGameStart();
            }
        }
    }
}