using MelonLoader;
using NKHook6.API;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Events._Game;
using NKHook6.API.Registry;
using CGame = Assets.Scripts.Unity.Game;

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

        public void OnModLoaded()
        {
            CGame.instance.isModdedClient.value = true;
            EventRegistry.instance.Listen(typeof(Entry));
        }
    }
}