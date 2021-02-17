using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Unity.Bridge;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Towers;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Towers;

namespace NKHook6_Impl.Towers
{
    [HarmonyPatch(typeof(TowerToSimulation), nameof(TowerToSimulation.Upgrade))]
    internal class UpgradePatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(TowerToSimulation __instance, int pathIndex, Il2CppSystem.Action<bool> callback)
        {
            NTowerEntity towerEntity = new NTowerEntity(__instance.tower);
            var o = new TowerEvents.UpgradeEvent(towerEntity); //Create UpgradePatch instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
            return !o.IsCancelled();
        }
    }
}