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
        private static float _lastRotation;
        
        [HarmonyPrefix]
        internal static bool Prefix(Bloon __instance, float rotation)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.RotateEvent(bloonEntity, rotation); //Create RotateEvent instance
            if (rotation != _lastRotation)
            {
                _lastRotation = rotation;
                EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
            }
            return !o.isCancelled();
        }
    }
}