using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class RedBloon : NBloon
    {
        public RedBloon() : base(CGame.instance.getBloonModel("Red"))
        {
        }
        internal RedBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    