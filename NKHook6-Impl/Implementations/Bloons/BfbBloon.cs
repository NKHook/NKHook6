using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class BfbBloon : NBloon
    {
        public BfbBloon() : base(CGame.instance.getBloonModel("Bfb"))
        {
        }
        internal BfbBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    