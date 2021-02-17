using Assets.Scripts.Unity.Bridge;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Towers;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Towers;

namespace NKHook6_Impl.Towers
{
    [HarmonyPatch(typeof(TowerToSimulation), nameof(TowerToSimulation.IsSelectable))]
    internal class SelectedPatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(TowerToSimulation __instance)
        {
            NTowerEntity towerEntity = new NTowerEntity(__instance.tower);
            var o = new TowerEvents.SelectedEvent(towerEntity); //Create SelectedPatch instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
            return !o.IsCancelled();
        }
    }
}