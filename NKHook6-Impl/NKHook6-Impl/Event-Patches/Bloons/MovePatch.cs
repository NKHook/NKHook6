using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
    [HarmonyPatch(typeof(Bloon), "Process")]
    public class MovePatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(Bloon __instance, int elapsed)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.MoveEvent(bloonEntity); //Create CreatedEvent instance
            EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
            return !o.isCancelled();
        }
    }
}