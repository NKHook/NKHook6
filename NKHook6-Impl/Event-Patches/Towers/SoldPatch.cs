using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Towers;
using Harmony;
using NKHook6.API.Events;
using NKHook6.API.Events._Towers;
using NKHook6_Impl.Implementations.Towers;

namespace NKHook6_Impl.Towers
{
    [HarmonyPatch(typeof(Simulation), nameof(Simulation.SellTower))]
    internal class SoldPatch
    {
        [HarmonyPrefix]
        internal static bool Prefix(Simulation __instance, Tower tower, int inputId)
        {
            NTowerEntity towerEntity = new NTowerEntity(tower);
            var o = new TowerEvents.SoldEvent(towerEntity, tower.SaleValue); //Create SoldPatch instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
            return !o.IsCancelled();
        }
    }
}