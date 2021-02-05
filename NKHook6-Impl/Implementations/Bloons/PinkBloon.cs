
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class PinkBloon : NBloon
    {
        public PinkBloon() : base(Game.instance.getBloonModel("Pink"))
        {
        }
        internal PinkBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    