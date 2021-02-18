using Assets.Scripts.Unity.UI_New.InGame;
using Harmony;
using KHook6_Impl.Implementations.Game;
using NKHook6.API.Events._Game;
using NKHook6.API.Game;
using NKHook6.API.Registry;

namespace NKHook6_Impl.Game
{
    [HarmonyPatch(typeof(InGame), nameof(InGame.RoundEnd))]
    internal class RoundEndPatch
    {
        [HarmonyPrefix]
        internal static void Prefix(InGame __instance)
        {
            IGameInstance gameInstance = NGameInstance.GetGame();
            int currentRound = __instance.bridge.simulation.GetSpawnedRound();
            var o = new GameEvents.RoundEndEvent(gameInstance, currentRound); //Create RoundEndEvent instance
            EventRegistry.instance.DispatchEvent(ref o); //Dispatch it
        }
    }
}