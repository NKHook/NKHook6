
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class DdtBloon : NBloon
    {
        public DdtBloon() : base(Game.instance.getBloonModel("Ddt"))
        {
        }
        internal DdtBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    