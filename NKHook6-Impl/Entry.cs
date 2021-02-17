using Assets.Scripts.Unity;
using MelonLoader;
using NKHook6.API;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;
using NKHook6.API.Registry;
using NKHook6.API.Events._Game;

namespace NKHook6_Impl
{
    public class Entry : MelonMod, BTDModStart
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("Starting NKHook6 API Implementation");

            new EventRegistry(); //Initialize EventRegistry

            Logger.Log("Google translate of NKHook6 API to TARGET has begun".Replace("TARGET", "BloonsTD6"));
        }

        [EventAttribute("RoundStartEvent")]
        public static void onRound(GameEvents.RoundStartEvent e)
        {
            Logger.Log("Round: "+e.round);
        }

        public void OnModLoaded()
        {
            EventRegistry.instance.Listen(typeof(Entry));
        }
    }
}