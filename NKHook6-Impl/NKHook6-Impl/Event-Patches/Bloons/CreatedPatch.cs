using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.Objects;
using Harmony;
using NKHook6.API.Bloons;
using NKHook6.API.Events;
using NKHook6.API.Events._Bloons;
using NKHook6_Impl.Implementations;

namespace NKHook6_Impl.Bloons
{
    [HarmonyPatch(typeof(Bloon), "Initialise")]
    public class CreatedPatch
    {
        [HarmonyPostfix]
        internal static void Postfix(Bloon __instance)
        {
            NBloonEntity bloonEntity = new NBloonEntity(__instance);
            var o = new BloonEvents.CreatedEvent(bloonEntity); //Create CreatedEvent instance
            EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
        }
    }
}