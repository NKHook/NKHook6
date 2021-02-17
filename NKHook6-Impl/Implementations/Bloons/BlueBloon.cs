using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class BlueBloon : NBloon
    {
        public BlueBloon() : base(CGame.instance.getBloonModel("Blue"))
        {
        }
        internal BlueBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    