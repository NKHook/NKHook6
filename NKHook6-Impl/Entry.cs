using MelonLoader;
using NKHook6.API;
using NKHook6.API.Events;

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
            EventRegistry.instance.Listen(typeof(Entry));
        }
    }
}