using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
    [HarmonyPatch(typeof(Bloon), "SetRotation")]
    internal class RotatePatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(Bloon __instance, float rotation)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.RotateEvent(bloonEntity, rotation); //Create RotateEvent instance
            if (rotation != bloonEntity.getRotation())
            {
                EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
            }
            return !o.isCancelled();
        }
    }
}