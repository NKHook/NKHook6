using System.Collections.Generic;
using Assets.Main.Scenes;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using Harmony;
using MelonLoader;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
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
            EventRegistry.instance.listen(typeof(Entry));
        }

        [EventAttribute("BloonCreatedEvent")]
        public static void onCreated(BloonEvents.CreatedEvent e)
        {
            Logger.Log("Bloon created event");
        }
        [EventAttribute("BloonMoveEvent")]
        public static void onMove(BloonEvents.MoveEvent e)
        {
            IBloonEntity bloon = e.bloon;
            Logger.Log("Progress: "+bloon.getProgress());
            float[] pos = bloon.getPosition();
            Logger.Log("Position (X,Y,Z)".Replace("X", pos[0].ToString()).Replace("Y", pos[1].ToString()).Replace("Z", pos[2].ToString()));
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