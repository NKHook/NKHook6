using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
    [HarmonyPatch(typeof(Bloon), nameof(Bloon.Leaked))]
    internal class LeakedPatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(Bloon __instance)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.LeakedEvent(bloonEntity); //Create LeakedEvent instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
            return !o.IsCancelled();
        }
    }
}