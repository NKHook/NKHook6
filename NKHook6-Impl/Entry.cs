using Assets.Scripts.Unity;
using MelonLoader;
using NKHook6.API;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;
using NKHook6.API.Registry;
//using NKHook6_Tests;

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

        public void onModLoaded()
        {
            Logger.Log("Loading at modstart...");
            EventRegistry.instance.listen(typeof(Entry));
            //BloonRegistry.instance += new ModBloon();
            foreach(var bloon in Game.instance.model.bloons) {
                Logger.Log(bloon.name);
            }
            Logger.Log("Loaded at modstart");
        }
    }
}