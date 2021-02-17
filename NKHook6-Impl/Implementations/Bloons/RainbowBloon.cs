using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class RainbowBloon : NBloon
    {
        public RainbowBloon() : base(CGame.instance.getBloonModel("Rainbow"))
        {
        }
        internal RainbowBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    