using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Unity.UI_New.InGame;
using Harmony;
using KHook6_Impl.Implementations.Game;
using NKHook6.API.Events;
using NKHook6.API.Events._Game;
using NKHook6.API.Game;
using NKHook6.API.Registry;

namespace NKHook6_Impl.Game
{
    [HarmonyPatch(typeof(UnityToSimulation), nameof(UnityToSimulation.StartRound))]
    internal class RoundStartPatch
    {
        [HarmonyPrefix]
        internal static void Prefix(UnityToSimulation __instance)
        {
            IGameInstance gameInstance = NGameInstance.GetGame();
            int currentRound = __instance.simulation.GetSpawnedRound()+1;
            var o = new GameEvents.RoundStartEvent(gameInstance, currentRound); //Create RoundStartEvent instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
        }
    }
}