
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class BfbBloon : NBloon
    {
        public BfbBloon() : base(Game.instance.getBloonModel("Bfb"))
        {
        }
        internal BfbBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    