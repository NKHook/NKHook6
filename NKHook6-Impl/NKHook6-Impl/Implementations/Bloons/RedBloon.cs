using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations
{
    public class RedBloon : NBloon
    {
        public RedBloon() : base(Game.instance.getBloonModel("Red"))
        {
        }
        internal RedBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}