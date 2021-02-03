using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Simulation.Towers;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Towers;
using NKHook6_Impl.Implementations.Towers;

namespace NKHook6_Impl.Towers
{
    [HarmonyPatch(typeof(Tower), nameof(Tower.OnDestroy))]
    internal class DeletedPatch
    {
        [HarmonyPostfix]
        internal static void Postfix(Tower __instance)
        {
            NTowerEntity towerEntity = new NTowerEntity(__instance);
            var o = new TowerEvents.DeletedEvent(towerEntity); //Create DeletedEvent instance
            EventRegistry.instance.dispatchEvent(ref o); //Dispatch it
        }
    }
}