using NKHook6.API.Game;

namespace KHook6_Impl.Implementations.Game
{
    public class NPlayer : IPlayer
    {
        public double GetCash()
        {
            return NGameInstance.GetGame().GetNative().bridge.simulation.cashManagers.entries[0].value.cash.Value;
        }

        public void SetCash(double value)
        {
            NGameInstance.GetGame().GetNative().bridge.simulation.cashManagers.entries[0].value.cash.Value = value;
        }
    }
}