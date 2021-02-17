using CGame = Assets.Scripts.Unity.Game;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
    public class MoabBloon : NBloon
    {
        public MoabBloon() : base(CGame.instance.getBloonModel("Moab"))
        {
        }
        internal MoabBloon(string modelName) : base(CGame.instance.getBloonModel(modelName))
        {
        }
    }
}
    