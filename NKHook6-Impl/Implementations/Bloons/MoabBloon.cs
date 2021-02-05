
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class MoabBloon : NBloon
    {
        public MoabBloon() : base(Game.instance.getBloonModel("Moab"))
        {
        }
        internal MoabBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
        {
        }
    }
}
    