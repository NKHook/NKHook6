using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
    [HarmonyPatch(typeof(Bloon), "Leaked")]
    internal class LeakedPatch
    {
        [HarmonyPostfix]
        internal static void Postfix(Bloon __instance)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.LeakedEvent(bloonEntity); //Create LeakedEvent instance
            EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
        }
    }
}